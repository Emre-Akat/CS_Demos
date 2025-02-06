namespace kitapbilgi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book myBook = new Book("World We Know", "Admin", 250, 2025);
            Console.WriteLine(myBook.GetBookInfo());//Kİtap hakkındaki bilgiler veren metot
            Console.WriteLine("İndirimli fiyatı:"+ myBook.Discount());//Yüzde yirmi indirim yapan metot
            BookStore myStore = new BookStore();
            myStore.AddBook(new Book("kitap 1", "admin1", 100, 2023));
            myStore.AddBook(new Book("kitap 2", "admin2", 200, 2022)); //kitaplarımız ekledik
            myStore.AddBook(new Book("kitap 3", "admin3", 300, 2021));

            //kitap listeleme
            myStore.ListBooks();

        }
    }
}
