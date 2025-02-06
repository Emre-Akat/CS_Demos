using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kitapbilgi
{
    internal class Book
    {
        public string Title;
        public string Author;
        public double Price;
        public int PublicationYear;
        public Book(string title,string author,double price,int publicationYear)
        {
            Title = title;
            Author = author;
            Price = price;
            PublicationYear = publicationYear;
        }
        public string GetBookInfo()//Kitabın başlığını, yazarını, fiyatını ve yayın yılını döndüren bir metot.
        {
            return $"Başlık: {Title}, Yazar: {Author}, Ücret: {Price} TL, Yayımlanma yılı: {PublicationYear}";
        }
        public double Discount()//itabın fiyatına belirli bir indirim uygulayan bir metot (yüzde olarak) ve indirimli fiyatı döndüren bir metot.
        {
            double  indirimMiktarı = Price *0.2;
                return Price - indirimMiktarı;     
        }

    }
}
