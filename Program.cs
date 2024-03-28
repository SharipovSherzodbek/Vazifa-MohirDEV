using System;

   class Program
   {
       static void Main(string[] args)
       {
        Console.WriteLine("Welcome to Task 1 from OOP! \n Here is our libruary");
        
        Console.WriteLine("You can take an informatin about the books by chosing apropriate number:");
        Console.WriteLine("1)\"Ikki Eshik Orasi\"\t 2)\"O`tgan Kunlar\"\t 3)\"1984\" ");
        int bookNumber = int.Parse(Console.ReadLine());        
    
        string bookName = Book.ChooseBook(bookNumber);

        Book book = new Book(bookName);

        book.PrintBook(bookNumber);

        book.PrintPageNumber(bookNumber);
       }
   }