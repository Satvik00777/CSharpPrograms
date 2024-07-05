
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingQuestions
{
    internal class ArmstrongNumber
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the number to check armstrong: ");
            int num=Convert.ToInt32(Console.ReadLine());
            int rem;
            int cube;
            int sum=0;
            int temp=num;
            while(num!=0)
            {
                rem = num % 10;
                cube = rem * rem * rem;
                sum=sum + cube;
                num=num / 10;
            }
            num = temp;
            if(num==sum)
            {
                Console.Write("The number is an armstrong number: "+num);
            }
            else
            {
                Console.Write("The number is not armstrong number: " + num);
            }
        }
    }
}
