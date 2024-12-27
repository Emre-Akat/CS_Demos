using System.Numerics;

namespace Yalnızca_Pozitif_Sayılarla_İşlem_Yapma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kullanıcıdan dizinin boyutunu alma
            Console.WriteLine("Dizinin boyutunu giriniz :");
            int diziBoyut=int.Parse(Console.ReadLine());
            //dizinin tanımlanması
            int[] dizi=new int[diziBoyut];
            //kullanıcıdan dizi elemanlarının alınması
            for(int i=0;i<dizi.Length;i++)
            {
                Console.WriteLine("Dizinin elemanlarını giriniz :");
                dizi[i]=int.Parse(Console.ReadLine());
            }
            //pozitif olan sayıların yazdırılması ve ortalamasının hesaplanması ve en büyük sayının tespit edilmesi.
            int sayac = 0; // pozitif olan sayıların  adetini bulmak için sayaç
            int pozitiftoplam = 0;
            int enBuyuk = -272222222;
            bool pozitifVarMi=false;
            foreach (int s in dizi)
            {
                if(s>0)
                {
                    Console.WriteLine(s);
                    pozitiftoplam += s;
                    sayac++;
                    pozitifVarMi = true;

                    if (enBuyuk < s)
                    {
                        enBuyuk = s;
                    }
                }
              
            }
            double ortalama =(double) pozitiftoplam / sayac;
            //pozitif sayının varlığının kontrol edilmesi
            if (pozitifVarMi == false)
            {
                Console.WriteLine("Pozitif sayı bulunmamaktadır.");
            }
            else
            {
                Console.WriteLine("Pozitif sayıların toplamı :" + pozitiftoplam + "\nPozitif sayıların ortalaması:" + ortalama + "\nEn büyük pozitif sayı:" + enBuyuk);
            }
            



            
            
        }
    }
}
