namespace QueueLab
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public Student(int id, string name, int age)
        {
            this.Id = id;
            this.Name = name;
            this.Age = age;
        }
        public override string ToString()
        {
            return $"{Id}-{Name}-{Age}";
        }
    }
}
