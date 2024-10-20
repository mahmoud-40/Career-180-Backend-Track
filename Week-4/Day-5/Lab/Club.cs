namespace Lab
{
     class Club
    {
        public List<Employee> Employees { get; set; }

        public Club()
        {
            Employees = new List<Employee>();
        }

        public void AddOnClub(Employee sender)
        {
            Employees.Add(sender);
            Console.WriteLine($"{sender} has been added to the club");
        }
    }
}
