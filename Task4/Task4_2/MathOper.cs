using System;

using System.Numerics;


namespace Task4_2
{
    public static class MathOper
    {

        public static BigInteger ProdTree(int p, int r)
        {
            if (p > r)
                return 1;
            if (p == r)
                return p;
            if (r - p == 1)
                return (BigInteger)p * r;
            int m = (p + r) / 2;
            return ProdTree(p, m) * ProdTree(m + 1, r);
        }

        public static BigInteger FactTree(int n)
        {
            if (n < 0)
               throw new Exception();
            if (n == 0)
                return 1;
            if (n == 1 || n == 2)
                return n;
            return ProdTree(2, n);
        }

        public static double CountFibonacci (double n)
        {
            if (n < 0)
                throw new Exception();
            double numb = (Math.Pow((1 + Math.Sqrt(5)) / 2, n) - (Math.Pow((1 - Math.Sqrt(5)) / 2, n))) / Math.Sqrt(5);
            return numb;            
        }



    }
}
