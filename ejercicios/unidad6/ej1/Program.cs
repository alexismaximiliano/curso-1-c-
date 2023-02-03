using System;

namespace ej1
{
    class Program
    {
        //1. Hacer un programa para ingresar 10 números. El mismo debe analizar y mostrar por pantalla

        //cuántos de esos números son primos.
        static void Main(string[] args)
        {
            int
                n,
                prim = 0;
                
            for (int x = 0; x < 5; x++)
            {
                int cont = 0;
                Console.Write("ingrese numero:");
                n = int.Parse(Console.ReadLine());
                for (int y = 1; y <= n; y++)
                {
                    if (n % y == 0) 
                        {cont++;}
                }
                if (cont == 2) 
                    {prim++;}
            }
            Console.Write("contador de primos: " + prim);
        }
    }
}
