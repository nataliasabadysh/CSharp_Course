using System;
using System.IO;

namespace ConsoleApp44
{
    class Program
    {
        static void Main(string[] args)
        {

            StreamReader sr = new StreamReader(@"e:\file.txt");

            while (!sr.EndOfStream)
            {
                string s = sr.ReadLine();
                int a = Convert.ToInt32(s);
                Console.WriteLine(a * 10);

            }

            sr.Close();

            //StreamWriter sw = new StreamWriter(@"e:\file.txt");
            //sw.WriteLine("cdcd");
            //sw.WriteLine("cdcd");
            //sw.WriteLine();
            //sw.WriteLine("cdcd");


            //sw.Close();
        }
    }
}
