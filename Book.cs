
class Book
   {
       private int BookPage { get; set; }
       private string BookName { get; set; }

       public Book(string nameOfBook)
       {
           BookName = nameOfBook; 
           System.Console.WriteLine("Your choise: " + BookName);
       }     

       static public string ChooseBook(int numberOfBook)
       {
    string chosenBook = numberOfBook switch
           {
               1 => "Ikki Eshik Orasi",
               2 => "O`tgan Kunlar",
               3 => "1984",
               _ => "Input Eror \t Please enter 1,2 or 3 ..."
           };
           return chosenBook;
       }

        public void PrintBook (int numberOfBook )

        {
            if(numberOfBook > 2)
            {
              Print1984();
            }
            else if(numberOfBook == 2)
            {
                PrintOtganKunlar ();
            }
            else
            {
                PrintIkkiEshikOrasi ();
            }        
        }

        public void PrintPageNumber(int numberOfBook)
        {
            int BOOK_PAGE =BookPages(numberOfBook);
            Console.WriteLine($"Page of {BookName} is {BOOK_PAGE} ");
        }
      
         private int BookPages(int numberOfBook)
       {
        if(numberOfBook > 2)
            {
              BookPage = 276;
            }
            else if(numberOfBook == 2)
            {
                BookPage = 456;
            }
            else
            {
               BookPage = 524;
            }        
        return BookPage ; 
       }      
         private void PrintOtganKunlar ()
        {
            Console.WriteLine($"Author of {BookName} is \"Abdulla Qodiriy\"");
            Console.WriteLine("Published in 1925 y.");
            Console.WriteLine("You can buy it for 12$");
        }
         private void Print1984 ()
        {
            Console.WriteLine($"Author of {BookName} is \"Geaorge Orwell\"");
            Console.WriteLine("Published in 1949 y.");
            Console.WriteLine("You can buy it for 8$");
        }
        private void PrintIkkiEshikOrasi ()
        {
            Console.WriteLine($"Author of {BookName} is \"O`tkir Hoshimov\"");
            Console.WriteLine("Published in 1986 y.");
            Console.WriteLine("You can buy it for 15$");
        }
}  



