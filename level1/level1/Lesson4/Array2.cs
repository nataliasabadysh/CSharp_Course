using System;
namespace level1.Lesson4
{
    public class Array2
    {

        static void Mane(string[] args)
        {
            int row = Convert.ToInt32(Console.ReadLine()); // 9
            int col = Convert.ToInt32(Console.ReadLine()); // 5 

            // Array
            int[,] matrix = new int[row, col];

            matrix[3, 0] = 123;

            for (int i = 0; i < matrix.GetLength(0); i++) // ro = 9
            {
                for (int j = 0; j < matrix.GetLength(1); j++) // 1 = 5
                {
                    Console.Write($"{matrix[i, j],5}"); // 5 simbols 
                }

                Console.WriteLine();
            }
  




            //static void Mane(string[] args)
            //{


            //    // ____________________________
            //    // string-9 and rows -5
            //    int row = Convert.ToInt32(Console.ReadLine()); // 9
            //    int col = Convert.ToInt32(Console.ReadLine()); // 5 

            //    int[,] matrix = new int[row, col];

            //    // ____________________________
            //    // 3- string 0 rows  = 123;
            //    matrix[3, 0] = 123;

            //    // ____________________________
            //    // to show All string and rows

            //    for (int i = 0; i < matrix.GetLength(0); i++) // ro = 9
            //    {
            //        for (int j = 0; j < matrix.GetLength(1); j++) // 1 = 5
            //        {
            //            Console.Write($"{matrix[i, j], 5}"); // 5 simbols 
            //        }

            //        Console.WriteLine(); 
            //    }


        }
    }
}
