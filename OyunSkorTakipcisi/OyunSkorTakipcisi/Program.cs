using System.Runtime.InteropServices;
using System.Xml.Serialization;

namespace OyunSkorTakipcisi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SkorDurumu skor=new SkorDurumu();
            skor.SkorYap += SkorDegisimi; ;
            skor.SkorYap += LevelUp;
            skor.SkorYap += Log;
            skor.SkorKazandı("Emre",60);
            skor.SkorKazandı("Emre", 40);

        }
    
    public static void SkorDegisimi(object sender, OyuncuBilgisi e)
        {
            Console.WriteLine($"{e.OyuncuAdi} skor yaptı yeni skor :{e.OyuncuPuanı}");
        } 
        public static void LevelUp(object sender, OyuncuBilgisi e)
        {
           if(e.OyuncuPuanı>=100)
            {
                Console.WriteLine("Level Atladınız!");
            }
        }
        public static void Log(object sender, OyuncuBilgisi e)
        {
            Console.WriteLine($"[Log] {e.OyuncuAdi} adlı oyuncu skor yaptı :{e.OyuncuPuanı}");
        }
    }
    public class OyuncuBilgisi:EventArgs
    {
        public string OyuncuAdi { get;}
        public int OyuncuPuanı { get;}
        public OyuncuBilgisi(string oyuncuADi,int oyuncuPuanı)
        {
            OyuncuAdi = oyuncuADi;
            OyuncuPuanı = oyuncuPuanı;
        }
    }
    public class SkorDurumu
    {
        public event EventHandler<OyuncuBilgisi> SkorYap;
        private  int toplamPuan=0;

        public  int ToplamPuan { get => toplamPuan; set=>toplamPuan=value; }

        public void SkorKazandı(string ad,int puan)
        {
            ToplamPuan += puan;
            OyuncuBilgisi oyuncu=new OyuncuBilgisi(ad,ToplamPuan);
            Console.WriteLine($"Oyuncu {ad} puan:{ToplamPuan} kazandı");
            SkorYap?.Invoke(this,oyuncu);
        }
    }
}
