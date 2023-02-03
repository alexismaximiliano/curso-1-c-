using System;

namespace ej3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Una importante marca de computadoras permite elegir cierta configuración del equipo a comprar.
            // Para ello existe la siguiente escala de precios:

            //              i5 (1)	    i7 (2)	    i9 (3)
            //8 RAM (1)	    USD 800	    USD 900	    USD 1200
            //16 RAM (2)	USD 900	    USD 1000	USD 1400
            //32 RAM (3)	USD 1000	USD 1400	USD 2000
           
            //Además, el equipo viene con un disco que permite almacenar 500 GB de información y que se puede
            // ampliar a 1 TB si así lo desea, lo cual tiene un costo  adicional de USD 300. Hacer un programa
             //que solicite la opción de procesador, la opción de memoria  RAM, y si extiende el disco o no
            //(ingresa 1 para extender y 0 para no extender) y calcule y emita por pantalla el monto de la máquina
            //seleccionada.
            int cpu,ram,hdd,tt=0;
            Console.Write("elija CPU: ");
            cpu=int.Parse(Console.ReadLine());
            Console.Write("elija RAM: ");
            ram=int.Parse(Console.ReadLine());
            Console.Write("ampliar disco?: ");
            hdd=int.Parse(Console.ReadLine());

            switch (cpu)
            {
                case 1:
                switch (ram)
                {
                    case 1:
                    tt=800;
                    break;
                    case 2:
                    tt=900;
                    break;
                    default:
                    tt=1000;
                    break;
                    
                }
                break;
                case 2:
                switch (ram)
                {
                    case 1:
                    tt =900;
                    break;
                    case 2:
                    tt=1000;
                    break;
                    default:
                    tt=1400;
                    break;
                }
                break;
                case 3:
                switch (ram) {
                    case 1:
                    tt=1200;
                    break;
                    case 2:
                    tt=1400;
                    break;
                    default:
                    tt=2000;
                    break;
                }
                break;
                
            }
            if (hdd==1)
                tt=tt+300;

            Console.Write("total:"+tt);  
                
                    
                
            
        }
    }
}
