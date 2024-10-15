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

            SortEmployees(employees);

            foreach (Employee emp in employees)
            {
                Console.WriteLine(emp.ToString());
            }
        }

        public static void SortEmployees(Employee[] employees)
        {
            for (int i = 0; i < employees.Length; i++)
            {
                for (int j = i + 1; j < employees.Length; j++)
                {
                    if (employees[i].Date.Year > employees[j].Date.Year)
                    {
                        Employee temp = employees[i];
                        employees[i] = employees[j];
                        employees[j] = temp;
                    }
                    else if (employees[i].Date.Year == employees[j].Date.Year)
                    {
                        if (employees[i].Date.Month > employees[j].Date.Month)
                        {
                            Employee temp = employees[i];
                            employees[i] = employees[j];
                            employees[j] = temp;
                        }
                        else if (employees[i].Date.Month == employees[j].Date.Month)
                        {
                            if (employees[i].Date.Day > employees[j].Date.Day)
                            {
                                Employee temp = employees[i];
                                employees[i] = employees[j];
                                employees[j] = temp;
                            }
                        }
                    }
                }
            }
        }
    }
}
