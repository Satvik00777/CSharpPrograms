using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingQuestions
{
    internal class FactorialProgram
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the number for factorial: ");
            int n=Convert.ToInt32(Console.ReadLine());
            int fact = 1;
            if(n==0)
            {
                Console.Write("Zero don't have factorial");
            }
            else if(n==1)
            {
                Console.Write("The factorial of 1 is 1");
            }
            else if(n>1)
            {
                for(int i=1; i<=n;i++)
                {
                    fact=fact*i;
                }
                Console.Write(fact);
                Console.ReadLine();
            }
        }
    }
}
