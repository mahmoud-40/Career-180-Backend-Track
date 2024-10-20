namespace Lab
{
     class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(1, "Mahmoud");

            SocialInsurance socialInsurance = new SocialInsurance();

            Club club = new Club();

            employee.AddTo += club.AddOnClub;

            employee.AddTo += socialInsurance.BeginSocialInsurance;

            employee.Add();
        }
    }
}
