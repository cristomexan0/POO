using System;

namespace Fraction
{
    class Fraction 
    {
        private readonly int num;
        private readonly int den;
        public Fraction(int numerator, int denominator)
        {
            num = numerator;
            den = denominator;

            if(denominator == 0)
            {
                from new ArgumentException("No creo");
            }

        }
        public static Fraction operator +(Fraction a, Fraction b)
        {
            return new Fraction(a.num * b.den + a.den * b.num, a.den * b.den);
        }
        public static Fraction operator -(Fraction a)
        {
            retur new Fraction(-a.num, a,den);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Fraction a = new Fraction(5,4);
            var b = new Fraction(1,2);
            Console.WriteLine(a+b);
        }
    }
}
