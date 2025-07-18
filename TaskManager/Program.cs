using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool working = true;

            User user = new User("Yaren", "yaren@gmail.com", "123");
            NoteManager noteManager = new NoteManager();

            while (true)
            {

                Console.WriteLine("1 - Add Note");
                Console.WriteLine("2 - List Notes");
                Console.WriteLine("3 - Update Note");
                Console.WriteLine("4 - Delete Note");
                Console.WriteLine("0 - Quit");

                Console.WriteLine("Choose: ");
                var choice = Console.ReadLine();


                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Write yoru title: ");
                        var input1 = Console.ReadLine();
                        Console.WriteLine("Write yoru title: ");
                        var input2 = Console.ReadLine();

                        Note note = new Note(input1, input2);
                        noteManager.AddNote(user, note);
                        break;
                    case "2":
                        noteManager.GetNotes(user);
                        foreach (var n in user.notes)
                        {
                            Console.WriteLine($"{n.id}:{n.title}:{n.content}");
                        }
                        break;
                    case "3":
                        foreach (var n in user.notes)
                        {
                            Console.WriteLine($"{n.id}:{n.title}:{n.content}");
                        }
                        Console.WriteLine("choose the id of the note you want to update");
                        string updtid = (Console.ReadLine());
                        Guid noteId = Guid.Parse(updtid);

                        Console.WriteLine("write your new title and content");
                        var input_title = Console.ReadLine();
                        var input_content = Console.ReadLine();

                        noteManager.UpdateNote(noteId, user, input_title, input_content);
                        break;

                    case "4":
                        foreach (var n in user.notes)
                        {
                            Console.WriteLine($"{n.id}:{n.title}:{n.content}");
                        }
                        Console.WriteLine("choose the id of the note you want to delete");
                        string input_id = Console.ReadLine();
                        Guid deleteId = Guid.Parse(input_id);

                        noteManager.RemoveNote(user, deleteId);
                        break;

                    case "0":
                        Console.WriteLine("Byee! 👋");
                        working = false;
                        break;
                    default:
                        Console.WriteLine("Geçersiz seçim. Lütfen tekrar deneyin.");
                        break;


                }

            }
        }
    }
}
