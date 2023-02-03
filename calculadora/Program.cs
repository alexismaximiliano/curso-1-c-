using System;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarar variables
            //tipo de datos: int,float,char,bool
            int
                n1,
                n2,
                r;

            //pedir valores
            Console.WriteLine("ingrese numero 1:");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese numero 2:");
            n2 = int.Parse(Console.ReadLine());

            //realizar calculo
            r = n1 + n2;

            //emitir resultado
            Console.WriteLine("el resultado es:" + r);
        }
    }
}
