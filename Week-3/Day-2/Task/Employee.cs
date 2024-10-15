namespace Task
{
    interface IEmployee
    {
        public string ToString();
    }

    class Employee : IEmployee
    {
        private int _id;
        public int ID
        {
            get
            {
                return _id;
            }
            set
            {
                if(value < 0)
                {
                    throw new Exception("Wrong Input. (It should be positive number)");
                }
                else
                {
                    _id = value;
                }
            }
        }

        private int _salary;
        public int Salary
        {
            get
            {
                return _salary;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Wrong Input. (It should be positive number)");
                }
                else
                {
                    _salary = value;
                }
            }
        }

        private string _gender;
        public string Gender
        {

            get
            {
                return _gender;
            }
            set
            {
                string v = value.ToLower();
                if (v == "male" || v == "female")
                {
                    _gender = value;
                }
                else
                {
                    throw new Exception("Wrong Input. (It should be Male or Female)");
                }
            }
        }

        private HireDate _date;

        public HireDate Date
        {
            get
            {
                return _date;
            }
            set
            {
                if (value.Day < 1 || value.Day > 31 || value.Month < 1 || value.Month > 12 || value.Year < 2000 || value.Year > 2024)
                {
                    throw new Exception("Wrong Input. (Day : 1-31, Month : 1-12, Year : 2000-2024)");
                }
                else
                {
                    _date = value;
                }
            }
        }

        public Employee(int id, int salary, string gender, HireDate date)
        {
            ID = id;
            Salary = salary;
            Gender = gender;
            Date = date;
        }

        public int this[int index]
        {
            get
            {
                if (index == 0)
                {
                    return ID;
                }
                else if (index == 1)
                {
                    return Salary;
                }
                else
                {
                    return 0;
                }
            }
            set
            {
                if (index == 0)
                {
                    ID = value;
                }
                else if (index == 1)
                {
                    Salary = value;
                }
            }
        }

        public override string ToString()
        {
            return $"ID: {ID}, Salary : {Salary}, Gender : {Gender}, Date : {Date}";

        }
    }

    internal struct HireDate
    {
        public int Day;
        public int Month;
        public int Year;

        public HireDate(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }

        public override string ToString()
        {
            return $"{Day}/{Month}/{Year}";
        }
    }
}
