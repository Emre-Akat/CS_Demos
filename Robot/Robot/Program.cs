namespace Robot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Robot myrobot = new Robot("X-AE-32",50);
            Console.WriteLine("Mevcut şarjınız :"+myrobot.Charge()+ " oldu");
            myrobot.Work();
        }
    }
}
