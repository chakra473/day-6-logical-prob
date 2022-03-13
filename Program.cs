using System;

namespace logical_problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //fibocci series logic for n numbers;
            Console.WriteLine("enter the number upto which fibonacci series to be printed");
            int n=int.Parse(Console.ReadLine());
            int n1 = 0, n2 = 1, n3 = 0;
            Console.Write("the fibonacci series of "+n+" are: " +n1 +" "+ n2 +" ");
            for(int i = 2; i < n; i++)
            {
                n3 = n1 + n2;
                Console.Write(n3 + " ");
                n1 = n2;
                n2= n3;
            }
        }
    }
}
