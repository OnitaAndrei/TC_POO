using NrComplexDatatype;
using System;

namespace ComplexNrDatatype
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                NrComplex NrComplex1 = new NrComplex();
                NrComplex NrComplex2 = new NrComplex(5, -4);
                int NrReal = 2;
                Console.WriteLine($"{NrComplex1} + {NrComplex2} = {NrComplex1 + NrComplex2}");
                Console.WriteLine($"{NrComplex1} - {NrComplex2} = {NrComplex1 - NrComplex2}");
                Console.WriteLine($"{NrComplex1} * {NrComplex2} = {NrComplex1 * NrComplex2}");
                Console.WriteLine($"{NrComplex1} ^ {NrReal} = {NrComplex1 ^ NrReal}");
                Console.WriteLine($"Forma trigonometrica: " + 
                    $"{NrComplex1.FormaTrigonometrica()}");
                Console.WriteLine($"Ridicarea la putere in forma trigonometrica {NrReal}: " + 
                    $"{NrComplex1.RidicareaLaPutereInFormaTrigonometrica(NrReal)}");
            }
        }
    }
}
