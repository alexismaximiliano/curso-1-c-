using System;

namespace TPFinal_Cañete
{
    class Program
    {
        static void Main(string[] args)
        {
            int
                n,
                bmayor = 0,
                bmenor = 0,
                cont = 0,
                r,
                p,
                max=0,
                min=0;
            Console.Write("ingrese numero: ");
            n = int.Parse(Console.ReadLine());

            while (n != 0)
            {
                r = par(n);
                if (r == 1)
                {
                    if (bmayor == 0)
                    {
                        max = n;
                        bmayor = 1;
                    }
                    else if (n > max) 
                        max = n;
                }
                else
                    cont++;
                p = primo(n);
                if (p==1)
                {
                    if (bmenor == 0)
                    {
                        min = n;
                        bmenor = 1;
                    }
                    else if (n < min) 
                        min = n;
                }
                Console.Write("ingrese numero: ");
                n = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("el mayor de los numeros pares es " + max);
            Console.WriteLine("hay " + cont + " numeros impares");
            Console.WriteLine("el menor de los numeros primos es " + min);
        }

        static int par(int a)
        {
            if (a % 2 == 0)
                return 1;
            else
                return 0;
        }

        static int primo(int b)
        {
            int cont = 0;
            for (int x = 1; x <= b; x++)
            {
                if (b % x == 0) 
                    cont++;
            }
            if (cont == 2)
                return 1;
            else
                return 0;
        }
    }
}
// Hacer un programa que permita ingresar una lista de números que corta cuando se ingresa un cero. A partir de dichos datos informar:

// a. El mayor de los números pares.
// b. La cantidad de números impares.
// c. El menor de los números primos.

// Nota: evaluar el uso de una función que analice si un número dado es primo o no y que devuelva true o false según corresponda.
