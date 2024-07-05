using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingQuestions
{
    internal class PrimeNumber
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the number to check prime :");
            int n=Convert.ToInt32(Console.ReadLine());
            int count = 0;
            for(int i=1; i<=n; i++)
            {
                if(n%i==0)
                {
                    count++;
                }
            }
            if(count == 2)
            {
                Console.WriteLine("The number is prime", n);
            }
            else
            {
                Console.WriteLine("The number is not prime", n);
            }
        }
    }
}
