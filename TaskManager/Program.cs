using System;
using System.Collections.Generic;

namespace TaskManager
{
    internal class Program
    {
        static NoteManager noteManager = new NoteManager();
        static UserManager userManager = new UserManager();
        static bool working = true;

        static void Main(string[] args)
        {
            // Başlangıçta bir admin oluşturalım ki giriş yapılabilsin
            var admin = new User("Admin", "admin@admin.com", "1234", UserRole.Admin);
            userManager.AddUser(admin);

            while (working)
            {
                Console.WriteLine("\n=== Login Page ===");
                Console.Write("Email: ");
                string email = Console.ReadLine();

                Console.Write("Password: ");
                string password = Console.ReadLine();

                var loggedInUser = userManager.Login(email, password);

                if (loggedInUser == null)
                {
                    Console.WriteLine("❌ Login failed. Try again.");
                    continue;
                }

                if (loggedInUser.Role == UserRole.Admin)
                {
                    ShowAdminMenu(loggedInUser);
                }
                else
                {
                    ShowUserMenu(loggedInUser);
                }
            }
        }

        static void ShowAdminMenu(User user)
        {
            while (true)
            {
                Console.WriteLine("\n👑 Admin Menu");
                Console.WriteLine("1 - Add Note");
                Console.WriteLine("2 - List Notes");
                Console.WriteLine("3 - Update Note");
                Console.WriteLine("4 - Delete Note");
                Console.WriteLine("5 - Add User");
                Console.WriteLine("6 - Delete User");
                Console.WriteLine("7 - Update User");
                Console.WriteLine("8 - List Users");
                Console.WriteLine("0 - Logout");

                Console.Write("Choose: ");
                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Title: ");
                        string title = Console.ReadLine();
                        Console.Write("Content: ");
                        string content = Console.ReadLine();
                        noteManager.AddNote(user, new Note(title, content));
                        break;

                    case "2":
                        foreach (var n in user.notes)
                            Console.WriteLine($"{n.id}: {n.title} - {n.content}");
                        break;

                    case "3":
                        foreach (var n in user.notes)
                            Console.WriteLine($"{n.id}: {n.title}");
                        Console.Write("Enter note ID: ");
                        var updateId = Guid.Parse(Console.ReadLine());
                        Console.Write("New Title: ");
                        var newTitle = Console.ReadLine();
                        Console.Write("New Content: ");
                        var newContent = Console.ReadLine();
                        noteManager.UpdateNote(updateId, user, newTitle, newContent);
                        break;

                    case "4":
                        foreach (var n in user.notes)
                            Console.WriteLine($"{n.id}: {n.title}");
                        Console.Write("Enter note ID: ");
                        var deleteNoteId = Guid.Parse(Console.ReadLine());
                        noteManager.RemoveNote(user, deleteNoteId);
                        break;

                    case "5":
                        Console.Write("Name: ");
                        string name = Console.ReadLine();
                        Console.Write("Email: ");
                        string email = Console.ReadLine();
                        Console.Write("Password: ");
                        string pwd = Console.ReadLine();
                        Console.Write("Role (Admin/User): ");
                        string roleInput = Console.ReadLine();

                        if (Enum.TryParse<UserRole>(roleInput, true, out UserRole role))
                        {
                            User newUser = new User(name, email, pwd, role);
                            userManager.AddUser(newUser);
                            Console.WriteLine("✅ User added.");
                        }
                        else
                        {
                            Console.WriteLine("❌ Invalid role.");
                        }
                        break;

                    case "6":
                        foreach (var u in userManager.GetAllUsers())
                            Console.WriteLine($"{u.id}: {u.name} - {u.email}");

                        Console.Write("Enter user ID to delete: ");
                        Guid delId = Guid.Parse(Console.ReadLine());
                        userManager.RemoveUser(delId);
                        Console.WriteLine("✅ User removed.");
                        break;

                    case "7":
                        foreach (var u in userManager.GetAllUsers())
                            Console.WriteLine($"{u.id}: {u.name} - {u.email} - {u.Role}");

                        Console.Write("Enter user ID to update: ");
                        Guid updateUserId = Guid.Parse(Console.ReadLine());
                        Console.Write("New Name: ");
                        string newName = Console.ReadLine();
                        Console.Write("New Email: ");
                        string newMail = Console.ReadLine();
                        Console.Write("New Password: ");
                        string newPass = Console.ReadLine();
                        Console.Write("New Role: ");
                        string roleStr = Console.ReadLine();

                        if (Enum.TryParse<UserRole>(roleStr, true, out UserRole newRole))
                        {
                            userManager.UpdateUser(updateUserId, newName, newMail, newPass, newRole);
                            Console.WriteLine("✅ User updated.");
                        }
                        else
                        {
                            Console.WriteLine("❌ Invalid role.");
                        }
                        break;

                    case "8":
                        foreach (var u in userManager.GetAllUsers())
                            Console.WriteLine($"{u.id}: {u.name} - {u.email} - {u.Role}");
                        break;

                    case "0":
                        Console.WriteLine("Logging out...");
                        return;

                    default:
                        Console.WriteLine("❌ Invalid choice.");
                        break;
                }
            }
        }

        static void ShowUserMenu(User user)
        {
            while (true)
            {
                Console.WriteLine("\n📝 User Menu");
                Console.WriteLine("1 - Add Note");
                Console.WriteLine("2 - List Notes");
                Console.WriteLine("3 - Update Note");
                Console.WriteLine("4 - Delete Note");
                Console.WriteLine("0 - Logout");

                Console.Write("Choose: ");
                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Title: ");
                        string title = Console.ReadLine();
                        Console.Write("Content: ");
                        string content = Console.ReadLine();
                        noteManager.AddNote(user, new Note(title, content));
                        break;

                    case "2":
                        foreach (var n in user.notes)
                            Console.WriteLine($"{n.id}: {n.title} - {n.content}");
                        break;

                    case "3":
                        foreach (var n in user.notes)
                            Console.WriteLine($"{n.id}: {n.title}");
                        Console.Write("Enter note ID: ");
                        var updateId = Guid.Parse(Console.ReadLine());
                        Console.Write("New Title: ");
                        var newTitle = Console.ReadLine();
                        Console.Write("New Content: ");
                        var newContent = Console.ReadLine();
                        noteManager.UpdateNote(updateId, user, newTitle, newContent);
                        break;

                    case "4":
                        foreach (var n in user.notes)
                            Console.WriteLine($"{n.id}: {n.title}");
                        Console.Write("Enter note ID: ");
                        var deleteId = Guid.Parse(Console.ReadLine());
                        noteManager.RemoveNote(user, deleteId);
                        break;

                    case "0":
                        Console.WriteLine("Logging out...");
                        return;

                    default:
                        Console.WriteLine("❌ Invalid choice.");
                        break;
                }
            }
        }
    }
}
