using System;
using System.Collections.Generic;
using System.Text;

namespace BookAuthorManagement
{
    public class Book
    {
        string ISBN,BookName;
        int Year;
        decimal Price;
        public void AddBook(string isbn,string bookname,int year,decimal price)
        {
            this.ISBN = isbn;
            this.BookName = bookname;
            this.Year = year;
            this.Price = price;
        }
        public string isbn
        {
            get
            {
                return ISBN;
            }
            set
            {
                ISBN = value;
            }
        }
        public string bookname
        {
            get
            {
                return BookName;
            }
            set
            {
                BookName = value;
            }
        }
        public int year
        {
            get
            {
                return Year;
            }
            set
            {
                Year = value;
            }
        }
        public decimal price
        {
            get
            {
                return Price;
            }
            set
            {
                Price = value;
            }
        }
    }
}
