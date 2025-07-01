namespace CayDemlendiMi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CayMakinesi cay=new CayMakinesi();
            cay.CayHazir += MesajGonder;
            cay.CayHazir += SesEfektiCay;
            cay.CayHazir += Log;
            cay.Demle(1,"siyah çay"); 
        }
      public static void MesajGonder(object sender,CayBilgisi e)
        {
            Console.WriteLine("Çay hazır afiyet olsun!");
        }
     public static  void SesEfektiCay(object sender,CayBilgisi e)
        {
            Console.WriteLine("Ding Dong");
        }
   public static void Log(object sender, CayBilgisi e)
        {
            Console.WriteLine("[Log] Çay demlendi");
        }
        public class CayBilgisi:EventArgs
        {
            public int DemlenmeSuresi { get; set; }
            public string CayAdi { get; set; }

            public CayBilgisi(int demlenmeSuresi,string cayAdi)
            {
                DemlenmeSuresi = demlenmeSuresi;
                CayAdi = cayAdi;
            }
        }
        public class CayMakinesi
        {
            public event EventHandler<CayBilgisi> CayHazir;

            public void Demle(int demlenmeSuresi,string cayAdi)
            {
                CayBilgisi bilgi = new CayBilgisi(demlenmeSuresi, cayAdi);
                Console.WriteLine("Çay demleniyor!");
                CayHazir?.Invoke(this, bilgi);
            }

        }
    }
}
