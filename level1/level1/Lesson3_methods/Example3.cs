using System;
namespace level1.Lesson3_methods
{
    public class Example3
    {
        static void M(ref int n) {
            Console.Write($"M  = {n}"); // 10
             n = 2010;
            Console.Write($"M  = {n}"); // 2019 

        }
        static void Main(string[] args) 
        {
            int h = 10;
            Console.Write($"Main   = {h}"); 
            M(ref h); // h = 2019
            Console.Write($"Main   = {h}"); 
        }

    }
}
