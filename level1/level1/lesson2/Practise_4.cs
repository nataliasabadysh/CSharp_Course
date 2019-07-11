using System;
namespace level1.lesson2
{
    public class Practise_4
    {
        static void P()
        {
            int sum = SumNumber();
            Console.Write(sum);

        }
        /// <summary>
        ///  С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
        /// </summary>
        /// <returns></returns>

        private static int SumNumber()
        {
            int sum = 0;

            while (true)
            {
                Console.Write("Number : ");
                int a = Convert.ToInt32(Console.ReadLine());

                if (a == 0) break;

                if (a > 0 && a % 2 == 1) sum += a;
            }

            return sum;
        }
    }
}
