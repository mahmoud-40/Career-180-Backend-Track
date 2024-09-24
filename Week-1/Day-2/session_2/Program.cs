namespace session_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
            1. Print N stars shape
            
            int N = 6;

            for (int row = 0; row < N; row++)
            {
                for (int column = 0; column < N; column++)
                {
                    if (column == 0 || column == N - 1 || (row == column))
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            */

            // ---------------------------------------------------------------------------------------

            /*
            Console.WriteLine("Enter the input in the shape of r, l, cost");

            string input = Console.ReadLine();

            string[] array = input.Split(',');

            int r = int.Parse(array[0]);

            int l = int.Parse(array[1]);

            int cost = int.Parse(array[2]);

            // area of cylinder = 2 * 3.14 * r * (r + l)
            // surface area of cylinder = 2 * 3.14 * r * l
            // total cost = cost * surface area of cylinder

            double area = 2 * 3.14 * r * (r + l); 

            double surfaceArea = 2 * 3.14 * r * l;

            double totalCost = cost * surfaceArea;

            Console.WriteLine("Area of cylinder is: " + area);

            Console.WriteLine("Surface area of cylinder is: " + surfaceArea);

            Console.WriteLine("Total cost is: " + totalCost);
            */

            // ---------------------------------------------------------------------------------------
            
            int[,] students = new int[5, 2];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter the ID of student " + (i + 1));
                students[i, 0] = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the score of student " + (i + 1) + " at Math");
                students[i, 1] = int.Parse(Console.ReadLine());
            }

            int sum = 0;

            for (int i = 0; i < 5; i++)
            {
                sum += students[i, 1];
            }

            double avg = sum / 5;

            Console.WriteLine("The average score of all students at Math is: " + avg);

            int highestScore = 0;

            int studentID = 0;

            for (int i = 0; i < 5; i++)
            {
                if (students[i, 1] > highestScore)
                {
                    highestScore = students[i, 1];
                    studentID = students[i, 0];
                }
            }

            Console.WriteLine("The student with the highest score ID is: " + studentID + " and the score is: " + highestScore);

            int good = 0;

            int veryGood = 0;

            for (int i = 0; i < 5; i++)
            {
                if (students[i, 1] > 70)
                {
                    if (students[i, 1] >= 80)
                    {
                        Console.WriteLine("The student with ID: " + students[i, 0] + " has scored very good with score: " + students[i, 1]);
                        veryGood++;
                    }
                    else
                    {
                        Console.WriteLine("The student with ID: " + students[i, 0] + " has scored good with score: " + students[i, 1]);
                        good++;
                    }
                }
            }

            Console.WriteLine("The count of students who scored good is: " + good);

            Console.WriteLine("The count of students who scored very good is: " + veryGood);
        }
    }
}
