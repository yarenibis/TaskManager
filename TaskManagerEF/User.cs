using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TaskManagerEF
{
    [Table("Users")]
    public class User
    {


        public int id { get;  set; }
        public string name { get; set; }

        public string email { get; set; }
        public string password { get; set; }

        public string role { get; set; }
        public virtual List<Note> Notes { get; set; }


    }
}
