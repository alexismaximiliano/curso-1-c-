using System;

namespace ej1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que solicite el ingreso de dos números y luego calcular:
            //La resta si el primero es mayor que el segundo.
            //La suma si son iguales.
            //El producto si el primero es menor.
            //Se deberá emitir un cartel por pantalla con el resultado correspondiente.
            int
                a,
                b,
                r;

            Console.Write("numero: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("numero: ");
            b = int.Parse(Console.ReadLine());

            if (a > b)
                Console.Write(r = a - b);
            else if (a == b)
                Console.Write(a + b);
            else
                Console.Write(a * b);
        } 
    }
}
