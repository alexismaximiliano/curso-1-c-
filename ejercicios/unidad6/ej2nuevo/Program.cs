using System;

namespace ej2nuevo
{
    class Program
    {// Se dispone de una lista de 5 listas de números enteros separados entre ellos por ceros.
    // Se pide determinar e informar:

        //*El número de grupo con mayor porcentaje de números impares respecto al total de números que forman el grupo.
        //*Informar cuántos grupos están formados por todos números ordenados de mayor a menor.
        static void Main(string[] args)
        {
            int
                n,
                connumeros,
                conimpares,
                grupoimparesmaximo=0,
                min,
                conordenados = 0;
            double
                porcentajeimpares,
                porcentajemaximo = -1;
            bool banderaordenados;

            for (int x = 0; x < 5; x++)
            {
                connumeros = 0;
                conimpares = 0;
                banderaordenados = true;
                Console.Write("numero:");
                n = int.Parse(Console.ReadLine());
                min = n;
                while (n != 0)
                {
                    connumeros++;
                    if (n % 2 != 0) 
                        conimpares++;
                    if (n <= min)
                        min = n;
                    else
                        banderaordenados = false;
                    Console.Write("numero:");
                    n = int.Parse(Console.ReadLine());
                }// fin while
                porcentajeimpares = conimpares *100 / connumeros;
                if (porcentajeimpares > porcentajemaximo)
                {
                    porcentajemaximo = porcentajeimpares;
                    grupoimparesmaximo = x + 1;
                }
                if (banderaordenados) 
                    conordenados++;
            }//fin for
            Console.WriteLine("grupo mayor impar:" + grupoimparesmaximo);
            Console.WriteLine("grupos ordenados: " + conordenados);
        }
    }
}
