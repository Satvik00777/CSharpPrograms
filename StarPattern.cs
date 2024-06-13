using System;

namespace pattern
{
    public class StarPattern
    {
        public static void Main(string[] args)
        {
            int i,j,n;
            Console.Write("Enter number: ");
            n=Convert.ToInt32(Console.ReadLine());
            for(i=1;i<=n;i++)
            {
                for(j=1;j<=n;j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}

