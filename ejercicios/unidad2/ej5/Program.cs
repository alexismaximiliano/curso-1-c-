using System;

namespace ej5
{
    class Program
    {
        static void Main(string[] args)
        {
            //5. Hacer un programa para ingresar por teclado las tres notas de exámenes
            //de un alumno y luego calcule y emita por pantalla el promedio final.
            float
                n1,
                n2,
                n3;
            float prom;
            Console.WriteLine("nota 1:");
            n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("nota 2:");
            n2 = float.Parse(Console.ReadLine());
            Console.WriteLine("nota 3:");
            n3 = float.Parse(Console.ReadLine());
            prom = (n1 + n2 + n3) / 3;
            Console.WriteLine("promedio:" + prom.ToString("0.0"));
        }
    }
}
