using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson2
{

    enum MyDays { Sat, Sun, Mon, Tue, Wed, Thu, Fri };

    class Program
    {
        static void Main1(string[] args)
        {

            #region ex1

            Console.WriteLine("Продолжить? y/n");
            string s = Console.ReadLine();

            //if (s == "y")       Console.WriteLine("Правильный выбор");
            //else if (s == "n")  Console.WriteLine("А ты точно подумал?... =/");
            //else if (s == "q")  Console.WriteLine("нажата кнопка q");
            //else if (s == "e")  Console.WriteLine("нажата кнопка e");
            //else                Console.WriteLine("Что-то ещё");


            #endregion

            #region Ex2

            //switch (s)
            //{
            //    case "y": Console.WriteLine("Правильный выбор"); break;
            //    case "n": Console.WriteLine("А ты точно подумал?... =/"); break;
            //    case "q": Console.WriteLine("нажата кнопка q"); break;
            //    case "e": Console.WriteLine("Правильный выбор"); break;
            //    default:  Console.WriteLine("Что-то ещё"); break;
            //}

            #endregion

            #region Ex3

            //Console.Write("a = ");
            //int a = Convert.ToInt32(Console.ReadLine());

            //Console.Write("b = ");
            //int b = Convert.ToInt32(Console.ReadLine());

            ////Console.Write("max = ");

            ////if (a > b) { Console.WriteLine(a); }
            ////else { Console.WriteLine(b); }

            ////int max;
            ////if (a > b) { max = a; }
            ////else { max = b; }

            //int max = a > b ? a : b;
            //Console.WriteLine($"max = {max}");

            #endregion

            #region Ex4

            //Console.Write("a = ");
            //int a = Convert.ToInt32(Console.ReadLine());

            //Console.Write("b = ");
            //int b = Convert.ToInt32(Console.ReadLine());

            //Console.Write("c = ");
            //int c = Convert.ToInt32(Console.ReadLine());

            //int max;

            //if (a > b && a > c)
            //{
            //    max = a;
            //}
            //else
            //{
            //    if (b > c)
            //    {
            //        max = b;
            //    }
            //    else
            //    {
            //        max = c;
            //    }
            //}


            //int max = a > b && a > c ? a : b > c ? b : c; // 0_0

            //Console.WriteLine($"max = {max}");

            #endregion

            #region Ex5

            //int a;

            //bool b = int.TryParse(Console.ReadLine(), out a);

            //Console.WriteLine(b?"Число":"чепуха");

            #endregion

            #region Ex6

            //Console.WriteLine("for");


            //for (int i = 100; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //int j = 100;

            //Console.WriteLine("while");

            //while (j < 10)
            //{
            //    Console.WriteLine(j);
            //    j++;
            //}



            //int k = 100;

            //Console.WriteLine("do-while");
            //do
            //{
            //    Console.WriteLine(k);
            //    k++;
            //}
            //while (k < 10);




            #endregion

            #region Ex7

            //string txt = "Привет!";

            //for (int i = 0; i < txt.Length; i++)
            //{
            //    Console.Write($"{txt[i]} ");
            //}
            //Console.WriteLine();

            //int j = 0;

            //while (j<txt.Length)
            //{
            //    Console.Write($"{txt[j]} ");
            //    j++;
            //}
            //Console.WriteLine();

            //int k = 0;

            //do
            //{
            //    Console.Write($"{txt[k]} ");
            //    k++;
            //}
            //while (k < txt.Length);
            //Console.WriteLine();

            //foreach (char symbol  in txt)
            //{
            //    Console.Write($"{symbol} ");
            //}

            #endregion

            #region Ex8


            //for (int a = -200; a <= 200; a++)
            //{
            //    for (int b = -200; b <= 200; b++)
            //    {
            //        for (int c = -200; c <= 200; c++)
            //        {
            //            if ((a + b) * c == 2019)
            //            {
            //                Console.WriteLine($"({a}, {b}, {c})");
            //            }

            //        }
            //    }
            //}


            #endregion

            #region Ex9

            //Console.Write("Введите N: ");
            //int n = Convert.ToInt32(Console.ReadLine());

            //for (int i = 2; i <=n ; i++)
            //{
            //    if (Simple(i)) Console.Write($"{i} ");
            //}

            #endregion

            #region Ex10

            //while (true)
            //{


            //    Console.Write("Введите N: ");
            //    int n = Convert.ToInt32(Console.ReadLine());


            //    int p = 2;
            //    string s = string.Empty;

            //    Console.Write($"{n} = ");
            //    while (n != 1)
            //    {
            //        if (n % p == 0) { s += $"{p} x "; n = n / p; p = 2; }
            //        p++;
            //    }

            //    Console.WriteLine(s.Substring(0,s.Length-3));
            //}



            #endregion

            #region Ex11



            string pi = @"141592653589793238462643383279502884197169399375105820974944592307816406286208998628034825342117067982148086513282306647093844609550582231725359408128481117450284102701938521105559644622948954930381964428810975665933446128475648233786783165271201909145648566923460348610454326648213393607260249141273724587006606315588174881520920962829254091715364367892590360011330530548820466521384146951941511609433057270365759591953092186117381932611793105118548074462379962749567351885752724891227938183011949129833673362440656643086021394946395224737190702179860943702770539217176293176752384674818467669405132000568127145263560827785771342757789609173637178721468440901224953430146549585371050792279689258923542019956112129021960864034418159813629774771309960518707211349999998372978049951059731732816096318595024459455346908302642522308253344685035261931188171010003137838752886587533208381420617177669147303598253490428755468731159562863882353787593751957781857780532171226806613001927876611195909";
            int count = 8;
            for (int i = 0; i < pi.Length - count; i++)
            {


                long n = Convert.ToInt64(pi.Substring(i, count));
                Console.WriteLine($">> {n} - ");
                if (Simple(n)) Console.WriteLine($">> {n}");

            }

            #endregion

            #region Ex12

            //ForOlolol(1, 50);

            #endregion

        }

        static void ForOlolol(int start, int end)
        {
            if (start < end) ForOlolol(start + 1, end);
            Console.WriteLine(start);
        }


        private static bool Simple(long n)
        {
            bool flag = true;

            for (long i = 2; i < n / 2 + 1; i++)
            {
                if (n % i == 0) { flag = false; break; }
            }

            return flag;
        }
    }
}