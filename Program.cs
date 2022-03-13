using System;

namespace logical_problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //prime number logic ;
            Console.WriteLine("enter a number");
            int n=int.Parse(Console.ReadLine());
            int count = 1;
            for(int i = 2; i <= n; i++)
            {
                if(n%i==0)
                {
                    count++;
                }
            }
            if(count == 2)
            {
                Console.WriteLine(n+" IS A PRIME NUMBER");
            }
            else
            {
                Console.WriteLine(n + " IS NOT A PRIME NUMBER");
            }
            
        }
    }
}
