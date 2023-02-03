using System;

namespace ej4
{
    class Program
    {
        static void Main(string[] args)
        {
             //Hacer un programa para ingresar cuatro números distintos y luego mostrar por pantalla
             // el menor de ellos.

            int n1,n2,n3,n4;
            Console.WriteLine("ingrese numero:");
            n1=int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese numero:");    
            n2=int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese numero:");
            n3=int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese numero:");
            n4=int.Parse(Console.ReadLine());
            if(n1<n2 && n1<n3 && n1<n4)
            Console.WriteLine(n1+" es el menor");//tambien se puede usar con un acumulador MENOR
            else if(n2<n3 && n2<n4)
            Console.WriteLine(n2+" es el menor");//y comparar contra ese MENOR  
            else if(n3<n4)
            Console.WriteLine(n3+" es el menor"); //if(a<b) menor=a else menor=b
            else
            Console.WriteLine(n4+" es el menor"); //if(c<menor) menor=c    
                
            
        }
    }
}
