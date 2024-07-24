using System.Security.Cryptography.X509Certificates;

namespace Test2
{
    internal class Program
    {
        public class Book
        {
            public int BookId { get; set; }
            public string BName { get; set; }
            public double Price { get; set; }
            public string Author { get; set; }
            public string Publisher { get; set; }

            public override string ToString()
            {
                return $"Book Id: {BookId} Book Name: {BName} Price: {Price} Author: {Author} Publisher: {Publisher}";
            }
        }

         public interface IBookDetails
        {
            void AddBook();
            void DisplayBook();
            void updateBook(int bookId, double bookPrice);
            void DisplayId(int bookId);
            void DisplayName(string name);
            void DisplayAuthor(string author);
            void DisplayAutPub(string author,string Publisher);

        }
        public class BookDel : IBookDetails
        {
            List<Book> book = new List<Book>();
            public void AddBook()
            {
                try
                {

                    Book b = new Book();
                    Console.Write("Enter Book Id: ");
                    b.BookId = int.Parse(Console.ReadLine());
                    for(int i = 0; i < book.Count; i++)
                    {
                        if (book[i].BookId == b.BookId)
                        {
                            Console.WriteLine("Book Id already Exist");
                            break;
                        }
                    }
                    Console.Write("Enter Book Name: ");
                    b.BName = Console.ReadLine();
                    Console.Write("Enter Price of the book: ");
                    b.Price = double.Parse(Console.ReadLine());
                    Console.Write("Enter Author Name: ");
                    b.Author = Console.ReadLine();
                    Console.Write("Enter Publisher: ");
                    b.Publisher = Console.ReadLine();
                    book.Add(b);
                }catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            public void DisplayBook()
            {
                foreach (Book b in book)
                {
                    Console.WriteLine(b);
                }
            }
            public void updateBook(int bookId, double bookPrice)
            {
                try
                {
                    for (int i = 0; i < book.Count; i++)
                    {
                        if (book[i].BookId == bookId)
                        {
                            book[i].Price = bookPrice;
                            break;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            public void DisplayId(int id)
            {
                for (int i = 0; i < book.Count; i++)
                {
                    if (book[i].BookId == id)
                    {
                        Console.WriteLine(book[i]);
                        break;
                    }
                }
                    
                        Console.WriteLine("Book id not found");
                    
                
            }
            List<Book> BookAuthor = new List<Book>();

            public void DisplayAuthor(string author)
            {
                for(int i=0;i<book.Count;i++)
                {
                    if(book[i].Author.ToLower() == author)
                    {
                        BookAuthor.Add(book[i]);
                    }
                }
                foreach (Book b in BookAuthor)
                {
                    Console.WriteLine(b);
                }
            }

            public void DisplayName(string name)
            {
                for (int i = 0; i < book.Count; i++)
                {
                    if (book[i].BName.ToLower() == name)
                    {
                        Console.WriteLine(book[i]);
                    }
                }
                        Console.WriteLine("Book Name Does not exist");
                   
            }
            List<Book> BookAutPub = new List<Book>();
            public void DisplayAutPub(string author, string Publisher)
            {
                var name = from i in book
                           where i.Author.ToLower() == author && i.Publisher.ToLower() == Publisher
                           select i;
                foreach (Book b in name)
                {
                    BookAutPub.Add(b);
                }
                foreach(Book b in BookAutPub)
                {
                    Console.WriteLine(b);
                }
                
            }


            static void Main(string[] args)
            {
                IBookDetails bookDetails = new BookDel();
                try
                {
                    do
                    {
                        Console.Write("Choose option: \n");
                        Console.WriteLine("1.Add book\n2.update book price details\n3.Display book details based on Book Id\n4.Display books based on book name\n5.Display books based on Author\n6.Display books based on Author and Publisher\n7.Display all book details");
                        int option = int.Parse(Console.ReadLine());
                        BookDel bookDel = (BookDel)bookDetails;
                        switch (option)
                        {
                            case 1:
                                {
                                    bookDel.AddBook();
                                }
                                break;
                            case 2:
                                {
                                    Console.Write("Enter Book Id to be updated: ");
                                    int id = int.Parse(Console.ReadLine());
                                    Console.Write("Enter updated Book Price: ");
                                    double price = double.Parse(Console.ReadLine());
                                    bookDel.updateBook(id, price);
                                }
                                break;
                            case 3:
                                {
                                    Console.Write("Enter Book id to be displayed: ");
                                    int id = int.Parse(Console.ReadLine());
                                    bookDel.DisplayId(id);
                                }
                                break;
                            case 4:
                                {
                                    Console.Write("Enter Book Name to be Displayed: ");
                                    string a = Console.ReadLine().ToLower();
                                    bookDel.DisplayName(a);
                                }
                                break;
                            case 5:
                                {
                                    Console.Write("Enter Author Name: ");
                                    string a = Console.ReadLine().ToLower();
                                    bookDel.DisplayAuthor(a);

                                }
                                break;
                            case 6:
                                {
                                    Console.WriteLine("Enter Author name: ");
                                    string name = Console.ReadLine().ToLower();
                                    Console.WriteLine("Enter Publiser name: ");
                                    string pub = Console.ReadLine().ToLower();
                                    bookDel.DisplayAutPub(name, pub);
                                }
                                break;
                            case 7:
                                {
                                    bookDel.DisplayBook();
                                }
                                break;
                            default:
                                {
                                    Console.Write("Enter Correct option");
                                }
                                break;
                        }
                        Console.WriteLine();
                    } while (true);
                }catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        
    }
    
}
