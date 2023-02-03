using System;

namespace ej3
{
    class Program
    {
        static void Main(string[] args)
        {
            //3. Hacer un programa que permita ingresar los kilómetros existentes entre dos ciudades
            //y la velocidad promedio de un vehículo. Calcular y emitir por pantalla el tiempo aproximado
            //que demandará llegar de un punto a otro teniendo en cuenta los datos ingresados.
            float
                km,
                vp,
                tt;

            Console.WriteLine("kilometros:");
            km = float.Parse(Console.ReadLine());
            Console.WriteLine("velocidad:");
            vp = float.Parse(Console.ReadLine());
            tt = km / vp;
            Console.WriteLine("tiempo:" + tt.ToString("0.00"));//ToString("0.00") redondea decimales
        }
    }
}
