using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagerEF
{
    internal class NoteDal
    {
        public List<Note> GetAll()
        {
            using (TaskManagerContext context = new TaskManagerContext())
            {
                return context.Notes.ToList();
            }
        }

        public void AddNote(Note note)
        {
            using(TaskManagerContext context = new TaskManagerContext())
            {
                context.Notes.Add(note);
                context.SaveChanges();
            }
        }

        public void UpdateNote(Note note) {
            using (TaskManagerContext context = new TaskManagerContext())
            {
                var entity = context.Entry(note);
                entity.State= System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void DeleteNote(Note note)
        {
            using (TaskManagerContext context = new TaskManagerContext())
            {
                var entity = context.Entry(note);
                entity.State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public List<Note> GetNotesByTitle(string title)
        {
            using (TaskManagerContext context = new TaskManagerContext())
            {
                return context.Notes.Where(p => p.title == title).ToList();
            }

        }

        public Note GetNoteById(int id)
        {
            using (TaskManagerContext context = new TaskManagerContext())
            {
                return context.Notes.FirstOrDefault(p => p.id == id);
            }
        }

    }
}
