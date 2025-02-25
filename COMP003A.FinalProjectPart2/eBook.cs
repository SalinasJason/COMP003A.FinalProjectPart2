using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP003A.FinalProjectPart2
{
    /// <summary>
    /// Dervied class that inherits from LibraryBooks
    /// </summary>
    internal class eBook : LibraryBooks
    {
        // Field
        private int _fliesize;

        // Property
        public int Filesize
        {
            get { return _fliesize; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("File size cannot be less then or 0");
                    throw new ArgumentException();
                }
                _fliesize = value;
            }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="TitleInput"></param>
        /// <param name="AuthorInput"></param>
        /// <param name="FileSizeInput"></param>
        public eBook(string TitleInput, string AuthorInput, int FileSizeInput)
        {
            Title = TitleInput;
            Author = AuthorInput;
            Filesize = FileSizeInput;
        }

        /// <summary>
        /// Method that overrides DisplayBooksInfo
        /// </summary>
        public override void DisplayBooksInfo()
        {
            Console.WriteLine($"Title: {Title}, Author: {Author}, File size: {Filesize}");
        }
    }
}
