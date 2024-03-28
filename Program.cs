using System;

   class Program
   {
       static void Main(string[] args)
       {
        Console.WriteLine("Welcome to Task 1 from OOP! \n Here is our libruary");
        Console.WriteLine("You can take an informatin about a book by chosing apropriate numbers(1, 2, 3)");
        int numberOfBook = int.Parse(Console.ReadLine());        
    
        string bookName = Book.ChooseBook(numberOfBook);

        Book book = new Book(bookName);

        book.PrintBook(numberOfBook);

        book.PrintPageNumber(numberOfBook);

       }
   }