using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagerEF
{
    internal class TaskManagerContext: DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Note> Notes { get; set; }

        public TaskManagerContext() : base(@"Server=YAREN;Database=TaskManagerEF;Integrated Security=True")
        {
            Console.WriteLine("Bağlantı dizesi: " + this.Database.Connection.ConnectionString);
        }

    }
}
