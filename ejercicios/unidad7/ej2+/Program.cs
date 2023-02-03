using System;

namespace ej2_
{
    class Program
    {   //2. Hacer un programa que solicite 10  números enteros y los guarde en un vector. 
        //Luego recorrer ese vector para calcular el promedio. Mostrar por pantalla los valores que son mayores al promedio.


        static void Main(string[] args)
        {
            int [] v=new int [10];
            int n,acum,prom,cont;
            for (int x = 0; x < 10; x++)
            {
                Console.Write("ingrese numero: ");
                n=int.Parse(Console.ReadLine());
                v[x]=n;
            } 
            acum=0;
            cont=0;
            for (int x = 0; x < 10; x++)
            {
                acum+=v[x];
                cont++;
            }  
            prom=acum/cont;
            Console.WriteLine("mayores al promedio: ");
            for (int x = 0; x < 10; x++)
            {
                if(v[x]>prom)
                    Console.WriteLine(+v[x]);
            }        
        }
    }
}
