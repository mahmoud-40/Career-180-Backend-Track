namespace Session
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 20;

            Operation operation = new Operation();

            //----------------------------------------------

            // operation.Swap(a, b); // output: 10 20  -> pass by value

            // operation.Swap_ref(ref a, ref b); // output: 20 10 -> pass by reference

            // Console.WriteLine(a + " " + b);

            //----------------------------------------------

            // int sum = 0, sub = 0, mul = 0; // we need to initialize the variables as we are passing them by reference

            // operation.Calc_ref(a, b, ref sum, ref sub, ref mul); // output: 30 -10 200 

            //Console.WriteLine(sum + " " + sub + " " + mul);

            //----------------------------------------------

            // int sum, sub, mul; // we don't need to initialize the variables as we are passing them by out

            // operation.Calc_out(a, b, out sum, out sub, out mul); // output: 30 -10 200

            // Console.WriteLine(sum + " " + sub + " " + mul);

            //----------------------------------------------

            //int[] arr1 = { 1, 2, 3, 4, 5 };
            //int[] arr2 = { 6, 7, 8, 9 };

            //operation.Swap(arr1, arr2); // output: 1 2 3 4 5 - 6 7 8 9 -> swap won't happen

            //operation.Swap_ref(ref arr1, ref arr2); // output: 6 7 8 9 - 1 2 3 4 5 -> swap will happen

            //operation.Add(arr1, arr2); // output: 7 9 11 13 5 - 7 9 11 13

            //foreach (int i in arr1)
            //{
            //    Console.Write(i + " ");
            //}

            //Console.WriteLine();

            //foreach (int i in arr2)
            //{
            //    Console.Write(i + " ");
            //}

            //----------------------------------------------

            //int x = 10, y = 20;

            //Console.WriteLine(operation.Sum(a, b)); // output: 30

            //Console.WriteLine(operation.Sum(a, b, x, y)); // output: 60

            //----------------------------------------------

            int sum = operation.Sum("Mahmoud",2, 3, 5, 6, 7, 8, 9); // output: 40
            
            Console.WriteLine(sum);
            

        }
    }
}
