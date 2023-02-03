using System;

namespace ej3
{
    class Program
    {
        static void Main(string[] args)      
        // Hacer un programa para recibir listas de números positivos que están separadas entre sí por un cero.
        // El fin de la carga se notifica con un número negativo. 
        // Luego mostrar cuántos números tiene cada lista.
        {
            int n=1,cont,lista=0;
            
            while (n >= 0)
            {
                Console.Write("numero: ");
                n = int.Parse(Console.ReadLine());
                cont=0;
                lista++;
                while (n > 0)
                {
                    cont++;
                    Console.Write("numero: ");
                    n = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("la lista "+lista+" tiene "+cont+" numeros");
            }
        }
    }
}
