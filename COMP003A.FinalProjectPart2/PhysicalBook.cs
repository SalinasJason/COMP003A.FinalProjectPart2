using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using COMP003A.FinalProjectPart2;

namespace COMP003A.FinalProjectPart2
{
    /// <summary>
    /// Dervied class that inherits from LibraryBooks
    /// </summary>
    internal class PhysicalBook : LibraryBooks
    {
        // Field
        private int _pages;

        // Property
        public int Pages 
        { 
            get { return _pages; } 
            set 
            { 
                if (value <= 0)
                {
                    Console.WriteLine("Page number cannot be less then or 0");
                    throw new ArgumentException();
                }
                _pages = value;
            } 
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="TitleInput"></param>
        /// <param name="AuthorInput"></param>
        /// <param name="PageInput"></param>
        public PhysicalBook (string TitleInput, string AuthorInput, int PageInput)
        {
            Title = TitleInput;
            Author = AuthorInput;
            Pages = PageInput;
        }


        /// <summary>
        /// Method that overrides DisplayBooksInfo
        /// </summary>
        public override void DisplayBooksInfo()
        {
            Console.WriteLine($"Title: {Title}, Author: {Author}, Number of Pages: {Pages}");
        }
    }
}