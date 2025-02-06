using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;//List kullanımı için namespace

namespace kitapbilgi
{
    internal class BookStore
    {
        //Kştaplarımızı tutan list
        public List<Book> Books { get; set; }


        public BookStore()
        {
            Books = new List<Book>(); //Boş liste başlatıyoruz
        }
        public void AddBook(Book book)
        {
            Books.Add(book);//kitabı listeye ekiliyoruz
        }

        public void ListBooks()
        {
            foreach (Book book in Books)
            {
                Console.WriteLine(book.GetBookInfo());//kitap bilgilerini yazdırıyoruz
            }
        }
    }
}
