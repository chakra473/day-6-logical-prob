using System;
using System.Diagnostics;

namespace logical_problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //coupon number logic ;
            Random random = new Random();
            Console.Write("press 1 to generate one digit coupon numbers\n" +
                "press 2 to generate two digit coupon numbers\n" +
                "press 3 to generate three digit coupon numbers\n" +
                "press 4 to generate four digit coupon numbers\n" +
                "press 5 to generate five digit coupon numbers");
            int check=int.Parse(Console.ReadLine());
            int a = 0, b = 0;
            switch (check)
            {
                case 1:a = 0;b = 10;break;
                case 2:a = 10;b = 20;break;
                case 3:a=100;b = 1000;break;
                case 4:a=1000;b = 10000;break;
                case 5:a=10000;b = 100000;break;
                default: Console.WriteLine("invalid input");break;
            }
            Console.WriteLine("enter the number of coupon numbers to be generated");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("the {0} unique coupon numbers are :", n);
           
            System.Collections.Generic.List<int> list = new System.Collections.Generic.List<int>();//created list to store random values;
            int i = 0,j=0;

            while (i < n)
            {
                int v = random.Next(a, b);
                if (!list.Contains(v))//only enter the condition if list does not contains values of random number i.e.only new number enters to the list;
                {
                    list.Add(v);//add the random number to the list
                    Console.WriteLine(v);
                    i++;

                }
                else
                {
                    j++;

                }

            }
            int total = i + j;
            Console.WriteLine("total random numbers needed to generate {0} unique numbers are {1}",i,total);




        }
            
        
    }
}
