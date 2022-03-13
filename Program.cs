using System;
using System.Diagnostics;

namespace logical_problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //stopwatch logic ;
            
            var timer = new Stopwatch ();
            Console.WriteLine("start the stopwatch by pressing any key");
            Console.ReadKey();
            timer.Start();
          
            Console.WriteLine("end the stopwatch by pressing any key");
            Console.ReadKey();
            timer.Stop();

            TimeSpan timeTaken = timer.Elapsed;
            string foo = "Time taken: " + timeTaken.ToString(@"m\:ss\.fff");
            Console.WriteLine (foo);





        }
            
        
    }
}
