using System;

namespace ej4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,est=0;
            Console.Write("ingrese numero: ");
            n=int.Parse(Console.ReadLine());
            positivonegativocero(n,ref est);
            Console.Write("el numero "+n+" tiene estado "+est);
        }
        static void positivonegativocero(int valor, ref int variable){
            if(valor >0)
                variable=1;
                else if(valor<0)
                    variable=-1;
                    else
                    variable=0;
        }
    }
}
//. Hacer una función de tipo void (porque no va a devolver nada) llamada “positivoNegativoCero” 
/*que reciba un número por valor y una variable por referencia. 
Que analice el número y escriba variable recibida por referencia con:

    /*a. 1 si el número es positivo.
    b. -1 si el número es negativo.
    c. 0 si el número es cero.*/

