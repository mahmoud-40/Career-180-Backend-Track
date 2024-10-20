namespace QueueLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<Student> q = new Queue<Student>();

            q.InQueue(new Student(1, "Mahmoud", 21));
            q.InQueue(new Student(2, "Omar", 18));
            q.InQueue(new Student(3, "Khalid", 30));


            Console.WriteLine(q.DeQueue());
            Console.WriteLine(q.DeQueue());
            Console.WriteLine(q.DeQueue());

            // Console.WriteLine(q.DeQueue());
        }
    }
}
