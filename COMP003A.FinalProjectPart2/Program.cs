﻿using COMP003A.FinalProjectPart2;

namespace COMP003A.FinalProjectPart2
{
    internal class Program
    {
        // List to store books
        static List<LibraryBooks> LibraryInventory = new List<LibraryBooks>();
        static void Main(string[] args)
        {
           
            int choice = 0;

            // Display Main Menu
            Console.WriteLine("Welcome to the Library System");


            // Do-while loop to keep menu runnning until user enters the number 6
            do
            {
                
                Console.WriteLine("\nMain Menu: ");
                Console.WriteLine("1. Add Physical Book");
                Console.WriteLine("2. Add eBook");
                Console.WriteLine("3. View Book");
                Console.WriteLine("4. Edit Book");
                Console.WriteLine("5. Delete Book");
                Console.WriteLine("6. Exit");
                Console.Write("Enter your choice: ");

                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch { }

                // Switch Statement
                switch (choice)
                {
                    case 1: // Add Physical Book
                        AddPhysicalBook();
                        break;
                    case 2: // Add eBook
                        AddEbook();
                        break;
                    case 3: // View Book
                        ViewBooks();
                        break;
                    case 4: // Edit Book
                        EditBook();
                        break;
                    case 5: // Delete Book
                        DeleteBook();
                        break;
                    case 6: // Exit
                        Console.WriteLine("Exiting");
                        break;
                    default: // default
                        Console.WriteLine("Invalid input, Please choose from (1-6)");
                        break;
                }
            }
            while (choice != 6);
        }

        // Method to add Physcial Book
        static void AddPhysicalBook()
        {
            Console.Write("Enter book title: ");
            string UserInputBook = Console.ReadLine();

            Console.Write("Enter author: ");
            string UserInputAuthor = Console.ReadLine();

            Console.Write("Enter number of pages: ");
            int UserInputPages = 0;
            try
            {
                UserInputPages = int.Parse(Console.ReadLine());
            }
            catch { }

            try
            {
                PhysicalBook physicalBook = new PhysicalBook(UserInputBook, UserInputAuthor, UserInputPages);
                LibraryInventory.Add(physicalBook);
            }
            catch { }
        }

        // Method to add ebook
        static void AddEbook()
        {
            Console.Write("Enter ebook title: ");
            string UserInputeBook = Console.ReadLine();

            Console.Write("Enter author: ");
            string UserInputeAuthor = Console.ReadLine();

            Console.Write("Enter file size: ");
            int UserInputFilesize = 0;
            try
            {
                UserInputFilesize = int.Parse(Console.ReadLine());
            }
            catch { }

            try
            {
                eBook ebook = new eBook(UserInputeBook, UserInputeAuthor, UserInputFilesize);
                LibraryInventory.Add(ebook);
            }
            catch { }
        }

        // Method to view books
        static void ViewBooks()
        {
            if (LibraryInventory.Count > 0)
            {
                Console.WriteLine("Displaying books");
                foreach (LibraryBooks Book in LibraryInventory)
                {
                    Book.DisplayBooksInfo();
                }
            }
            else
            {
                Console.WriteLine("No books are stored to view");
            }
        }

        // Method to edit book
        static void EditBook()
        {
            if (LibraryInventory.Count > 0)
            {
                Console.Write("\nEnter book title to edit: ");
                string ifBook = Console.ReadLine();

                foreach (LibraryBooks book in LibraryInventory)
                {
                    if (book is PhysicalBook NewPhysicalBook && NewPhysicalBook.Title == ifBook)
                    {
                        try
                        {
                            Console.Write("Enter new Book title: ");
                            string newTitle = Console.ReadLine();
                            NewPhysicalBook.Title = newTitle;

                            Console.Write("Enter new author: ");
                            string newAuthor = Console.ReadLine();
                            NewPhysicalBook.Author = newAuthor;

                            Console.Write("Enter new number of pages: ");
                            int newPages = int.Parse(Console.ReadLine());
                            NewPhysicalBook.Pages = newPages;
                            Console.WriteLine("eBook edited successfully");
                        }
                        catch { }
                    }
                    else if (book is eBook NeweBook && NeweBook.Title == ifBook)
                    {
                        try
                        {
                            Console.Write("Enter new eBook title: ");
                            string newTitle = Console.ReadLine();

                            Console.Write("Enter new author: ");
                            string newEbookAuthor = Console.ReadLine();
                            NeweBook.Author = Console.ReadLine();

                            Console.Write("Enter new file size: ");
                            int newEbookFileSize = int.Parse(Console.ReadLine());
                            NeweBook.Filesize = newEbookFileSize;

                            Console.WriteLine("eBook edited successfully");
                        }
                        catch { }
                    }
                    else
                    {
                        Console.WriteLine("Book not found");
                    }
                }

            }
            else
            {
                Console.WriteLine("No books are stored to edit");
            }
        }

        // Method to delete book
        static void DeleteBook()
        {
            if (LibraryInventory.Count > 0)
            {
                Console.Write("Enter book title to delete: ");
                string deleteBook = Console.ReadLine();
                bool BookExist = false;

                for (int i = 0; i < LibraryInventory.Count; i++)
                {
                    if (LibraryInventory[i].Title == deleteBook)
                    {
                        LibraryInventory.RemoveAt(i);
                        Console.WriteLine("Book deleted successfully");
                        BookExist = true;
                    }
                }
                if (BookExist == false)
                {
                    Console.WriteLine("Book not found. Please try again.");
                }
            }
            else
            {
                Console.WriteLine("No books are stored to delete");
            }
        }
    }
}
