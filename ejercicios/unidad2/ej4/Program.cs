using System;

namespace ej4
{
    class Program
    {
        static void Main(string[] args)
        {
            //4. Una casa de computación paga a sus empleados un sueldo fijo de ARS15000
            //más una comisión del 5% sobre el total facturado por cada empleado.
            //Hacer un programa para ingresar el total facturado por un empleado y que luego calcule
            //y emita por pantalla el sueldo total a cobrar por el mismo.
            float
                tf,
                st;
                const float sueldo=15000;
                const float comisión=0.05F;
            Console.WriteLine("total facturado:");
            tf = float.Parse(Console.ReadLine());
            tf = tf * comisión; //0.05F poner numero float
            st = sueldo + tf;
            Console.WriteLine("suelto total:" + st);
        }
    }
}
