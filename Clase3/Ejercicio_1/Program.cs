using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Rueda otra;
            Tiempo tiempo;
            Carrera carrera;

            otra = new Rueda("Gomas",3);
            tiempo = new Tiempo(10);

            tiempo  = tiempo + 10;
            
            carrera = new Carrera();
            carrera.MostrarCarrera();
            otra.MostrarRueda();
            Console.ReadKey();
           
            

            
            
        }
    }
}
