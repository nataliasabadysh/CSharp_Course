using System;
namespace level1.lesson2
{
    public class Example6
    {

        // a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b).
        //  б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.


        static void FOR(int a, int b)
        {
            Console.Write($"{a}{b}");
            if (a < b) FOR(a + 1, b);
        }

        static int SUM(int a, int b)
        {
            return a < b ?  a + SUM(a, b) : a;
        }

        static void Maine7(string[] args)
        {
            FOR(1, 10); // 1, 2, 3, 4, 5, .. 10
            SUM(10, 12);//   .. 21, 33
        }

    }
}
