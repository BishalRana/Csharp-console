using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            BookOperations();
        }

        static void BookOperations()
        {
            List<string> booksToRead = new List<string>() { "Cindrella", "Hello",
                "Ghost Rider", "Half Girlfriend" };
            Console.WriteLine("Here is your book collection.\nTo add a book" +
                "press A and To quit press X");
            string optionsType = GetOpitonType();
            string bookName;

            while (optionsType != "x")
            {
                Console.WriteLine("");
                Console.WriteLine("Enter the book you want to add.");
                bookName = Console.ReadLine();
                booksToRead.Add(bookName);

                Console.WriteLine("\n");
                Console.WriteLine("Would you like to add book or quit?\n" +
                    "To add press A , To quit press X");
                optionsType = Console.ReadLine().ToLower();
            }

            Console.WriteLine("\n");
            Console.WriteLine("Collection of book titles.");

            DisplayBookList(booksToRead);

            Console.WriteLine("\n");
            Console.WriteLine("Entering into the multiple options.");
            Console.WriteLine(SecondOptionInstructions());
            optionsType = GetOpitonType();

            while (optionsType != "x")
            {

                switch (optionsType)
                {
                    case "a":
                        bookName = GetUserInput();
                        booksToRead.Add(bookName);
                        break;
                    case "d":
                        bookName = GetUserInput();
                        deleteBook(booksToRead, bookName);
                        break;
                    case "l":
                        DisplayBookList(booksToRead);
                        break;
                    case "s":
                        sortTheBookList(booksToRead);
                        break;
                    case "f":
                        bookName = GetUserInput();
                        SearchTheBookInTheList(booksToRead, bookName);
                        break;
                    default:
                        break;
                }
                Console.WriteLine("");
                Console.WriteLine(SecondOptionInstructions());
                optionsType = Console.ReadLine().ToLower();
            }
        }

        static void DisplayBookList(List<string> booksToRead)
        {
            Console.WriteLine("");
            Console.WriteLine("**************Book List***********************");
            //alternative would be using booksToRead.ForEach(Console.WriteLine);
            foreach (string book in booksToRead)
            {
                Console.WriteLine(book);
            }
            Console.WriteLine("**********************************************");
        }

        static void sortTheBookList(List<string> booksToRead)
        {
            Console.WriteLine("");
            Console.WriteLine("************Sorted****************************");
            booksToRead.Sort();
            DisplayBookList(booksToRead);
            Console.WriteLine("**********************************************");
        }

        static string GetOpitonType()
        {
           string optionsType = Console.ReadLine().ToLower();
           return optionsType;
        }
        static string GetUserInput()
        {
            Console.WriteLine("\nEnter the book");
            String bookName = Console.ReadLine();
            return bookName;
        }

        static string SecondOptionInstructions()
        {
            return "Would you like to add,delete,list or sort the books.\n" +
                "To add press A \n" +
                "To delete press D \n" +
                "To list press L \n" +
                "To sort press S\n"+
                "To quit press x\n"+
                "To search press F";
        }

        static void SearchTheBookInTheList(List<string> booksToRead,string bookToSearch)
        {
            Console.WriteLine("********************Search***********************************");
            
            //case insensitive search with LINQ, alternative would be using for loop to search
            //the book by comparing in list of books and converting comparison to case insensitive
            if (booksToRead.Any(s => s.Equals(bookToSearch, StringComparison.OrdinalIgnoreCase)))
            {
                Console.WriteLine("The book "+bookToSearch+" is in the list");
            }
            else
            {
                Console.WriteLine("The book " + bookToSearch + " is not in the list");
            }
            Console.WriteLine("*************************************************************");
        }

        static void deleteBook(List<String> bookList , string bookToDelete)
        {
            if (bookList.Contains(bookToDelete))
            {
                bookList.Remove(bookToDelete);
            }
            else
            {
                Console.WriteLine("/***********************Delete**********************************/");
                Console.WriteLine("Book "+bookToDelete+" not found in the list");
                Console.WriteLine("/**************************************************************/");
            }
        }
    }
}
