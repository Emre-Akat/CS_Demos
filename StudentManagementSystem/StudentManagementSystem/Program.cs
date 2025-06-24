namespace StudentManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student ogrnci1 = new Student("emre", "akat", "1234");
            ogrnci1.notEkle();
            ogrnci1.DisplayInfo();
        }
    }
}
