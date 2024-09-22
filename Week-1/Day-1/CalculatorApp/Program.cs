namespace CalculatorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the expression: ");

            string expression = Console.ReadLine();

            string[] parts = expression.Split(' ');

            if (parts.Length != 3)
            {
                Console.WriteLine("Invalid expression");
                return;
            }

            int a = int.Parse(parts[0]);

            int b = int.Parse(parts[2]);

            string operation = parts[1];

            int result = 0;
            
            switch (operation)
            {
                case "+":
                    result = Add(a, b);
                    break;
                case "-":
                    result = Subtract(a, b);
                    break;
                case "*":
                    result = Multiply(a, b);
                    break;
                case "/":
                    result = Divide(a, b);
                    break;
                case "%":
                    result = Modulus(a, b);
                    break;
                default:
                    Console.WriteLine("Invalid operation");
                    break;
            }

            Console.WriteLine($"Result: {result}");
        }

        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Subtract(int a, int b)
        {
            return a - b;
        }

        public static int Multiply(int a, int b)
        {
            return a * b;
        }

        public static int Divide(int a, int b)
        {
            return a / b;
        }

        public static int Modulus(int a, int b)
        {
            return a % b;
        }
    }
}
