using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingQuestions
{
    internal class SumOfNEvenNumbers
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number upto the sum: ");
            int n=Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for(int i=2; i<=n; i++)
            {
                if(i%2==0)
                {
                    sum=sum+i;
                    
                }
            }
            Console.WriteLine(sum);
        }
    }
}
