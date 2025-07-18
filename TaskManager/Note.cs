using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    internal class Note
    {
        public Guid id { get; set; } = Guid.NewGuid();
        public string title { get; set; }
        public string content { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }

        public Note(string title, string content)
        {
            this.title = title;
            this.content = content;

            CreatedDate = DateTime.Now;
            UpdatedDate = DateTime.Now;
        }
    }
}
