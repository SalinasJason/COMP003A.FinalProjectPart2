using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.FinalProjectPart2
{
    /// <summary>
    /// Represents a base class for books to inherit
    /// </summary>
    internal abstract class LibraryBooks
    {
        // Fields
        private string _title;
        private string _author;

        // Properties
        public string Title
        {
            get { return _title; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("Title cannot be empty or null, Please try again");
                    throw new ArgumentException();
                }
                _title = value;
            }
        }

        public string Author
        {
            get { return _author; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("Author cannot be empty or null, Please try again");
                    throw new ArgumentException();
                }
                _author = value;
            }
        }

        /// <summary>
        /// Abstract method with no implemtion
        /// </summary>
        public abstract void DisplayBooksInfo(); 
    }
}
