namespace BookManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("book1", "emre", 100,"1234567891234");
            book.BorrowBook();
            book.ReturnBook();
            book.DisplayInfo();
            Console.WriteLine(Book.TotalBooks);
        }
    }
}
