using System;



namespace level1.Lesson4
{
    class RationalNumbers
    {
        public int n;
        public int m;

        // Constructor  of class 
        public RationalNumbers(int M, int N)
        {
            this.m = M;
            this.n = N;
        }
        static public RationalNumbers Sum(RationalNumbers A, RationalNumbers B) {
            return new RationalNumbers(A.m * B.n, B.m * A.n);
        }
    }
}
 
