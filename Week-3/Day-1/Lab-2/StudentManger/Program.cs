using student;

namespace StudentManger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Mahmoud", 20, "Mansoura", "Mahmoud@gmail.com", "01000000000", "CCE", "Mansoura University" , "3.6");

            string data1 = student1.GetStudentInfo();
            
            Console.WriteLine(data1);

            Student student2 = new Student()
            {
                Name = "Omar",
                Address = "Cairo",
                Age = 22,
                Department = "MTE",
                Email = "Omar@yahoo.com",
                GPA = "3.92",
                Phone = "01200000000",
                University = "Cairo University"
            };
        }
    }
}
