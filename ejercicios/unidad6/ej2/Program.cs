using System;

namespace ej2
{
    class Program
    {
        //2. Se dispone de una lista de 5 listas de números enteros separados entre ellos por ceros.
        // Se pide determinar e informar:
        //*El número de grupo con mayor porcentaje de números impares respecto al total de números que forman el grupo.
        //*Informar cuántos grupos están formados por todos números ordenados de mayor a menor.
        static void Main(string[] args)
        {
            int
                n,
                prommax = 0,
                grupomax = 0,
                grupo = 0,
                contnum,
                min,
                bandord,
                contord = 0,
                contimp;

            for (int x = 0; x < 5; x++)
            {
                int promedio;
                contnum = 0;
                contimp = 0;
                bandord = 1;
                Console.Write("numero: ");
                n = int.Parse(Console.ReadLine());
                min = n;
                grupo++;
                while (n != 0)
                {
                    contnum++;
                    if (n % 2 != 0)
                    {
                        contimp++;
                    }
                    if (n < min)
                        min = n;
                    else
                        bandord = 0;
                   
                    }
                    Console.Write("numero: ");
                    n = int.Parse(Console.ReadLine());
                } //fin while
                promedio = contimp / contnum;
                if (promedio > prommax)
                {
                    prommax = promedio;
                    grupomax = grupo;
                }
                 if (bandord == 1)
                    {
                        contord++;
            } //fin for
            Console.WriteLine("grupo maximo promedio: " + grupomax);
            Console.Write("grupos ordenados: " + contord);
        }
    }
}
