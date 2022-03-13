using System;

namespace logical_problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //perfect number logic ;
            Console.WriteLine("enter a number");
            int n=int.Parse(Console.ReadLine());
            int res = 0;
            for(int i=1; i<n; i++)
            {
                if(n%i==0)
                {
                res=res+i;
                }
            }
            if(res==n)
            {
                Console.WriteLine(n+" IS A PERFECT NUMBER");
            }
            else
            {
                Console.WriteLine(n + " IS NOT A PERFECT NUMBER");
            }
        }
    }
}
