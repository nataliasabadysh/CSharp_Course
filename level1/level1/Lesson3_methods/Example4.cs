using System;
namespace level1.Lesson3_methods
{
    class Complex
    {
        public double re;
        public double im;

        public Complex(double Re, double Im)
        {
            re = Re;
            im = Im;
        }

        public Complex(double Arg)
        {
            re = Arg;
            im = Arg;
        }

        //public static Complex operator +(Complex Z1, Complex Z2)
        //{
        //    return new Complex(Z1.re + Z2.re, Z1.im + Z1.im);
        //}

        public Complex Sum(Complex Z1, Complex Z2)
        {
            return new Complex(Z1.re + Z2.re, Z1.im + Z1.im);
        }

        public Complex Sub(Complex Z1, Complex Z2)
        {
            return new Complex(Z1.re - Z2.re, Z1.im - Z1.im);
        }

        public string ToString()
        {
            return $"{re} + {im}i";
        }
    }

    // method A sdont have "static"


    class Point
    {
        public int x;
        public int y;
    }

    class Program
    {
        static void Main(string[] args)
        {

            Point point = new Point();

            point.x = 123;

            //Program p = new Program();
            //p.A();

            Complex z1 = new Complex(10, 29);
            Complex z2 = new Complex(10);
            Complex z3 = z1.Sum(z1, z2);

            // Complex z3 = z1+  z2;
        }

        void A() {
            return ;
        }
    }


}

