using System;
namespace level1
{
    public class Lesson1
    {
      
            string fName = Console.ReadLine();
            int age = Convert.ToInt32(Console.ReadLine());
            uint salary = Convert.ToUInt32(Console.ReadLine());


            Console.WriteLine("Your name is ? ");
            Console.WriteLine("What is your age ? ");
            Console.WriteLine("What is expectation of salary? ");



            Console.WriteLine("Name: {0} Age: {1}, Getting: {2}", fName, age, salary);

            Console.WriteLine("Name" + fName + "Age:" + age + "getting paid" + salary);  // concat string,  **  bed practises to max string and int

            Console.WriteLine("Name" + fName + "Age:" + age.ToString() + "getting paid" + salary.ToString()); // or Convert.ToString()


            string text = String.Format("Name: {0}, Age: {1}, Salary: {2}", fName, age, salary);
            Console.WriteLine(text);



            // I = W/(h*h

            Console.Write("What is your wight ?");
            int w = Convert.ToInt32(Console.ReadLine());

            Console.Write("What is your hight ?");
            int h = Convert.ToInt32(Console.ReadLine());

            //double I = w /(h * h);
            //double I = (double) w / (h * h);

            double I = w / Math.Pow(h, 2);

            Console.WriteLine($"I = {I} ");

            // 3
            Console.Write("x1 = "); double x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("x2 = "); double x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y1 = "); double y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y2 = "); double y2 = Convert.ToDouble(Console.ReadLine());

            double r = Distance(x1, y1, x2, y2);

            Console.WriteLine($"r = {r}");
            Console.WriteLine(r.ToString("#.##")); // #.### ### ### (2, 345 678 89



            // 4

            int a = 1;
            int b = 2;

            //int c = a;
            //a = b;
            //b = c;


            a = a + b;
            b = a - b;
            a = a - b;

            // ^

            Console.WriteLine($"a = {a}, b = {b}"); // a = 1, b = 2  and  a = 2 b = 1


            // 5

            string name = Console.ReadLine();
            string lastName = Console.ReadLine();

            // 1
            Console.WriteLine("What is your name ? ");
            Console.WriteLine("What is your last name ? ");
            // 2
            string txt = $"{name}{lastName}";
            Console.SetCursorPosition(Console.WindowWidth / 2 - txt.Length / 2, Console.WindowHeight / 2);

            // 3
            Print(txt, Console.WindowWidth / 2, Console.WindowHeight / 2);

        }

        private static void Print(string txt, int left, int top)
        {
            Console.SetCursorPosition(left - txt.Length / 2, top);
            Console.WriteLine(txt);
        }



        private static double Distance(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }


        // call method from another project

           Library.Pause();
    
}
