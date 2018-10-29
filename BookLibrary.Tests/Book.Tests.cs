using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using BookLibrary;
using BookExtension;

namespace BookLibrary.Tests
{
    public class Class1
    {
        [TestCase(ExpectedResult = "Book record: C# in Depth")]
        public string GetBookInfo_ByName_ValidResult()
        {
            Book book1 = new Book("C# in Depth", "Jon Skeet", "Manning", "2019", "900", "40$");

            BookFormatExtension bfe = new BookFormatExtension();

            return bfe.getInfo(book1, new OutByName());
        }
    }
}
