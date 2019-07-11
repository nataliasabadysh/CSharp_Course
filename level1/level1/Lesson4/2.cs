using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp42
{
    class Program
    {
        static void Main(string[] args)
        {

            string s = "int ";
            for (int i = 0; i < 1000; i++)
            {
                s += $"a{i}, ";
                if (i % 100 == 0) s += "\n";
            }
            Console.WriteLine(s);

            //string s = "123";
            //var r = MyTryParse(s);
            //int.TryParse
            //Console.WriteLine(r);
            //Console.WriteLine("ку-ку");
        }

        private static int MyTryParse(string s)
        {

            try
            {
                return Convert.ToInt32(s);
            }
            catch
            {
                return 0;
            }

            Console.WriteLine("выполнено");

        }
    }
}
