using NUnit.Framework;
using BookLibrary;
using BookExtension;

namespace BookExtension.Tests
{
    [TestFixture]
    public class BookFormatExtensionTests
    {
        [TestCase(ExpectedResult = "Book record: C# in Depth")]
        public string GetBookInfo_ByName_ValidResult()
        {
            Book book1 = new Book("C# in Depth", "Jon Skeet", "Manning", "2019", "900", "40$");
            BookFormatExtension bfe = new BookFormatExtension();
            
            return bfe.getInfo(book1, new OutByName());
        }

        [TestCase(ExpectedResult = "Book record: Jon Skeet C# in Depth")]
        public string GetBookInfo_ByAuthorTitle_ValidResult()
        {
            Book book1 = new Book("C# in Depth", "Jon Skeet", "Manning", "2019", "900", "40$");
            BookFormatExtension bfe = new BookFormatExtension();

            return bfe.getInfo(book1, new OutByAuthorTitle());
        }

        [TestCase(ExpectedResult = "Book record: Jon Skeet C# in Depth  Manning 2019 900 40$")]
        public string GetBookInfo_ByFull_ValidResult()
        {
            Book book1 = new Book("C# in Depth", "Jon Skeet", "Manning", "2019", "900", "40$");
            BookFormatExtension bfe = new BookFormatExtension();

            return bfe.getInfo(book1, new OutFull());
        }
    }
}
