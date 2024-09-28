namespace Session_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            int age = ReadInt("Enter your age: ", 17, 70);

            string name = ReadString("Enter your name: ");

            Console.ReadKey();
        }

        static string ReadString(string prompt)
        {
            Console.Write(prompt);
            string ans = Console.ReadLine();
            return ans;
        }

        static int ReadInt(string prompt, int low, int high)
        {
            Console.Write(prompt);
            do{
                int ans = int.Parse(Console.ReadLine());
                if (ans >= low && ans <= high)
                {
                    return ans;
                }
                Console.WriteLine("Please enter a number between " + low + " and " + high);
            } while (true);
        }
    }
}
