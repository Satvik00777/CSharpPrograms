using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingQuestions
{
    internal class FactorialByRecursion
    {

        int n = 5;
        int fact = 1;
        int Factorial()
        {
            if(n == 0)
            {
                return 1;
            }
            fact = fact * n;
            n--;
            Factorial();
            return fact;

        }
        public static void Main(string[] args)
        {
            FactorialByRecursion obj= new FactorialByRecursion();
            int factorial= obj.Factorial();
            Console.WriteLine("The factorial is : " + factorial);
            Console.ReadLine();
        }
    }
}
