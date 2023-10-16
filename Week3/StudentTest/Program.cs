using Q1;

namespace StudentTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            Student student2 = new Student("Jane Doe", 18);

            student1.Display();
            student2.Display();

            int s1Age = student1.GetOlder();
            int s2Age = student2.GetOlder();
            student1.GetOlder();

            student1.Display();
            student2.Display();

            Console.WriteLine($"Number of students: {Student.StudentCount}");

            student1.Name = "John Smith";
            student1.Age = 31;
            student1.Display();
        }
    }
}