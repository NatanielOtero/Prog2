using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    public class Tiempo
    {
        public int _cantidad;

        public Tiempo(int cantidad)
        {
            this._cantidad = cantidad; 
        }
        public static Tiempo operator + (Tiempo tiempoaux , int valor)
    {        
        
        tiempoaux._cantidad = tiempoaux._cantidad+valor;
            
            return tiempoaux;

    }
        
    }
}
