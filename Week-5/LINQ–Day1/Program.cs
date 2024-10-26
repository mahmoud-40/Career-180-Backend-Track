namespace LINQ__Day1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //-----------------------(1)---------------------------------
            List<int> numbers = new List<int>() { 2, 4, 6, 7, 1, 4, 2, 9, 1 };

            var q1 = numbers.Distinct().OrderBy(x => x).ToList();

            foreach (var item in q1)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            //-----------------------

            var q2 = numbers.Select(x => new { Number = x, Multiply = x * x }).ToList();

            foreach (var item in q2)
            {
                Console.WriteLine($"(Number = {item.Number}, Multiply = {item.Multiply})");
            }

            Console.WriteLine();

            //-----------------------(2)---------------------------------

            string[] names = { "Tom", "Dick", "Harry", "MARY", "Jay" };

            var q3 = names.Where(s => s.Length == 3);

            foreach (var name in q3)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine();

            //--------------------

            var q4 = names.Where(s => s.Contains('A') || s.Contains('a')).OrderBy(s => s.Length);

            foreach (var name in q4)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine();

            //--------------------

            var q5 = names.Take(2);

            foreach (var name in q5)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine();

            //-----------------------(3)---------------------------------

            List<Student> students = new List<Student>()
            {
                new Student()
                {
                    Id = 1, FirstName = "Ali", LastName = "Mohammed",
                    Subjects = new Subject[]
                    {
                        new Subject() { Code = 22, Name = "EF" }, new Subject()
                        {
                            Code = 33, Name = "UML"
                        }
                    }
                },
                new Student()
                {
                    Id = 2,
                    FirstName = "Mona", LastName = "Gala",
                    Subjects = new Subject[]
                    {
                        new Subject() { Code = 22, Name = "EF" }, new Subject()
                        {
                            Code = 34, Name = "XML"
                        },
                        new Subject() { Code = 25, Name = "JS" }
                    }
                },
                new
                    Student()
                    {
                        Id = 3, FirstName = "Yara", LastName = "Yousf", Subjects = new Subject
                            []
                            {
                                new Subject() { Code = 22, Name = "EF" }, new Subject()
                                {
                                    Code = 25, Name = "JS"
                                }
                            }
                    },
                new Student()
                {
                    Id = 1,
                    FirstName = "Ali", LastName = "Ali",
                    Subjects = new Subject[] { new Subject() { Code = 33, Name = "UML" } }
                },
            };

            var q6 = students.Select( s => new { FullName = s.FirstName + " " + s.LastName, NoOfSubjects = s.Subjects.Length });

            foreach (var student in q6)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine();

            //--------------------

            var q7 = students.OrderByDescending(s => s.FirstName).ThenBy(s => s.LastName).Select(s => new {s.FirstName, s.LastName});

            foreach (var student in q7)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}");
            }

            Console.WriteLine();

            //-----------------------------------------------------------------
        }
    }
}
