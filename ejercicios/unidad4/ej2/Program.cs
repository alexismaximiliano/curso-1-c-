using System;

namespace ej2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Un importante negocio de desinfectante líquido realiza descuentos dependiendo de la
            //cantidad de litros vendidos según la siguiente escala:

            //Si vende menos de 100 litros, no hay descuento.
            //Si vende entre 101 y 300 litros, el descuento es del 10%.
            //Si vende entre 301 y 500 litros, el descuento es del 15%.
            //Finalmente, si la venta es de más de 500 litros, el descuento es del 25%
            
            //Hacer un programa que solicite el ingreso del importe total de la venta y la cantidad de
            //litros vendidos y calcule y emita el importe con el descuento  aplicado..
            float
                imp,
                lts,
                tt;

            Console.Write("importe parcial: ");
            imp = float.Parse(Console.ReadLine());
            Console.Write("litros: ");
            lts = float.Parse(Console.ReadLine());

            if (lts > 500)
                tt = imp * 0.75F; //imp*=0.75F sin usar tt
            else if (lts > 301)
                tt = imp * 0.85F;
            else if (lts > 101)
                tt = imp * 0.90F;
            else
                tt = imp;
            Console.Write("importe total:" + tt);
        }
    }
}
