namespace Lab_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point();
            Point p2 = new Point();

            Console.WriteLine("Enter the coordinates of the first point: ");

            Coordinates(p1);

            Console.WriteLine("Enter the coordinates of the second point: ");

            Coordinates(p2);


            Console.WriteLine($"First point: {p1.ToString()}");
            Console.WriteLine($"Second point: {p2.ToString()}");

            Console.WriteLine(p1 == p2 ? "The points are equal." : "The points are not equal.");

            Console.WriteLine(p1.Equals(p2) ? "The points are equal." : "The points are not equal.");
        }

        static void Coordinates(Point point)
        {
            point.X = ReadCoordinate("X");
            point.Y = ReadCoordinate("Y");
            point.Z = ReadCoordinate("Z");
        }

        static int ReadCoordinate(string name)
        {
            while (true)
            {
                Console.Write($"{name}: ");

                string input = Console.ReadLine();

                try
                {
                    return int.Parse(input);
                }
                catch (Exception ex)
                {
                    LogError("Invalid input. Please enter a number.", ex);
                }
            }
        }

        static void LogError(string message, Exception ex)
        {
            Console.WriteLine(message);

            StreamWriter stream = File.AppendText("logs.txt");
            stream.WriteLine($"{ex.Message} -{ex.Source}-{ex.TargetSite} -{DateTime.Now.ToString()}");
            stream.Close();
        }
    }
}
