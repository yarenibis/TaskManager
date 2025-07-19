using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TaskManager
{
    internal class User
    {
       

        public Guid id { get; private set; }= Guid.NewGuid();
        public string name { get; set; }
        public string email { get; set; }
        public string password{  get; set; }

        public UserRole Role { get; set; } = UserRole.User;
        public List<Note> notes { get; set; } = new List<Note>();

        public User(string name, string email, string password, UserRole role = UserRole.User)
        {
            this.name = name;
            this.email = email;
            this.password = password;
            Role = role;
        }
    }
}
