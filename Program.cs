using System;

namespace logical_problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //coupon number logic ;
            Random random = new Random();
            Console.WriteLine("enter the number of coupon numbers to be generated");
            int n=int.Parse(Console.ReadLine());
            Console.WriteLine("the {0} unique coupon numbers are :",n);
            System.Collections.Generic.List<int> list = new System.Collections.Generic.List<int>();//created list to store random values;
            int i = 0;
            while (i < n)
            {
                int v = random.Next(10, 20);
                if (!list.Contains(v))//only enter the condition if list does not contains values of random number i.e.only new number enters to the list;
                {
                    list.Add(v);//add the random number to the list
                    Console.WriteLine(v);
                    i++;

                }
                else
                {
                    i--;
                
               }

            }

          
           
            
        }
            
        
    }
}
