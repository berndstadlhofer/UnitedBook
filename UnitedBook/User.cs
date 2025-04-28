using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitedBook
{
    public class User
    {
        private int id;
        private String firstname;
        private String lastname;
        private String username;
        private String password;
        private Role role;

        public User()
        {
        }

        public User(int id, string firstname, string lastname, string username, string password, Role role)
        {
            this.id = id;
            this.firstname = firstname;
            this.lastname = lastname;
            this.username = username;
            this.password = password;
            this.role = role;
        }

        public int Id { get => id; set => id = value; }
        public string Firstname { get => firstname; set => firstname = value; }
        public string Lastname { get => lastname; set => lastname = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public Role Role { get => role; set => role = value; }

        public override string ToString()
        {
            return username;
        }
    }
}
