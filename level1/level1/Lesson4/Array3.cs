using System;
namespace level1.Lesson4
{
    class Program
    { 
       static void Print(int[,] Matrix)
        {
            for (int i = 0; i < Matrix.GetLength(0); i++) // ro = 9
            {
                for (int j = 0; j < Matrix.GetLength(1); j++) // 1 = 5
                {
                    Console.Write($"{Matrix[i, j],5}"); // 5 simbols 
                }

                Console.WriteLine();
            }
        }
        static void Main()
        {
            int[,] m = new int[2, 5];
            Print(m);

        }

    }

}
