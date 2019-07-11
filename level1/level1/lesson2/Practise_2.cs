using System;

namespace level1
{
    public class Practise_2
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("A == ");

            int a = Convert.ToInt32(Console.ReadLine());
            int count = Counter(a);
            Console.WriteLine(count);
        }
        /// <summary>
        /// Написать метод подсчета количества цифр числа.
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>

        private static int Counter(int a)
        {
            if (a === 0) count = 1;

            int count = 0;
            while (a != 0)
            {
                a = a / 10;
                count++;

            }

            return count;
        }
    }
}
