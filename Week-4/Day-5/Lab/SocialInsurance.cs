namespace Lab
{
     class SocialInsurance
    {
        public List<Employee> Employees { get; set; }

        public SocialInsurance()
        {
            Employees = new List<Employee>();
        }

        public void BeginSocialInsurance(Employee sender)
        {
            Employees.Add(sender);
            Console.WriteLine($"{sender} has been added to the social insurance");
        }
    }
}
