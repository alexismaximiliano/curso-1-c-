using System;

namespace ej5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa para ingresar 4 números.
            // Luego analizar e informar por pantalla si los mismos se encuentran ordenados de forma decreciente .
            int
                a,
                b,
                c,
                d;
            Console.Write("numero 1: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("numero 2: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("numero 3:");
            c = int.Parse(Console.ReadLine());
            Console.Write("numero 4: ");
            d = int.Parse(Console.ReadLine());

            if (a > b && b > c && c > d)
                Console.Write("estan ordenados");
            else
                Console.Write("no estan ordenados");
        }
    }
}
