namespace Basit_not_ortalamsı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //öğrencinin notlarının tutulacağı bir dizi tanımladık
            double[] notlar=new double[5];
            //dizimize eleman girdisi aldık.
            for (int i = 0; i < notlar.Length; i++)
            {
                Console.WriteLine("Notu giriniz :");
                notlar[i]=Convert.ToDouble(Console.ReadLine());
            }

            GectiMiKontrol(notlar);

            Console.ReadKey();
        }
        //ortalama hesaplayacak metotdumuz
        public static double OrtalamaHesaplayici(double[] notlar)
        {
            double top = 0;
            foreach (double d in notlar)
            {
                top += d;
            }
            //ortalama değeri döndürüyoruz.
            return top / notlar.Length;
        }
        // öğrencinin not ortalamasına göre geçti ,kaldı yazdıran metot
        public static void GectiMiKontrol(double[] notlar)
        { 
              if(OrtalamaHesaplayici(notlar)>=50)
            {
                Console.WriteLine("Geçti");
            }
              else
            {
                Console.WriteLine("Kaldı");
            }
        }
    }
}
