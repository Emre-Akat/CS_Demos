using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    internal class Student
    {
        // Öğrencinin temel bilgileri

        public string Name { get; }
        public string SurName { get; }
        public string stdNo { get; }

        // Notlar listesi
        public List<int> Grades { get; set; }

        // Ortalama: Notlar üzerinden otomatik hesaplanır
        public double Average { get
            { 
                if(Grades.Count==0)
                {
                    return 0;
                }

                return Grades.Average();
            
            } }
        // Geçme durumu: Ortalama 50 ve üzeri ise true
        public bool IsPassed => Average >= 50;


        // Tüm öğrencilerin toplam sayısını takip eder

        public static int TotalStudents = 0;

        // Yapıcı metot: Öğrenci bilgilerini alır, not listesini oluşturur
        public Student(string name, string surName, string stdNo)
        {
            Name = name;
            SurName = surName;
            this.stdNo = stdNo;
            TotalStudents++;
            Grades = new List<int>();
        }
        // Kullanıcıdan notları alır ve listeye ekler
        public void notEkle()
        {
            while (true)
            {
                Console.WriteLine("Not eklemek istiyorsanız E'ye basın, çıkmak için x'e");
                char karar=Convert.ToChar(Console.ReadLine());
                karar=char.ToLower(karar);
                if (karar == 'e')
                {
                    Console.WriteLine("Ders notunuzu giriniz :");
                    int not = Convert.ToInt32(Console.ReadLine());
                    Grades.Add(not);
                    Console.WriteLine($"Not eklendi {not}");
                }
                else if(karar=='x')
                {
                    Console.WriteLine("Sistemden çıkılıyor");
                    break;
                }
                else
                {
                    Console.WriteLine("Yanlış komut girdiniz tekrar deneyin");
                }
            }
        }
        // Öğrenci bilgilerini ve geçme durumunu yazdırır
        public void DisplayInfo()
        {
            Console.WriteLine($"Öğrencinin adı soyadı:{Name} {SurName} öğrenci no:{stdNo}  öğrencinin geçme kalma durumu:{(IsPassed ? "Geçti":"Kaldı")} Toplam öğrenci sayısı:{TotalStudents}");
        }
    }
}
