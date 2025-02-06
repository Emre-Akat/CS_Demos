namespace banka_hesabı
{
    internal class Program
    {
        static void Main(string[] args)
        {

            BankAccount myAccount = new BankAccount("Admin", 1000, "1111111110");
            Console.WriteLine("yeni bakiye :"+myAccount.Deposit(1000));//hesaba para ekleme
            myAccount.Withdraw(500);//hesaptan para çekme
            Console.WriteLine("Bakiyeniz :"+myAccount.GetBalance());//Bakiye öğrenme


        }
    }
}
