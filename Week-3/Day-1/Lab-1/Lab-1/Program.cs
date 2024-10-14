using Time;

namespace Lab_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Duration d1 = new Duration(1, 10, 15);

            Console.WriteLine(d1.GetString());

            Duration d2 = new Duration(3600);

            Console.WriteLine(d2.GetString());

            Duration d3 = new Duration(7800);

            Console.WriteLine(d3.GetString());

            Duration d4 = new Duration(666);

            Console.WriteLine(d4.GetString());
        }
    }
}
