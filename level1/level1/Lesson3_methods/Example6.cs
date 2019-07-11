using System;
using System.Threading;

namespace level1.Lesson3_methods
{
    public class Example6
    {
        static void Main(string[] args)
        {
            //while (true) {
            //    Console.WriteLine(DateTime.Now.ToLongDateString());
            //    Thread.Sleep(999);
            //    Console.Clear();
            //}

            double a = 0;
            DateTime now = DateTime.Now;

            // 1
            //for (int i = 0; i <= 10000; i++)  {
            //    a += i;
            //}


            // 2 
            a = ( (double)10000 * (double)(10000 + 1)) / 2;

            TimeSpan time = (DateTime.Now - now);
            Console.WriteLine(time.TotalMilliseconds);

            Console.WriteLine(a);



        }
    }
}
