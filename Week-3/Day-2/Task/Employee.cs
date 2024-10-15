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

        public Employee() { }

        public int this[int index]
        {
            get
            {
                if (index == 0) // if index is 0, return ID
                {
                    return ID; 
                }
                else if (index == 1) // if index is 1, return Salary
                {
                    return Salary;
                }
                else // if index is not 0 or 1, return -1
                {
                    return -1;
                }
            }
            set
            {
                if (index == 0) // if index is 0, set ID
                {
                    ID = value;
                }
                else if (index == 1) // if index is 1, set Salary
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

    struct HireDate : IComparable<HireDate>
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

        public int CompareTo(HireDate other)
        {
            if (Year != other.Year)
                return Year.CompareTo(other.Year);
            if (Month != other.Month)
                return Month.CompareTo(other.Month);
            return Day.CompareTo(other.Day);
        }

        public override string ToString()
        {
            return $"{Day}/{Month}/{Year}";
        }
    }
}
