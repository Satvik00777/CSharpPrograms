using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingQuestions
{
    internal class PrimeNumbers1to100
    {
        public static void Main(string[] args)
        {
            Console.Write("Prime Numbers between 1 to 100 :");
            
            int count = 0;
            for (int i=2; i<=100; i++)
            {
                for (int j = 2; j <= 100; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                    }
                }
                if (count == 1)
                {
                    Console.WriteLine(i);
                }
                count = 0;
            }
            Console.WriteLine();

            
        }
    }
}
