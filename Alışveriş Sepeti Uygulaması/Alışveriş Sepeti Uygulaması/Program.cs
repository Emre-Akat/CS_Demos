namespace Alışveriş_Sepeti_Uygulaması
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan eklenecek ürün sayısını alıyoruz (1 ile 10 arasında olmalı).
            Console.WriteLine("Kaç ürün ekleyeceksiniz (1-10) :");
            int urunAdet = int.Parse(Console.ReadLine());
            // Ürün adları ve fiyatlarını saklamak için diziler oluşturuyoruz.
            string[] urunAd = new string[urunAdet];
            int[] urunFiyat = new int[urunAdet];

            // Kullanıcıdan ürün bilgilerini alıyoruz.
            for (int i = 0; i < urunAdet; i++)
            {
                Console.WriteLine("Ürünün adını giriniz:");
                urunAd[i] = Console.ReadLine();
                Console.WriteLine("Bu ürünün fiyatını giriniz:");
                urunFiyat[i] = int.Parse(Console.ReadLine());
            }
            // Sepeti listeleme fonksiyonunu çağırıyoruz.
            SepetListele(urunFiyat,urunAd);
            // Sepetteki ürünlerin toplam fiyatını hesaplayıp ekrana yazdırıyoruz.
            Console.WriteLine("Toplam fiyat:"+ToplamFiyat(urunFiyat));
            // Sepetteki en pahalı ürünü bulup ekrana yazdırıyoruz.
            EnPahaliUrun(urunFiyat);
            // Toplam fiyata %10 indirim uygulayıp ekrana yazdırıyoruz.
            Console.WriteLine("İndirim uygulanmış hali :"+IndırımUygula(urunFiyat));
        }

        // Sepetteki ürünleri adları ve fiyatlarıyla listeleyen metot
        public static void SepetListele(int[] urunFiyat,string[] urunAd)
        {
            for (int i = 0; i < urunFiyat.Length; i++)
            {
                Console.WriteLine($"Ürünün adı {urunAd[i]} ve ürünün fiyatı {urunFiyat[i]}");
            }
        }
        // Sepetteki ürünlerin toplam fiyatını hesaplayan metot
        public static double ToplamFiyat(int[] urunFiyat)
        {
            int toplam = 0;
            foreach (int i in urunFiyat)
            {
                // Her bir ürünün fiyatını toplama ekliyoruz.
                toplam += i;
            }
            return toplam;// Toplam fiyatı döndürüyoruz.

        }
        // Sepetteki en pahalı ürünü bulan ve ekrana yazdıran metot
        public static void EnPahaliUrun(int[] urunFiyat)
        {
            int enPahali = urunFiyat[0];// İlk ürünü başlangıç için en pahalı olarak alıyoruz.
            for (int i=0;i<urunFiyat.Length;i++)
            {
                if (enPahali < urunFiyat[i])
                {
                    // Eğer mevcut fiyat daha pahalıysa, onu en pahalı yapıyoruz.
                    enPahali = urunFiyat[i];
                }
            }// En pahalı ürünü ekrana yazdırıyoruz.
            Console.WriteLine("En pahalı ürün :"+enPahali);
        }
        // Sepetteki toplam fiyata %10 indirim uygulayan metot
        public static double IndırımUygula(int[] urunFiyat)
        {
            // Toplam fiyat üzerinden %10 indirim hesaplıyoruz.
            double yuzdeOn = ToplamFiyat(urunFiyat) - (ToplamFiyat(urunFiyat) * 0.1);
            return yuzdeOn; // İndirimli fiyatı döndürüyoruz.
        }

    }
}
