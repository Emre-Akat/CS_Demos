using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banka_hesabı
{
    internal class BankAccount
    {
        public string AccountHolderName;
        private double Balance;
        public string AccountNumber;
        public double Deposit(double eklenecekMiktar)
        {
            Balance += eklenecekMiktar;
            return Balance;
        }
        public void Withdraw(double cekilecekMiktar)
        {
            if(cekilecekMiktar>Balance)
            {
                Console.WriteLine($"Hesabınızda bulunan bakiye :{Balance} yeterli bakiyeye sahip değilsiniz!");
            }
            else
            {
                Balance -= cekilecekMiktar;
                Console.WriteLine($"Hesabınızdan {cekilecekMiktar} çekilmiştir kalan bakiye {Balance}");
            }
        }

        public double GetBalance()
        {
            return Balance;

        }

        public BankAccount(string accountHolderName,double balance,string acccountNumber)
        {
            AccountHolderName = accountHolderName;
            Balance = balance;
            AccountNumber = acccountNumber;
            Console.WriteLine("Hesabınız başarı ile oluşturuldu");
        }

    }
}
