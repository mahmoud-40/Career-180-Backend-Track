using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session
{
    class Operation
    {
        // here x and y will swap but the values of a and b will remain the same
        // because the values of a and b are passed by value
        public void Swap(int x, int y) 
        {
            int temp = x;

            x = y;

            y = temp;
        }

        // here x and y will swap and the values of a and b will also swap
        // because the values of a and b are passed by reference
        public void Swap_ref(ref int x, ref int y)
        {
            int temp = x;

            x = y;

            y = temp;
        }

        // here all the ref variables must be initialized before passing them to the function
        public void Calc_ref(int a, int b, ref int sum ,ref int sub, ref int mul)
        {
            sub = a - b;

            mul = a * b;

            sum = a + b;
        }

        // here we must assign the out variables inside the function
        public void Calc_out(int a, int b, out int sum, out int sub, out int mul)
        {
            sum = 0;
            sub = 0;
            mul = 0;

            sub = a - b;

            mul = a * b;

            sum = a + b;
        }

        // here the arrays will not swap because the arrays are passed by value (ref by value)
        public void Swap(int[] a, int[] b)
        {
            int[] temp = a;

            a = b;

            b = temp;
        }

        // here the arrays will swap because the arrays are passed by reference (ref by ref)
        public void Swap_ref(ref int[] a, ref int[] b)
        {
            int[] temp = a;

            a = b;

            b = temp;
        }

        // here the values of the arrays will be incremented by 1
        public void Add(int[] a, int[] b)
        {
            for (int i = 0; i < a.Length; i++)
            {
                a[i] += 1;
            }

            for (int i = 0; i < b.Length; i++)
            {
                b[i] += 1;
            }
        }

        // Default parameters
        public int Sum(int a, int b, int x = 0, int y = 0)
        {
            return a + b + x + y;
        }

        // params keyword
        public int Sum(string name, params int[] a)
        {
            Console.WriteLine($"Hello {name}!!");

            int sum = 0;

            foreach (int i in a)
            {
                sum += i;
            }

            return sum;
        }
    }
}
