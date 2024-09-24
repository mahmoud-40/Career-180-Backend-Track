/*
                                        * Assignment 2 *
 
    Write a C# Program take the grades of 4 subjects and IDs of 6 students using array 2D and print the following:
    • the grade evaluation of each subject
    • the total grade evaluation of each student
    • Print the ID of all students that fail in more than two subjects

    Grade >= 85% A
    85% > Grade >= 70% B
    70% > Grade >= 65% C
    65 > Grade >= 50% D
    Grade < 50 F

    Note:use methods approach
*/

using System.Diagnostics.Metrics;

namespace Assignment_2
{
    internal class Program
    {
        const int Students = 6;
        const int Subjects = 4;

        static void Main(string[] args)
        {
            int[,] data = new int[Students, Subjects + 1]; // ID - Subject1 - Subject2 - Subject3 - Subject4

            ReadData(data); // Read the data

            Grade(data); // Print the grade evaluation of each subject

            TotalGrade(data); // Print the total grade evaluation of each student

            FailStudents(data); // Print the ID of all students that fail in more than two subjects
        }

        static void ReadData(int[,] data)
        {
            for (int i = 0; i < Students; i++)
            {
                Console.Write($"Enter the ID of student {i + 1}: ");
                data[i, 0] = int.Parse(Console.ReadLine());

                for (int j = 1; j <= Subjects; j++)
                {
                    Console.Write($"Enter the grade of subject {j} for student {i + 1}: ");
                    data[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        static string GradeEvaluation(int grade)
        {
            if (grade >= 85)
                return "A";
            else if (grade >= 70)
                return "B";
            else if (grade >= 65)
                return "C";
            else if (grade >= 50)
                return "D";
            else
                return "F";
        }

        static void Grade(int[,] data)
        {
            Console.WriteLine("The grade evaluation of each subject:");

            for (int j = 1; j <= Subjects; j++)
            {
                Console.Write($"Subject {j}: ");
                for (int i = 0; i < Students; i++)
                {
                    Console.Write(GradeEvaluation(data[i, j]) + " ");
                }
                Console.WriteLine();
            }
        }

        static void TotalGrade(int[,] data)
        {
            Console.WriteLine("The total grade evaluation of each student:");

            for (int i = 0; i < Students; i++)
            {
                int total = 0;
                for (int j = 1; j <= Subjects; j++)
                {
                    total += data[i, j];
                }
                int average = (int)Math.Ceiling((double)total / Subjects);
                Console.Write($"Student {data[i, 0]}: {GradeEvaluation(average)} ");
                Console.WriteLine();
            }
        }

        static void FailStudents(int[,] data)
        {
            Console.WriteLine("The ID of all students that fail in more than two subjects:");

            bool found = false;

            for (int i = 0; i < Students; i++)
            {
                int count = 0;
                for (int j = 1; j <= Subjects; j++)
                {
                    if (data[i, j] < 50)
                    {
                        count++;
                    }
                }
                if (count > 2)
                {
                    Console.WriteLine(data[i, 0]);
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine("None!");
            }
        }
    }
}
