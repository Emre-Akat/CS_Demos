
# BookStore Uygulaması / BookStore Application

## Açıklama / Description

Bu program, kitapları saklamak, listelemek ve indirimli fiyatlarını hesaplamak için kullanılan bir **BookStore** (Kitapçı) uygulamasıdır. Kullanıcı, kitap bilgilerini girebilir, bu kitapları bir listeye ekleyebilir ve her kitap için indirimli fiyatları görebilir. Program, kullanıcıya kitap hakkında başlık, yazar, fiyat ve yayımlanma yılı gibi bilgiler sunar.

This program is a **BookStore** application that is used to store, list, and calculate discounted prices of books. The user can input book details, add books to a list, and see the discounted prices for each book. The program provides the user with information about the book such as title, author, price, and publication year.

## Özellikler / Features

- **Kitap Eklemek / Add Books**: Kullanıcı, kitapları `BookStore`'a ekler.
- **Kitap Listeleme / List Books**: Kullanıcı eklediği kitapları listeleyebilir.
- **İndirimli Fiyat / Discounted Price**: Her kitap için %20 indirimli fiyat hesaplanabilir.
- **Kitap Bilgileri / Book Information**: Başlık, yazar, fiyat ve yayımlanma yılı bilgileri görüntülenir.

- **Add Books**: The user can add books to the `BookStore`.
- **List Books**: The user can list the books they added.
- **Discounted Price**: The program calculates a 20% discounted price for each book.
- **Book Information**: The title, author, price, and publication year are displayed.

## Kullanım / Usage

### Adım 1: Kitap Oluşturma / Step 1: Create a Book
Öncelikle, kitap bilgilerini girerek bir **Book** (Kitap) nesnesi oluşturun.
First, create a **Book** object by entering the book details.

```csharp
Book myBook = new Book("World We Know", "Admin", 250, 2025);
Console.WriteLine(myBook.GetBookInfo()); // Kitap bilgilerini gösterir / Displays book info
Console.WriteLine("İndirimli fiyatı: " + myBook.Discount()); // İndirimli fiyatı gösterir / Shows discounted price


