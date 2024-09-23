namespace CalculatorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                System.Console.WriteLine("Here are the options: ");
                System.Console.WriteLine("1. Addition.");
                System.Console.WriteLine("2. Subtraction.");
                System.Console.WriteLine("3. Multiplication.");
                System.Console.WriteLine("4. Division.");
                System.Console.WriteLine("5. Modulus.");
                System.Console.WriteLine("6. Exit.");

                int choice = ReadChoice();

                if (choice == 6)
                {
                    System.Console.WriteLine("Exiting the application.");
                    break;
                }

                (int a, int b) = ReadNumbers();

                int result = 0;

                switch (choice)
                {
                    case 1:
                        result = Add(a, b);
                        break;
                    case 2:
                        result = Subtract(a, b);
                        break;
                    case 3:
                        result = Multiply(a, b);
                        break;
                    case 4:
                        if(b == 0)                         {
                            System.Console.WriteLine("Cannot divide by zero.");
                            Console.WriteLine();
                            continue;
                        }
                        result = Divide(a, b);
                        break;
                    case 5:
                        result = Modulus(a, b);
                        break;
                }

                System.Console.WriteLine($"The result is: {result}");
                System.Console.WriteLine();
            }
        }

        public static int ReadChoice()
        {
            int choice;
            do
            {
                System.Console.Write("Enter your choice: ");
                choice = int.Parse(System.Console.ReadLine());

                if (choice < 1 || choice > 6)
                {
                    System.Console.WriteLine("Invalid choice. Please try again.");
                }

            } while (choice < 1 || choice > 6);

            return choice;
        }

        public static (int, int) ReadNumbers()
        {
            System.Console.Write("Enter the first number: ");
            int a = int.Parse(System.Console.ReadLine());

            System.Console.Write("Enter the second number: ");
            int b = int.Parse(System.Console.ReadLine());

            return (a, b);
        }

        public static int Add(int a, int b) => a + b;
        public static int Subtract(int a, int b) => a - b;
        public static int Multiply(int a, int b) => a * b;
        public static int Divide(int a, int b) => a / b;
        public static int Modulus(int a, int b) => a % b;
    }
}
