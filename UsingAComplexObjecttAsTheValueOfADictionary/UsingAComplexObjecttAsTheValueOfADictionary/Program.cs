namespace UsingAComplexObjecttAsTheValueOfADictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Dictionary<string,Student>students=new Dictionary<string,Student>();
            students.Add("1001", new Student("Emre", "Akat"));
            students["1001"].Grades.AddRange(new List<int> { 80, 70 });
            foreach (var student in students)
            {
                Console.WriteLine($"Öğrenci no:{student.Key}");
                student.Value.DisplayInfo();
            }
        }
    }
}
class Student
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public List<int> Grades { get; set; }

    public Student(string name, string surname)
    {
        Name = name;
        Surname = surname;
        Grades = new List<int>();
    }

    public double GetAverage()
    {
        return Grades.Count > 0 ? Grades.Average() : 0;
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"Ad:{Name} {Surname} Not Ortalamsı:{GetAverage()}");
    }
}
