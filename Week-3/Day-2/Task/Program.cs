namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of employees: ");

            int size = int.Parse(Console.ReadLine());

            Employee[] employees = new Employee[size];

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Enter the ID: ");
                int id = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the Salary: ");
                int salary = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the Gender (Male - Female): ");
                string gender = Console.ReadLine();

                Console.WriteLine("Enter the Day (1 : 31): ");
                int day = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the Month (1 : 12): ");
                int month = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the Year (2000 : 2024): ");
                int year = int.Parse(Console.ReadLine());

                HireDate date = new HireDate(day, month, year);

                Employee emp = new Employee(id, salary, gender, date);

                employees[i] = emp;
            }

            //  var sorted = employees.OrderBy(emp => emp.Date); // returns a new IEnumerable<Employee> sorted by Date but does not change the original array

            Array.Sort(employees, (emp1, emp2) => emp1.Date.CompareTo(emp2.Date)); // sorts the array itself based on their hire date

            foreach (Employee emp in employees)
            {
                Console.WriteLine(emp.ToString());
            }

            #region IndexersCheck

            //Employee employee = new Employee { ID = 1, Salary = 4666, Date = new HireDate { Day = 1, Month = 1, Year = 2022 }, Gender = "Male" };

            //Console.WriteLine(employee.ToString());

            //Console.WriteLine(employee[0]); // 1

            //employee[0] = 2;

            //Console.WriteLine(employee[0]); // 2

            //Console.WriteLine(employee.ToString());

            //Console.WriteLine(employee[1]); // 4666

            //employee[1] = 5000;

            //Console.WriteLine(employee[1]); // 5000

            //Console.WriteLine(employee.ToString());

            //Console.WriteLine(employee[2]); // -1

            //Console.WriteLine(employee.ToString());

            #endregion
        }
    }
}
