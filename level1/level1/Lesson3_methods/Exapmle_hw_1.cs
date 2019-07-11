using System;


namespace level1.Lesson3_methods
{
    class ComplexHW
    {

        private double im;


        double re;

        public ComplexHW() {
            im = 0;
            re = 0;
        }

        public ComplexHW(double _im, double re)
        {
            im = _im;
            this.re = re;
        }
        public ComplexHW Plus(ComplexHW x2)
        {
            ComplexHW x3 = new ComplexHW();

            x3.im = x2.im + im;
            x3.re = x2.re + re;
            return x3;
        }

        public ComplexHW Minus(ComplexHW x2)
        {
            ComplexHW x3 = new ComplexHW();

            x3.im = x2.im - im;
            x3.re = x2.re - re;
            return x3;
        }

        public ComplexHW Multy(ComplexHW complex)
        {
            return new ComplexHW(
                this.re * complex.im + this.im * complex.re,
                this.re * complex.re + this.im * complex.im
                );
        }

        public string ToString()
        {
            return re + "+ " + im + "i";
        }

        class Program
        {
            static void Maine(string[] args)
            {

                ComplexHW complex1 = new ComplexHW(2, 3);
                ComplexHW complex2 = new ComplexHW(2, 3);
                ComplexHW result = new ComplexHW();

                string o = Console.ReadLine();
                switch (o)
                {
                    case "+": result = complex1.Plus(complex2); break;
                    case "-": result = complex1.Minus(complex2); break;
                    case "*": result = complex1.Multy(complex2); break;
                }
            }

        }
    }
}
