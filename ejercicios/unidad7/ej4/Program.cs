using System;

namespace ej4
{
    class Program
    //Una empresa comercializa 15 tipos de artículos y por cada venta realizada genera un registro con los siguientes datos:
        //- Número de Artículo (1 a 15)
        //- Cantidad Vendida

    //Puede haber varios registros para el mismo artículo y el último se indica con número de artículo igual a 0.
        //Se pide determinar e informar:
            //a) El número de artículo que más se vendió en total.
            //b) Los números de artículos que no registraron ventas.
            //c) Cuantas unidades se vendieron del número de artículo 10.
    {
        static void Main(string[] args)
        { 
            int nroarticulo,cantidad;
            int [] totalcantidadvendida =new int [15];
            for (int x = 0; x < 14; x++)
            {
                totalcantidadvendida[x]=0;
            }
            Console.Write("ingrese nro de articulo: ");
            nroarticulo=int.Parse(Console.ReadLine());
            Console.Write("ingrese cantidad vendida: ");
            cantidad=int.Parse(Console.ReadLine());

            while (nroarticulo !=0)
            {
                totalcantidadvendida[nroarticulo -1]=+cantidad;

                Console.Write("ingrese nro de articulo: ");
            nroarticulo=int.Parse(Console.ReadLine());
            Console.Write("ingrese cantidad vendida: ");
            cantidad=int.Parse(Console.ReadLine());
            }
            //A
            int maxcantidad=totalcantidadvendida[0];
             
            for (int x = 0; x < 14; x++)
            {
                if (totalcantidadvendida[x]>maxcantidad)
                {
                    maxcantidad=totalcantidadvendida[x];
                    nroarticulo=x+1;
                }
            }
            Console.WriteLine("el producto "+nroarticulo+" fue el mas vendido con "+maxcantidad+" ventas");
            Console.WriteLine();
            //B
            for (int x = 0; x < 14; x++)
            {
                if (totalcantidadvendida[x]==0)
                {
                    Console.WriteLine("el producto "+(x+1)+" no tuvo ventas");
                   
                }
            } Console.WriteLine();
            //C
            Console.WriteLine("el producto 10 tuvo "+totalcantidadvendida[9]+ " ventas");
            Console.WriteLine();
    }
}
}