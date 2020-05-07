using System;

namespace NrComplexDatatype
{
    class NrComplex
    {
        double a, b;
        public NrComplex()
        {
            Console.Write("Parte reala = ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Parte imaginara= ");
            b = Convert.ToDouble(Console.ReadLine());
        }

        public NrComplex(double a, double b = 0)
        {
            this.a = a;
            this.b = b;
        }

        double RoundNr(double nr)
        { return Math.Round(nr, 3, MidpointRounding.AwayFromZero); }

        public override string ToString()
        {
            if (b < 0)
                return $"({RoundNr(a)}{RoundNr(b)}i)";
            return $"({RoundNr(a)}+{RoundNr(b)}i)";
        }

        public static NrComplex operator +(NrComplex a, NrComplex b)
        { return new NrComplex(a.a + b.a, a.b + b.b); }

        public static NrComplex operator -(NrComplex a, NrComplex b)
        { return new NrComplex(a.a - b.a, a.b - b.b); }

        public static NrComplex operator *(NrComplex a, NrComplex b)
        { return new NrComplex(a.a * b.a - a.b * b.b, a.a * b.b + a.b * b.a); }

        public static NrComplex operator ^(NrComplex a, int putere)
        {
            NrComplex rez = a;
            for (int i = 0; i < putere - 1; i++)
            {
                rez *= a;
            }

            return rez;
        }
        public string RidicareaLaPutereInFormaTrigonometrica(int putere)
        {
            return $"{ RoundNr(Math.Pow(Math.Sqrt(Math.Pow(this.a, 2) + Math.Pow(this.b, 2)), putere))}" +
                $"*{new NrComplex(Math.Cos(Math.Atan(this.b / this.a) * putere), Math.Sin(Math.Atan(this.b / this.a) * putere))}";
        }
        public string FormaTrigonometrica()
        {
            return $"{ RoundNr(Math.Sqrt(Math.Pow(this.a, 2) + Math.Pow(this.b, 2)))}" +
                $"*{new NrComplex(Math.Cos(Math.Atan(this.b / this.a)), Math.Sin(Math.Atan(this.b / this.a)))}";
        }
    }
}
