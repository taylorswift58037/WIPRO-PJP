using System;
using System.Collections.Generic;
using System.Text;

namespace Person
{
    class Person
    {
        private string FirstName;
        private string LastName;
        private string EmailAddress;
        private DateTime DateofBirth;

        public void person(string fname, string lname, string email, DateTime dob)
        {
            this.FirstName = fname;
            this.LastName = lname;
            this.EmailAddress = email;
            this.DateofBirth = dob;
        }
        public bool isAdult
        {
            get
            {
                int age = new DateTime(DateTime.Now.Subtract(this.DateofBirth).Ticks).Year;
                if(age>18)
                { 
                    return true; 
                }
                else
                {
                    return false;
                }
            }
        }
        public string sunsign
        {
            get
            {
                string month = this.DateofBirth.ToString("MMMM");
                int day = Convert.ToInt32(this.DateofBirth.ToString("dd"));

                if(month == "March")
                {
                    if (day >= 21)
                    {
                        return "Aries";
                    }
                    else
                        return "Pisces";
                }
                else if(month == "April")
                {
                    if (day >= 20)
                    {
                        return "Taurus";
                    }
                    else
                        return "Aries";
                }
                else if (month == "May")
                {
                    if (day >= 21)
                        return "Gemini";
                    else
                        return "Taurus";
                }
                else if (month == "June")
                {
                    if (day >= 22)
                        return "Cancer";
                    else
                        return "Gemini";
                }
                else if (month == "July")
                {
                    if (day >= 23)
                        return "Leo";
                    else
                        return "Cancer";
                }
                else if (month == "August")
                {
                    if (day >= 23)
                        return "Virgo";
                    else
                        return "Leo";
                }
                else if (month == "September")
                {
                    if (day >= 23)
                        return "Libra";
                    else
                        return "Virgo";
                }
                else if (month == "October")
                {
                    if (day >= 24)
                        return "Scorpio";
                    else
                        return "Libra";
                }
                else if (month == "November")
                {
                    if (day >= 23)
                        return "Sagittarius";
                    else
                        return "Scorpio";
                }
                else if (month == "December")
                {
                    if (day >= 22)
                        return "Capricorn";
                    else
                        return "Sagittarius";
                }
                else if (month == "January")
                {
                    if (day >= 20)
                        return "Aquarius";
                    else
                        return "Capricorn";
                }
                else if (month == "February")
                {
                    if (day >= 19)
                        return "Pisces";
                    else
                        return "Aquarius";
                }
                return "";

            }
        }
        public bool isbirthday
        {
            get
            {
                if (DateTime.Now.Month == this.DateofBirth.Month)
                {
                    if (DateTime.Now.Day == this.DateofBirth.Day)
                        return true;
                    else
                        return false;
                }
                else
                    return false;
            }
        }
        public string screenname
        {
            get
            {
                char[] ch = this.FirstName.ToCharArray();
                ch[5] = Convert.ToChar(this.DateofBirth.Day);
                Console.WriteLine(this.DateofBirth.Day);
               // ch[6] = Convert.ToChar(this.DateofBirth.Month);
                string s = new string(ch);
                return s;
            }
        }
    }
}
