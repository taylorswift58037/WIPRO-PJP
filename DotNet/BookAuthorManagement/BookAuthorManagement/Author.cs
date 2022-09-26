using System;
using System.Collections.Generic;
using System.Text;

namespace BookAuthorManagement
{
    class Author
    {
        string AuthorName, AuthorEmail;
        char Gender;
        public void AddAuthor(string name,string email,char gender)
        {
            this.AuthorName = name;
            this.AuthorEmail = email;
            this.Gender = gender;
        }
        public string name
        {
            get
            {
                return AuthorName;
            }
            set
            {
                AuthorName = value;
            }
        }
        public string email
        {
            get
            {
                return AuthorEmail;
            }
            set
            {
                AuthorEmail = value;
            }
        }
        public char gender
        {
            get
            {
                return Gender;
            }
            set
            {
                Gender = value;
            }
        }
    }
}
