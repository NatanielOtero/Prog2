using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class Documento
    {
        public int Numero;
        public  string fecha;
        public int _numeroDeControl;

        public Documento(int numero)
        {
            this.Numero = numero;
 
        }
        public Documento(int numero, string fecha, int numerocontrol):this(numero)    
        {
            this.fecha = fecha;
            this._numeroDeControl = numerocontrol;
        }
        public void Mostrar()
        {
            Console.WriteLine(this.Numero);
        }

    }
}
