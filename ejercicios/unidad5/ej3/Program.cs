using System;

namespace ej3
{
    class Program
    {
        static void Main(string[] args)
        {
            //3. Hacer un programa que solicite 20 edades y luego calcule el promedio de edad de aquellas personas mayores a 18 años.

            float edad,prom,cont=0,acum=0;
            for (int x = 0; x < 5; x++)
            {
                Console.Write("ingrese edad: ");
                edad=float.Parse(Console.ReadLine());
                if(edad>=18){
                acum+=edad;
                cont++;
                }
            }
            prom=acum/cont;
            Console.Write("promedio: "+prom.ToString("0.00"));

        }
    }
}
