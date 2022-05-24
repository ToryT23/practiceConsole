using System;
using System.Collections.Generic;

// Make a new console application.
// You can remove all the code in Program.cs except using System;

// At the bottom of the Program file, define a Book type with some properties you might 
// expect a book to have (Author, title, publishdate, number of pages, whatever you like...). 
// You can use the example at the bottom of chapter 9 as a guide.

// at the top of the file (after using System;), create three instances of your Book class using 
// the new keyword. You can use the object initialize (the {}) to add values for each of those 
// instances (for example {Title = "20,000 Leagues Under the Sea"}
// Create an empty List of Books.
// Use the Add method to add your three instances to the list.
// Iterate over the list and print "<Title> - by <Author>" or something like that for each iteration


// create an empty list of book
List<Book> AllBooks = new List<Book>();

// type/class is called Book / object is called books
Book books = new Book
{
    Author = "Unknown Author",
    Title= "Just a book",
    PublishDate = 10/24/21,
    NumberOfPages = 130,
};
Book books2 = new Book
{
    Author = "Simple Ton",
    Title= "Joking is fun",
    PublishDate = 10/22/21,
    NumberOfPages = 150,
};
Book books3 = new Book
{
    Author = "love Author",
    Title= "Just a love book",
    PublishDate = 2/14/22,
    NumberOfPages = 48,
};
AllBooks.Add(books);
AllBooks.Add(books2);
AllBooks.Add(books3);

    foreach( Book book in AllBooks ){
System.Console.WriteLine($"{book.Title} was written by {book.Author}.");
    }


// create class first
public class Book
{
    
    public string Author{ get; set; }
    public string Title { get; set; }
    public int PublishDate{ get; set; }
    public int NumberOfPages { get; set; }
}