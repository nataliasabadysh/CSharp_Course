using System;
namespace level1.Lesson3_methods
{
    public class Example7
    {
        class Worker
        {
            public const int SALARY = 1000; 
            public readonly int AGE = 25;
            public static int t = 10; // var - we can chenge

            // Constructor
            public Worker(string Name, int Age, int Salary)
            {
                this.Name = Name;
                this.Age = Age;
                this.Salary = Salary;
            }

            public string Name { get; set; }
            public int Age { get; set; }
            public int Salary { get; set; }
        }


        static void Main(string[] args)
        {
            // Examplar class 
            Worker w = new Worker("Nata", 20, 200);
            Worker.AGE = 123; // Error -> const for readonly 
            Worker.t = 34;     // static

        }
    }
}
