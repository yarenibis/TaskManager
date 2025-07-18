using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    internal class NoteManager
    {

        public void AddNote(User user, Note note)
        {
            user.notes.Add(note);
        }

        public void RemoveNote(User user, Guid noteId)
        {
           user.notes.RemoveAll(note => note.id == noteId);
        }

        public Note UpdateNote(Guid noteId, User user, string newTitle, string newContent)
        {
            var note = user.notes.FirstOrDefault(n => n.id == noteId);
            if (note != null) {
                note.title = newTitle;
                note.content = newContent;
                note.UpdatedDate = DateTime.Now;
            }
            return note;
        }

        public List<Note> GetNotes(User user ) {
            return user.notes.ToList();
        }
    }
}
