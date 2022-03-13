using System;

namespace logical_problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //reverse number logic ;
            Console.WriteLine("enter a number");
            int n=int.Parse(Console.ReadLine());
            int rem = 0, rev = 0, temp = n;
            while(n>0)
            {
                rem = n % 10;
                rev =rev*10+ rem ;
                n=n/10;
            }
            Console.WriteLine("the reverse of {0} is {1}", temp, rev);
            
        }
    }
}
