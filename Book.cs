
class Book
   {
       private int BookPage { get; set; }
       private string BookName { get; set; }

       public Book(string bookName)
       {
           this.BookName = bookName; 
           System.Console.WriteLine("Your choise: " + BookName);
       }     

       static public string ChooseBook(int bookNumber)
       {
        string chosenBook = bookNumber switch
           {
               1 => "Ikki Eshik Orasi",
               2 => "O`tgan Kunlar",
               3 => "1984",
               _ => "Input Eror \t Please enter 1,2 or 3 ..."
           };
           return chosenBook;
       }

        public void PrintBook (int bookNumber)
        {
            if(bookNumber < 2)
            {    
                PrintBook1();   
            }
            else if(bookNumber == 2)
            {   
                 PrintBook2();  
            }
            else
            {   
                 PrintBook3();  
            }        
        }

        public void PrintPageNumber(int bookNumber)
        {
            int bookPage = BookPages(bookNumber);
            Console.WriteLine($"Page of {BookName} is {bookPage} ");
        }
      
         private int BookPages(int bookNumber)
       {
        if(bookNumber < 2)
            {
              BookPage  = 524;
            }
            else if(bookNumber == 2)
            {
                BookPage  = 456;
            }
            else
            {
               BookPage  = 276;
            }        
        return BookPage  ; 
       }  

        private void PrintBook1()
        {
            Console.WriteLine($"Author of {BookName} is \"O`tkir Hoshimov\"");
            Console.WriteLine("Published in 1986 y.");
            Console.WriteLine("You can buy it for 15$");
        }
         private void PrintBook2()
        {
            Console.WriteLine($"Author of {BookName} is \"Abdulla Qodiriy\"");
            Console.WriteLine("Published in 1925 y.");
            Console.WriteLine("You can buy it for 12$");
        }

         private void PrintBook3()
        {
            Console.WriteLine($"Author of {BookName} is \"Geaorge Orwell\"");
            Console.WriteLine("Published in 1949 y.");
            Console.WriteLine("You can buy it for 8$");
        }   
}  





