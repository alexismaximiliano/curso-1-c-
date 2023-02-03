using System;

namespace ej3
{
    class Program
    { 
        //Hacer un programa que solicite una cadena de caracteres y dos caracteres sueltos (tres ingresos).
        // El programa deberá generar una cadena donde todas las ocurrencias del primer carácter dado hayan 
        //sido reemplazadas por el segundo. Mostrar el resultado en pantalla. Ejemplo:
            //CADENA FUENTE: “La mar estaba serena"
            //CARÁCTER 1: ‘a’ CARÁCTER 2: ‘i’
            //CADENA RESULTADO: “Li mir estibi sereni"
        static void Main(string[] args)
        {
            string frase;
            char letra1,letra2;
            Console.Write("ingrese la frase: ");
            frase=Console.ReadLine();
            Console.Write("letra a cambiar:");
            letra1=char.Parse(Console.ReadLine());
            Console.Write("letra nueva: ");
            letra2=char.Parse(Console.ReadLine());

            frase=frase.Replace(letra1,letra2);

            Console.WriteLine("la frase nueva es: ");
            Console.Write(frase);
        }
    }
}
