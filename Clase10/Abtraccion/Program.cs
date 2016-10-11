using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abtraccion
{
    class Program
    {
        static void Main(string[] args)
        {
            Familiar f1 = new Familiar("familiar");
            Deportivo d1 = new Deportivo("Deportivo");
            Carreta c1 = new Carreta("caballo");
            Avion a1 = new Avion("osama");
            Comercial tuvieja = new Comercial("Public");

            List<Vehiculo> miLista = new List<Vehiculo>();
            List<IAFIP> listaAfip = new List<IAFIP>();


            f1.CantidadPuertas = 4;
            d1.CantidadPuertas = 2;

            miLista.Add(f1);
            miLista.Add(d1);
            miLista.Add(c1);
            miLista.Add(a1);

            listaAfip.Add(d1);
            listaAfip.Add(a1);
            listaAfip.Add(tuvieja);

            foreach (Vehiculo item in miLista)
            {
              
                Console.WriteLine(item.MostrarDatos());
                Console.WriteLine(item.calcularCosto);
                
            }
            foreach (IAFIP item in listaAfip)
            {
                
                Console.WriteLine("Impuestos");                
                Console.WriteLine(Gestion.mostrarIMP(item));

            }
            Console.ReadLine();
            
                
            

            /*uto car = new Auto("ABC123");
            car.CantidadPuertas = 6;

            
            Console.WriteLine(car.MostrarDatos());
            Console.ReadLine();*/


        }
    }
}
