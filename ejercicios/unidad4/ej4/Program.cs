using System;

namespace ej4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa para ingresar tres números y emitir un cartel aclaratorio si la suma de los dos primeros
            // es mayor al producto del segundo con el tercero.
            int
                a,
                b,
                c,
                s,
                p;
            Console.Write("numero 1: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("numero 2: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("numero 3: ");
            c = int.Parse(Console.ReadLine());

            s = a + b;
            p = b * c;
            if (s > p)
                Console.Write("es mayor la suma");
            else
                Console.Write("es mayor el producto");
        }
    }
}
