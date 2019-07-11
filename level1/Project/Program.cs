using System;
using level1;



namespace Project
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Your name is ? ");
            string fName = Console.ReadLine();

            Console.WriteLine("What is your age ? ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Name :{fName} Age: {age}"); // interpolation

            Console.WriteLine("Name: {0} Age: {1}", fName, age); 
            Console.WriteLine("Name" + fName +  "Age:" + age);  // concat string 

        }
    }
}
