namespace Q1
{
    public class Student
    {
        private int id;
        private string name;
        private int age;
        private static int studentCount = 0;

        public int Id { get { return id; } }
        public string Name { get { return name; } set { name = value; } }
        public int Age { get { return age; } set { age = value; } }
        public static int StudentCount { get {  return studentCount; } }

        public Student()
        {
            name = "John Doe";
            age = 16;
            id = ++studentCount;
        }

        public Student(string name, int age)
        {
            this.name = name;
            this.age = age;
            id = ++studentCount;
        }

        public void Display()
        {
            Console.WriteLine($"StudentID: {id} Name: {name} Age: {age}");
        }

        public int GetOlder()
        {
            return ++age;
        }
    }
}