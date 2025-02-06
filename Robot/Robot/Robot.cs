using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Robot
{
    internal class Robot
    {
        private readonly string Model = ""; 
        public int BatteryLevel;




        public int Charge()
        {
            return BatteryLevel = 100;
        }//şarjı dolduruyoruz
        public void Work()
        {
            if (BatteryLevel - 10 >= 0)
            {
                BatteryLevel -= 10;
                Console.WriteLine("Kalan şarjınız:" + BatteryLevel);
            }
            else
            {
                Console.WriteLine("Yeterli şarjınız yok!");
            }

        }//şarjı azaltıyoruz
        public Robot(string model,int batteryLevel)
        {
            Model= model;
            BatteryLevel = batteryLevel;
        }//Constructor
    }
}
