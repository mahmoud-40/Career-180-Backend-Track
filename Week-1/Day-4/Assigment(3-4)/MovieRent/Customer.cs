namespace MovieRent
{
    public interface ICustomer
    {
        void EnterDetails();
    }

    public class Customer
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public void EnterDetails()
        {
            Console.Write("Enter your name: ");
            Name = Console.ReadLine();
            Console.Write("Enter your address: ");
            Address = Console.ReadLine();
            Console.Write("Enter your phone: ");
            Phone = Console.ReadLine();
            Console.Write("Enter your email: ");
            Email = Console.ReadLine();
        }
    }
}