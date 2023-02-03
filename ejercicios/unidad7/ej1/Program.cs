using System;

namespace ej1
{
    class Program
    {
        // Hacer un programa que solicite 10 números enteros y los guarde en un vector. 
        //Luego recorrer los elementos y determinar e informar cuál es el valor máximo y su posición dentro del vector
        static void Main(string[] args)
        {
            int
                n,
                max,
                pos;
            int[] v = new int[10];
            for (int x = 0; x < 10; x++)
            {
                Console.Write("ingrese numero: ");
                n = int.Parse(Console.ReadLine());
                v[x] = n;
            } //fin de carga del vector
            max = v[0];
            pos = 0;

            for (int x = 0; x < 10; x++)
            {
                if (v[x] > max)
                {
                    max = v[x];
                    pos = x + 1;
                }
            }
            Console
                .Write("el valor maximo es " + max + " en la posicion " + pos);
        }
    }
}
