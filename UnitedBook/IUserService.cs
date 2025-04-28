using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitedBook
{
    public interface IUserService
    {
        User login(string username, string password);
        BindingList<User> getUsers();
        BindingList<Role> getRoles();
        bool createUser(User user);
        bool deleteUser(User ausgewählterUser);
    }
}
