using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookLibrary;

namespace BookExtension
{
    public class BookFormatExtension
    {
        /// <summary>
        /// Get book info
        /// </summary>
        /// <param name="book">Book</param>
        /// <param name="st">Format type</param>
        /// <returns>Book info</returns>
        public string getInfo(Book book, IStringType st)
        {
            return st.getInfo(book);
        }
    }
}
