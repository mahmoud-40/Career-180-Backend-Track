using Time;

namespace Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //-----------------------------------------------------------------------------------

            Duration D1 = new Duration(10, 15, 30);
            Duration D2 = new Duration(16, 22, 6);

            //-----------------------------------------------------------------------------------

            Console.WriteLine($"D1 = {D1}");
            Console.WriteLine($"D2 = {D2}");

            Duration D3 = D1 + D2;

            Console.WriteLine($"D3 = D1 + D2 = {D3}");

            Console.WriteLine();

            //-----------------------------------------------------------------------------------

            Console.WriteLine($"D1 = {D1}");
            Console.WriteLine($"D2 = {D2}");
            Console.WriteLine($"D3 = {D3}");

            D3 = 666 + D3;

            Console.WriteLine($"666 + D3 = {D3}");

            Console.WriteLine();

            //-----------------------------------------------------------------------------------

            Console.WriteLine($"D1 = {D1}");
            Console.WriteLine($"D2 = {D2}");
            Console.WriteLine($"D3 = {D3}");

            D3++;

            Console.WriteLine($"D3++ = {D3}");

            Console.WriteLine();

            //-----------------------------------------------------------------------------------

            Console.WriteLine($"D1 = {D1}");
            Console.WriteLine($"D2 = {D2}");
            Console.WriteLine($"D3 = {D3}");

            D3 = --D2;

            Console.WriteLine($"D3 = --D2 = {D3}");

            Console.WriteLine();

            //-----------------------------------------------------------------------------------

            Console.WriteLine($"D1 = {D1}");
            Console.WriteLine($"D2 = {D2}");

            if (D1 <= D2)
            {
                Console.WriteLine("D1 is less than or equal to D2");
            }
            else
            {
                Console.WriteLine("D1 is greater than D2");
            }

            Console.WriteLine();

            //-----------------------------------------------------------------------------------
        }
    }
}
