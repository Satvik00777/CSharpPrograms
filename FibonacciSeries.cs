using System;

namespace fibonacci
{
    public class Fibonacci
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the number for series : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int a = 0; int b = 1;
            int c;
            for (int i = 0; i <= n; i++)
            {
                c = a + b;
                Console.WriteLine(c);
                a = b;
                b = c;
            }
        }
    }
}