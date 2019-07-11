using System;
namespace level1.Lesson3_methods
{
    class Example5
    {
        static void Main(string[] args)
        {
           int res = GetValue();
            Console.WriteLine(res);
        }

        private static int GetValue()
        {
            int a;
            while (true)
            {
                Console.WriteLine("Number is :");
                bool s = int.TryParse(Console.ReadLine(), out a);
                if (s)
                {
                    if (a >= 10 && a <= 30) return a;
                }
            }
        }
    }
}
