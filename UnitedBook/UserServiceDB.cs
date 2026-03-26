using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data.Common;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace UnitedBook
{
    public class UserServiceDB : IUserService
    //in der app.config Namespacename.Klassenname -> UnitedBook.UserServiceDB
    {
        ConnectionStringSettings settings;
        DbProviderFactory factory;

        public UserServiceDB()
        {
            settings = ConfigurationManager.ConnectionStrings["UnitedBookDB"];
            factory = DbProviderFactories.GetFactory(settings.ProviderName);

        }

        private DbParameter createParameter(String name, object value)
        {
            DbParameter p = factory.CreateParameter();
            p.ParameterName = name;
            p.Value = value;
            return p;
        }

        public User login(string username, string password)
        {
            DbConnection con = factory.CreateConnection();
            con.ConnectionString = settings.ConnectionString;
            DbCommand command = con.CreateCommand();
            command.CommandText = "select a.PK_UserID, a.Username, a.Password, a.Firstname, a.Lastname, b.PK_RoleID, b.Name from Users a inner join Roles b on a.FK_RoleID = b.PK_RoleID where a.Username = @username and a.Password = @password;";
            command.Parameters.Add(createParameter("@username", username));

            SHA256 mySha256 = SHA256.Create();
            byte[] data = mySha256.ComputeHash(Encoding.UTF8.GetBytes(password));
            command.Parameters.Add(createParameter("@password", Convert.ToBase64String(data)));

            con.Open();
            DbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                User user = new User();
                user.Id = reader.GetInt32(0);
                user.Username = reader.GetString(1);
                user.Password = reader.GetString(2);
                user.Firstname = reader.GetString(3);
                user.Lastname = reader.GetString(4);
                int id = reader.GetInt32(5);
                String name = reader.GetString(6);
                Role role = new Role(id, name);
                user.Role = role;
                con.Close();
                return user;
            }
            con.Close();
            return null;
        }

        public BindingList<User> getUsers()
        {
            BindingList<User> users = new BindingList<User>();
            DbConnection con = factory.CreateConnection();
            con.ConnectionString = settings.ConnectionString;
            DbCommand command = con.CreateCommand();
            command.CommandText = "select a.PK_UserID, a.Username, a.Password, a.Firstname, a.Lastname, b.PK_RoleID, b.Name from Users a inner join Roles b on a.FK_RoleID = b.PK_RoleID;";

            con.Open();
            DbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                User user = new User();
                user.Id = reader.GetInt32(0);
                user.Username = reader.GetString(1);
                user.Password = reader.GetString(2);
                user.Firstname = reader.GetString(3);
                user.Lastname = reader.GetString(4);
                int id = reader.GetInt32(5);
                String name = reader.GetString(6);
                Role role = new Role(id, name);
                user.Role = role;
                users.Add(user);
            }
            con.Close();
            return users;
        }

        public BindingList<Role> getRoles()
        {
            BindingList<Role> roles = new BindingList<Role>();
            DbConnection con = factory.CreateConnection();
            con.ConnectionString = settings.ConnectionString;
            DbCommand command = con.CreateCommand();
            command.CommandText = "select PK_RoleID, Name from Roles;";

            con.Open();
            DbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                String name = reader.GetString(1);
                Role role = new Role(id, name);
                roles.Add(role);
            }
            con.Close();
            return roles;
        }

        public bool createUser(User user)
        {
            DbConnection con = factory.CreateConnection();
            try
            {

                con.ConnectionString = settings.ConnectionString;
                DbCommand command = con.CreateCommand();
                command.CommandText = "INSERT INTO Users (Username, Password, Firstname, Lastname, FK_RoleID) VALUES (@username, @password, @firstname, @lastname, @role);";

                command.Parameters.Add(createParameter("@username", user.Username));

                SHA256 mySha256 = SHA256.Create();
                byte[] data = mySha256.ComputeHash(Encoding.UTF8.GetBytes(user.Password));
                command.Parameters.Add(createParameter("@password", Convert.ToBase64String(data)));
                command.Parameters.Add(createParameter("@firstname", user.Firstname));
                command.Parameters.Add(createParameter("@lastname", user.Lastname));
                command.Parameters.Add(createParameter("@role", user.Role.Id));

                con.Open();

                int rows = command.ExecuteNonQuery();
                if (rows == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        public bool deleteUser(User ausgewählterUser)
        {
            DbConnection con = factory.CreateConnection();
            try
            {

                con.ConnectionString = settings.ConnectionString;
                DbCommand command = con.CreateCommand();
                command.CommandText = "DELETE from Users where PK_UserID=@id";
                command.Parameters.Add(createParameter("@id", ausgewählterUser.Id));
                con.Open();

                int rows = command.ExecuteNonQuery();
                if (rows == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }
    }
}
