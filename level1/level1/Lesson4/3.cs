using System;
using System.Collections.Generic;

using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp43
{

    class A
    {
        public int[] arr = new int[10];
        public int[] arr2 = new int[10];

        public int this[int a, int index]
        {
            get { return a == 0 ? arr[index] : arr2[index]; }
            set { if (a == 0) arr[index] = value; else arr2[index] = value; ; }
        }


    }
    class Program
    {

        static void M() { }
        static void M(int a) { }
        static void M(string a) { }

        static void Ohoho(ref int[,] Matrix)
        {
            Matrix[0, 1] = 2019;
        }


        static void Print(int[,] Matrix)
        {
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    Console.Write($"{Matrix[i, j],5}");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            #region A
            Console.WriteLine();
            A a = new A();

            a.arr[1] = 123;
            a[1, 1] = 12;

            #endregion

            #region Пример 4

            //int[,] a = new int[3, 4];a[2, 1] = 12;

            //int[][] b = new int[7][];

            //b[0] = new int[6];
            //b[1] = new int[4];
            //b[2] = new int[5];
            //b[3] = new int[2];
            //b[4] = new int[3];
            //b[5] = new int[4];
            //b[6] = new int[5];
            //b[6] = new int[7];

            //Array.Resize(ref b, 8);
            //b[7] = new int[7];
            //Array.Resize(ref b[7], 12);


            //for (int i = 0; i < b.Length; i++)
            //{
            //    for (int j = 0; j < b[i].Length; j++)
            //    {
            //        Console.Write($"{b[i][j],3}");
            //    }
            //    Console.WriteLine();
            //}


            #endregion

            #region Пример 3


            //int[,,,] m = new int[4, 5, 6, 7];
            ////0  1 
            //for (int j = 0; j < m.GetLength(0); j++)
            //{
            //    for (int l = 0; l < m.GetLength(1); l++)
            //    {
            //        for (int k = 0; k < m.GetLength(2); k++)
            //        {
            //            for (int i = 0; i < m.GetLength(3); i++)
            //            {
            //                Console.Write(m[j,l,k,i]+" " );
            //            }
            //            Console.WriteLine();
            //        }
            //        Console.WriteLine();
            //    }
            //}


            #endregion

            #region  Пример 2

            //int row = Convert.ToInt32(Console.ReadLine());
            //int col = Convert.ToInt32(Console.ReadLine());
            //int[,] m = new int[row, col];
            ////0  1 

            //m[2, 0] = 123;
            //Ohoho(ref m);
            //Print(m);

            //Program[] programs = new Program[11];

            #endregion

            #region Пример 1



            ////////  
            //////// ┌──────────┐              
            //////// │   2018   │  - переменная
            //////// └──────────┘              
            ////////    valueA                 
            ////////
            //////// ┌────────────────────────────────────────────────────────────────────────────┐
            //////// │    ┌─────────┐   ┌─────────┐   ┌─────────┐   ┌─────────┐   ┌──────────┐    │
            //////// │    │   1.2   │   │   3.4   │   │   5.6   │   │   7.8   │   │   9.10   │    │
            //////// │    └─────────┘   └─────────┘   └─────────┘   └─────────┘   └──────────┘    │
            //////// │         0             1             2             3             4          │
            //////// └────────────────────────────────────────────────────────────────────────────┘
            ////////                                    array                                    
            ////////                                                                             
            //////// array[0], array[1], array[2], array[3], array[4]                            
            //////// Индексы элементов меняются в диапазоне 0 .. 4                               

            ////массив из 5 элементов

            //Console.Write("Сколько вагонов нужно? ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //double[] train = new double[n];

            //train[0] = 1.342;
            //train[1] = 3.4;
            //train[2] = 5.16;
            //train[3] = 1.21;
            //train[4] = 1.221;


            //Random r = new Random();

            //for (int coach = 0; coach < train.Length; coach++)
            //{
            //    train[coach] = r.Next(1, 100);

            //    Console.WriteLine($"{train[coach],5}^2 = {train[coach] * train[coach]}");
            //}
            //Console.Clear();
            //Console.WriteLine();
            //for (int i = 0; i < train.Length; i++)
            //{
            //    Console.Write($"{  train[i],3}");
            //}

            //Array.Resize(ref train, train.Length + 10);

            //Console.WriteLine();
            //for (int i = 0; i < train.Length; i++)
            //{
            //    Console.Write($"{  train[i],3}");
            //}

            //Array.Sort(train);

            //Console.WriteLine();
            //for (int i = 0; i < train.Length; i++)
            //{
            //    Console.Write($"{  train[i],3}");
            //}


            //Array.Reverse(train);



            //Console.WriteLine();
            //for (int i = 0; i < train.Length; i++)
            //{
            //    Console.Write($"{  train[i],3}");
            //}



            //Console.ReadKey();              // задержка черного экрана

            #endregion

        }
    }
}
