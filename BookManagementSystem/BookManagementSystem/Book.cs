using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagementSystem
{
    internal class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int PageCount { get; set; }
        public bool IsBorrowed = false; //öndünç alınmış mı
        public string ISBN { get; } //readonly international standart book number
        public static int TotalBooks=0;



        public Book(string title, string author, int pageCount, string ıSBN)
        {
            Title = title;
            Author = author;
            PageCount = pageCount;
            ISBN = ıSBN;
            IsBorrowed=false;
            TotalBooks++;
        }
        // Kitap ödünç alınırsa çalışır
        public void BorrowBook()
        {
            if (IsBorrowed == true)
            {
                Console.WriteLine("Kitap öndünç alınmış!");
            }
            else
            {
                Console.WriteLine("Kitap şuan rafta ,ödünç verilebilir");
                IsBorrowed = true;
            }
        }
        // Kitap iade edilirse çalışır
        public void ReturnBook()
        {
            if(IsBorrowed)
            {
                Console.WriteLine("Kitap geri verildi");
                IsBorrowed= false;
            }
            else
            {
                Console.WriteLine("Kitap alınmamış, rafta!");
            }
        }
        // Kitap bilgilerini ekrana yazdırır
        public void DisplayInfo()
        {
            Console.WriteLine($"Kitabın adı :{Title} kitabın yazarı :{Author}  sayfa sayısı:{PageCount}  isbn :{ISBN} kitap ödünç alındı mı {IsBorrowed} ");
        }
    }
}
