using System;

namespace ej5
{
    class Program
    {
        static void Main(string[] args)
        {
            //5. Hacer un programa que solicite 20 números y luego emitir por pantalla el máximo de los números pares y
            //el mínimo de los números impares.
            int
                n,
                max =0,
                min=0,
                bp = 0,
                bi = 0;
            for (int x = 0; x < 5; x++)
            {
                Console.Write("ingrese numero:");
                n = int.Parse(Console.ReadLine());
                if (n % 2 == 0)
                {
                    if (bp == 0)
                    {
                        max = n;
                        bp = 1;
                    }
                    else if (n > max) max = n;
                }
                else if (bi == 0)
                {
                    min = n;
                    bi = 1;
                }
                else if (n < min) min = n;
            }
            Console.WriteLine("minimo: "+min);
            Console.WriteLine("maximo: "+max);
        }
    }
}
