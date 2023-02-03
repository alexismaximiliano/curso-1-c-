using System;

namespace ej3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Una casa de video juegos otorga un descuento dependiendo del importe de la compra
            //realizada según los siguientes valores:

            //Si el importe es menor a ARS 1000, no hay descuento.
            //Si el importe es ARS 1000 o más pero menor a ARS 5000, aplica un descuento del 10%.
            //Si el importe es ARS 5000 o más, aplica un descuento del 18%.
            
            //Hacer un programa para ingresar un importe de venta y luego muestre por pantalla el importe 
            //final con el descuento que corresponda.

            float iv,it;
            const float DM=0.18F;
            const float dm=0.10F;

            Console.WriteLine("ingrese importe de venta:");
            iv=float.Parse(Console.ReadLine());
            if(iv>=5000)
                it=iv-(iv*DM);//tambien puede ser iv*0.90F y *0.82F  queda it=iv*0.90F
                else if(iv>=1000)
                it=iv-(iv*dm);
                else
                it=iv;

            Console.WriteLine("importe final:"+it);
            
        }
    }
}
