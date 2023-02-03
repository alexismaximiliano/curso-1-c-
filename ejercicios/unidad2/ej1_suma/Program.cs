using System;

namespace ej1_suma
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1,n2,r;
            Console.WriteLine("n1:");
            n1=int.Parse(Console.ReadLine());//.parse convertir una variable en otra
            Console.WriteLine("n2:");
            n2=int.Parse(Console.ReadLine());
            r=n1+n2;
            Console.WriteLine("resultado:"+r);//+r concatenar variables a impresion
        }
    }
}
