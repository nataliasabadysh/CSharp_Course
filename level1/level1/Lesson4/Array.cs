using System;
namespace level1.Lesson4
{
    public class Array2
    {
        static void Maine(string[] args)
        {
            int[] array = new int[1000];
       

            int n = Convert.ToInt32(Console.ReadLine());

            double[] train = new double[n];


            Random r = new Random();


            foreach (double coach in train)
            {
                Console.WriteLine($"{coach,5}^2 = {coach * coach}");
            }

            for (int coach = 0; coach < train.Length; coach++)
            {
                {
                    train[coach] = r.Next(1, 100); // FROM 1 TO 1000
                Console.WriteLine($"{train[coach],5}^2 = {train[coach] * train[coach]}");
            }

                // added value to Array

            Array.Resize(ref train, train.Length + 10);

                Array.Sort(train);



        }

    }
}
