using System;
namespace level1.Lesson3_methods
{
    public class Example8
    {
        static void Maine(string[] args)
        {
            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                //Console.WriteLine(r.Next(1, 20));
                Console.WriteLine((r.NextDouble()*10).ToString("#.##"));
            }
            // for 0 to 10 
        }
    }
}
