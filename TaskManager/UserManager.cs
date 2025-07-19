using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    internal class UserManager
    {
        private List<User> users =new List<User>();

        public void AddUser(User user)
        {
            users.Add(user);
        }

        public void RemoveUser(Guid user_id) { 
            users.RemoveAll(u => u.id == user_id);
        }

        public List<User> GetAllUsers() { 
            return users; 
        }

        public User UpdateUser(Guid user_id, string name,string mail,
            string pwd, UserRole role) { 
            var updated_user = users.FirstOrDefault(i =>i.id == user_id);
            if (updated_user != null)
            {
                updated_user.name = name;
                updated_user.email = mail;
                updated_user.password = pwd;
                updated_user.Role = role;
            }
            return updated_user;
        }


        public User FindUserById(Guid user_id)
        {
            return users.FirstOrDefault(t => t.id == user_id);
        }

        public User Login(string email, string password)
        {
            return users.FirstOrDefault(u => u.email == email && u.password == password);
        }

        

    }
}
