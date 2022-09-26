using System;

namespace BookAuthorManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            Book[] B = new Book[10];
            Author[] B1 = new Author[10];
            while (true)
            {
                Console.WriteLine("1.  Add Book.\n2.  Search Book.\n3.  Update Book.\n4.  View All Books.\n5.  View All Authors\n6. Exit\n\nPlease Enter Your Choice :: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        if (i != 10)
                        {
                            B[i] = new Book();
                            Console.WriteLine("Enter Book details \n1.ISBN\n2.BookName\n3.Year\n4.Price\n");
                            B[i].AddBook(Console.ReadLine(), Console.ReadLine(), Convert.ToInt32(Console.ReadLine()), Convert.ToDecimal(Console.ReadLine()));
                            Console.WriteLine("Enter Author details \n1.AuthorName\n2.Email\n3.Gender\n");
                            B1[i] = new Author();
                            B1[i].AddAuthor(Console.ReadLine(), Console.ReadLine(), Convert.ToChar(Console.ReadLine()));
                            i = i + 1;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Rack is filled\n");
                            break;
                        }
                    case 2:
                        string sb = Console.ReadLine();
                        Console.WriteLine(SearchBook(sb)+"\n");
                        break;
                        

                    case 3:

                        Console.WriteLine("Enter the ISBN");
                        
                        break;

                    case 4:

                        for(int j=0;j<i;j++)
                        {
                            Console.WriteLine("{0}.  ISBN {1}",j+1,B[j].isbn);
                            Console.WriteLine("    BookName {0}", B[j].bookname);
                            Console.WriteLine("    Year {0}", B[j].year);
                            Console.WriteLine("    Price {0}\n", B[j].price);
                        }
                        break;

                    case 5:

                        for (int j = 0; j < i; j++)
                        {
                            Console.WriteLine("{0}.  AuthorName {1}", j+1,B1[j].name);
                            Console.WriteLine("    Email {0}", B1[j].email);
                            Console.WriteLine("    Gender {0}\n", B1[j].gender);
                        }
                        break;

                    case 6:
                        return;
                    default:
                        Console.WriteLine("No match found\n");
                        break;
                }
            }
            string SearchBook(string sb1)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (B[j].isbn.Equals(sb1))
                    {
                        return "True";
                    }
                }
                return "False";
            }

        }
    }
}
