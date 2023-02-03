using System;

namespace ej2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa para ingresar un número y luego se emita un cartel por pantalla “Positivo”

            //si el número es mayor a cero, “Negativo” si el número es menor a cero o “Cero” si el número

            //es igual a cero.
            int n;
            Console.WriteLine("ingrese numero");
            n = int.Parse(Console.ReadLine());
            if (n == 0)
                Console.WriteLine("cero");
            else if (n > 0)
                Console.WriteLine("positivo");
            else
                Console.WriteLine("negativo");
        }
    }
}
