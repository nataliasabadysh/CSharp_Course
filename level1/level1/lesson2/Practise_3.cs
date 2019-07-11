using System;
namespace level1
{
    public class Practise_3
    {

        static void Main2(string[] args)
        {
            Console.Write(" a =="); int a = Convert.ToInt32(Console.ReadLine());
            Console.Write(" a =="); int b = Convert.ToInt32(Console.ReadLine());
            Console.Write(" a =="); int c = Convert.ToInt32(Console.ReadLine());


            //int a = 2;
            //int b = 2;
            //int c = 3;

            int min = MinValue2(a, b, c);

            Console.Write(min);
        }
        /// <summary>
        /// Написать метод, возвращающий минимальное из трёх чисел.
        /// </summary>
        /// <param name="a">First number </param>
        /// <param name="b">Second number</param>
        /// <param name="c">Third number </param>
        /// <returns></returns>
        private static int MinValue2(int a, int b, int c)
        {
            int min;

            if (a < b && a < c)
            {
                min = a;
            }
            else
            {
                if (b < c)
                {
                    min = b;
                }
                else { min = c; }
            }

            return min;
        }
    }
}
