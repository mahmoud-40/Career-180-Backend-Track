namespace Session_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account("Mahmoud", "Mansoura", 100);

            Account account2 = new Account("Ali", "Cairo");

            Account account3 = new Account("Omar");

            Console.WriteLine(account3.GetCount());
        }
    }
}
