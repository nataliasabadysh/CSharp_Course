using System;
namespace level1.Lesson3_methods
{
    public class Example1
    {
        static void Maine7(string[] args)
        {

            int a = 1;
            int b = 2;

 
            Swap( a,  b);



            // method without arg and not returning anything 
            StopConsole();
            Print("some Message");

            // method returns time 
            string a = GetTime();
            Console.WriteLine(a)



        }

        private static void Swap( int a,  int b)
        {
            int c = a;
            a = b;
            b = c;
        }

        // 
        static void StopConsole()
        {
            Console.ReadKey();
        }
        // getting arg , but not returning results

        static void Print(string Messege)
        {
            Console.WriteLine(Messege);
        }


        // no arg , but returns result

        static DateTime GetTime() {

            return DateTime.Now.ToStrign();

        }



    }
}
