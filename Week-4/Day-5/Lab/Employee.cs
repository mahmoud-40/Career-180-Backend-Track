namespace Lab
{
    public delegate void Del(Employee sender);

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Employee(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public event Del AddTo;

        public void Add()
        {
            AddTo(this);
        }

        public override string ToString()
        {
            return $"Employee with id: {Id} and name: {Name}";
        }
    }

}
