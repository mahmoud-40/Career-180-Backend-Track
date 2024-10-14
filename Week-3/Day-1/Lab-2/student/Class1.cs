namespace student
{
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Department { get; set; }
        public string University { get; set; }
        public string GPA { get; set; }

        public Student(string name, int age, string address, string email, string phone, string department, string university, string gpa)
        {
            Name = name;
            Age = age;
            Address = address;
            Email = email;
            Phone = phone;
            Department = department;
            University = university;
            GPA = gpa;
        }

        public Student()
        {
            Name = "Unknown";
            Age = 0;
            Address = "Unknown";
            Email = "Unknown";
            Phone = "Unknown";
            Department = "Unknown";
            University = "Unknown";
            GPA = "Unknown";
        }

        public string GetStudentInfo()
        {
            return $"Name: {Name}\nAge: {Age}\nAddress: {Address}\nEmail: {Email}\nPhone: {Phone}\nDepartment: {Department}\nUniversity: {University}\nGPA: {GPA}";
        }
    }
}
