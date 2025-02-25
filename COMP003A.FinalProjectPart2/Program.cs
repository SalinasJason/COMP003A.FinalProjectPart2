using COMP003A.FinalProjectPart2;

namespace COMP003A.FinalProjectPart2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int choice = 0;
            Console.WriteLine("Welcome to the Library System");

            Console.WriteLine("Main Menu: ");
            Console.WriteLine("1. Add Physical Book");
            Console.WriteLine("2. Add eBook");
            Console.WriteLine("3. View Book");
            Console.WriteLine("4. Edit Book");
            Console.WriteLine("5. Delete Book");
            Console.WriteLine("6. Exit");
            Console.Write("Enter your choice: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1: 
                    Console.WriteLine("Enter book title");
                    break;
                case 2:
                    Console.WriteLine();
                    break;
                case 3:
                    Console.WriteLine();
                    break;
                case 4:
                    Console.WriteLine();
                    break;
                case 5:
                    Console.WriteLine();
                    break;
                case 6:
                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine();
                    break ;
            }
        }
    }
}
