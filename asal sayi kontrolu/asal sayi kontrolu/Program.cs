namespace asal_sayi_kontrolu
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Bir sayı giriniz :");
            int kullaniciSayi=int.Parse(Console.ReadLine());
            AsalKontrol(kullaniciSayi);

        }
        public static void AsalKontrol(int kullaniciSayi)
        {
            if (kullaniciSayi<=1)
            {
                Console.WriteLine($"Girdiğiniz sayı {kullaniciSayi} asal değildir.");
            }
            bool asalMi=true;
            for (int i = 2; i < kullaniciSayi/2; i++)
            {
                if (kullaniciSayi%i==0)
                {
                        asalMi = false;
                    break;
                }
            }
            if (asalMi)
            {
                Console.WriteLine($"Girdiğiniz sayi {kullaniciSayi} asaldır.");
            }
            else
            {
                Console.WriteLine($"Girdiğiniz sayi {kullaniciSayi} asal değildir.");
            }
        }
    }
}
