using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookLibrary;

namespace BookExtension
{
    public class OutByAuthorTitle : IStringType
    {
        /// <summary>
        /// Get book info
        /// </summary>
        /// <param name="book">Book</param>
        /// <returns>Book info</returns>
        public string getInfo(Book book)
        {
            return $"Book record: {book.Author} {book.Title}";
        }
    }
}
