using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    public class Rueda
    {
        public string _marca;
        public float _tamaño;

        public Rueda() //Constructor por defecto
        {
            this._marca = "Sin marca";

        }
        public void MostrarRueda()
        {
            Console.WriteLine("El tamaño es:" + _tamaño);
        }
    }
}
