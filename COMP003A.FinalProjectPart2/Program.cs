using COMP003A.FinalProjectPart2;

namespace COMP003A.FinalProjectPart2
{
    internal class Program
    {
        // List to store books
        static List<LibraryBooks> LibraryInventory = new List<LibraryBooks>();
        static void Main(string[] args)
        {
           
            int choice = 0;

            // Welcomes the user
            Console.WriteLine("Welcome to the Library System");


            // Do-while loop to keep menu runnning until user enters the number 6
            do
            {
                // Display Main Menu
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
            if (LibraryInventory.Count > 0) // Checks if the list has any books and if it does excute the code
            {
                Console.WriteLine("Displaying books");
                foreach (LibraryBooks Book in LibraryInventory) // Iterates through each book in the list
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
            if (LibraryInventory.Count > 0) // Checks if the list has any books and if it does excute the code
            {
                Console.Write("\nEnter book title to edit: ");
                string ifBook = Console.ReadLine();
                bool ifBookExist = false;

                foreach (LibraryBooks book in LibraryInventory) // Iterates through each book in the list
                {
                    if (book is PhysicalBook NewPhysicalBook && NewPhysicalBook.Title == ifBook) // Checks if the book is Physical and it if matchs the title
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
                            Console.WriteLine("Physical book edited successfully");
                            ifBookExist = true;
                        }
                        catch { }
                    }
                    else if (book is eBook NeweBook && NeweBook.Title == ifBook) // Checks if the book is Ebook and it matchs the title
                    {
                        try
                        {
                            Console.Write("Enter new eBook title: ");
                            string newEBookTitle = Console.ReadLine();
                            NeweBook.Title = newEBookTitle;

                            Console.Write("Enter new author: ");
                            string newEbookAuthor = Console.ReadLine();
                            NeweBook.Author = newEbookAuthor;

                            Console.Write("Enter new file size: ");
                            int newEbookFileSize = int.Parse(Console.ReadLine());
                            NeweBook.Filesize = newEbookFileSize;

                            Console.WriteLine("eBook edited successfully");
                            ifBookExist = true;
                        }
                        catch { }
                    }
                }
                if (ifBookExist == false) // If book is still false excute code
                {
                    Console.WriteLine("Book not found");
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
            if (LibraryInventory.Count > 0) // Checks if the list has any books and if it does excute the code
            {
                Console.Write("Enter book title to delete: ");
                string deleteBook = Console.ReadLine();
                bool BookExist = false;

                for (int i = 0; i < LibraryInventory.Count; i++) // Iterates through each book in the list
                {
                    if (LibraryInventory[i].Title == deleteBook) // Checks if book title matches the title to be deleted
                    {
                        LibraryInventory.RemoveAt(i);
                        Console.WriteLine("Book deleted successfully");
                        BookExist = true;
                    }
                }
                if (BookExist == false) // If book is still false excute code
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
