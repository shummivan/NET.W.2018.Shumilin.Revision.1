using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary
{
    public class Book
    {
        #region Fields
        private string title;
        private string author;
        private string year;
        private string publishingHouse;
        private string edition;
        private string pages;
        private string price;
        #endregion

        #region Property
        public string Title
        {
            get => title;
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new Exception();
                }
                title = value;
            }
        }
        public string Author
        {
            get => author;
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new Exception();
                }
                author = value;
            }
        }
        public string Year
        {
            get => year;
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new Exception();
                }
                year = value;
            }
        }
        public string PublishingHose
        {
            get => publishingHouse;
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new Exception();
                }
                publishingHouse = value;
            }
        }
        public string Edition
        {
            get => edition;
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new Exception();
                }
                edition = value;
            }
        }
        public string Pages
        {
            get => pages;
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new Exception();
                }
                pages = value;
            }
        }
        public string Price
        {
            get => price;
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new Exception();
                }
                price = value;
            }
        }
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="title">Title</param>
        /// <param name="author">Athor</param>
        /// <param name="publishingHose">Publishing house</param>
        /// <param name="edition">Edition</param>
        /// <param name="pages">Pages</param>
        /// <param name="price">Price</param>
        public Book(string title, string author, string publishingHose, string edition, string pages, string price)
        {
            Title = title;
            Author = author;
            PublishingHose = publishingHose;
            Edition = edition;
            Pages = pages;
            Price = price;
        }
        #endregion
    }
}
