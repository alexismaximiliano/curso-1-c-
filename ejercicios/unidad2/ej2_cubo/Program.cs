using System;

namespace ej2_cubo
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. Hacer un programa para solicitar por teclado un número y luego devolver su valor elevado al cubo.
            int
                n,
                r;
            Console.WriteLine("ingrese numero:");
            n = int.Parse(Console.ReadLine());
            r = n * n * n;
            Console.WriteLine("el cubo es:" + r);
        }
    }
}
