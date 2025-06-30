using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_OOP_Concepts_With_CSharp
{
  public  class Cat : IAnimal
    {
        public void Eat()
        {
            Console.WriteLine("Kedi yemek yiyor");
        }

        public void MakeSound()
        {
            Console.WriteLine("Kedi miyavlıyor");
        }
    }
    public class Dog : IAnimal
    {
        public void Eat()
        {
            Console.WriteLine("Köpek yemek yiyor");
        }

        public void MakeSound()
        {
            Console.WriteLine("Köpek havlıyor");
        }
    }
}
