using COMP003A.FinalProjectPart2;

namespace COMP003A.FinalProjectPart2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // List to store books
            List<LibraryBooks> LibraryInventory = new List<LibraryBooks>();
           
            int choice = 0;

            // Display Main Menu
            Console.WriteLine("Welcome to the Library System");


            // Do-while loop to keep menu runnning until user enters the number 6
            do
            {
                
                Console.WriteLine("Main Menu: ");
                Console.WriteLine("1. Add Physical Book");
                Console.WriteLine("2. Add eBook");
                Console.WriteLine("3. View Book");
                Console.WriteLine("4. Edit Book");
                Console.WriteLine("5. Delete Book");
                Console.WriteLine("6. Exit");
                Console.Write("Enter your choice: ");
                choice = int.Parse(Console.ReadLine());

                // Switch Statement
                switch (choice)
                {
                    case 1: // Add Physical Book
                        Console.Write("Enter book title: ");
                        string UserInputBook = Console.ReadLine();

                        Console.Write("Enter author: ");
                        string UserInputAuthor = Console.ReadLine();

                        Console.Write("Enter number of pages: ");
                        int UserInputPages = int.Parse(Console.ReadLine());

                        PhysicalBook physicalBook = new PhysicalBook(UserInputBook, UserInputAuthor, UserInputPages);
                        LibraryInventory.Add(physicalBook);
                        break;
                    case 2: // Add eBook
                        Console.Write("Enter ebook title: ");
                        string UserInputeBook = Console.ReadLine();

                        Console.Write("Enter author: ");
                        string UserInputeAuthor = Console.ReadLine();

                        Console.Write("Enter file size: ");
                        int UserInputFilesize = int.Parse(Console.ReadLine());

                        eBook ebook = new eBook(UserInputeBook, UserInputeAuthor, UserInputFilesize);
                        LibraryInventory.Add(ebook);
                        break;
                    case 3: // View Book
                        Console.WriteLine("Displaying books");
                        foreach (LibraryBooks PhysicalBooks in LibraryInventory)
                        {
                            PhysicalBooks.DisplayBooksInfo();
                        }

                        break;
                    case 4: // Edit Book
                        Console.WriteLine();
                        break;
                    case 5: // Delete Book
                        Console.WriteLine();
                        break;
                    case 6: // Exit
                        Console.WriteLine();
                        break;
                    default: // default
                        Console.WriteLine();
                        break;
                }
            }
            while (choice != 6);
        }
    }
}
