using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TaskManagerEF
{
    internal class UserDal
    {
        public List<User> GetAll()
        {
            using (TaskManagerContext tc = new TaskManagerContext())
            {
                return tc.Users.ToList();
            }
        }


        public List<User> GetByName( string name)
        {
            using (TaskManagerContext tc = new TaskManagerContext())
            {
                return tc.Users.Where(p => p.name == name).ToList();
            }
        }


        public User Login(string mail, string pwd)
        {
            using (TaskManagerContext tc = new TaskManagerContext())
            {
                return tc.Users.FirstOrDefault(p => p.email == mail && p.password == pwd);
            }
        }

        public void Add(User user) {
            using (TaskManagerContext tc = new TaskManagerContext())
            {
                tc.Users.Add(user);
                tc.SaveChanges();
            }
        }

        public void Update(User user) { 
        
        using(TaskManagerContext tc = new TaskManagerContext())
            {
                var entity=tc.Entry(user); //user nesnesine ait entity state alınır
                entity.State= System.Data.Entity.EntityState.Modified; //güncellenecek olarak işaretlenir.
                tc.SaveChanges(); //veritabanında güncellenir.
            }
                
        }


        public void Delete(User user)
        {

            using (TaskManagerContext tc = new TaskManagerContext())
            {
                var entity = tc.Entry(user);
                entity.State = System.Data.Entity.EntityState.Deleted;
                tc.SaveChanges();
            }

        }
    }
}
