namespace Lab_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            NIC nic = NIC.Instance;
            nic.Manufacture = "Dell";
            nic.MacAddress = "00:0a:95:9d:68:16";
            nic.Type = "Ethernet";

            Console.WriteLine(nic);
        }
    }
}
