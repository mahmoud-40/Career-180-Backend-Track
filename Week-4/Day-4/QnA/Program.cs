namespace QnA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Question q1 = new Question("What is the capital of Egypt?", 10);
            Answer a1 = new Answer(1, "Cairo");
            Answer a2 = new Answer(2, "Alexandria");
            Answer a3 = new Answer(3, "Giza");
            Answer a4 = new Answer(4, "Luxor");

            Question q2 = new Question("What is the capital of France?", 8);
            Answer a5 = new Answer(1, "Marseille");
            Answer a6 = new Answer(2, "Lyon");
            Answer a7 = new Answer(3, "Paris");
            Answer a8 = new Answer(4, "Toulouse");

            Question q3 = new Question("What is the capital of Japan?", 7);
            Answer a9 = new Answer(1, "Yokohama");
            Answer a10 = new Answer(2, "Osaka");
            Answer a11 = new Answer(3, "Kyoto");
            Answer a12 = new Answer(4, "Tokyo");

            Question q4 = new Question("What is the capital of Italy?", 5);
            Answer a13 = new Answer(1, "Rome");
            Answer a14 = new Answer(2, "Milan");
            Answer a15 = new Answer(3, "Naples");
            Answer a16 = new Answer(4, "Turin");

            Dictionary<Question, List<Answer>> exam = new Dictionary<Question, List<Answer>>();

            exam.Add(q1, new List<Answer> { a1, a2, a3, a4 });
            exam.Add(q2, new List<Answer> { a5, a6, a7, a8 });
            exam.Add(q3, new List<Answer> { a9, a10, a11, a12 });
            exam.Add(q4, new List<Answer> { a13, a14, a15, a16 });

            foreach (var question in exam)
            {
                Console.WriteLine(question.Key);
                foreach (var answer in question.Value)
                {
                    Console.WriteLine(answer);
                }
                Console.WriteLine();
            }
        }
    }
}
