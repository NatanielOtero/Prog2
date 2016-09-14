using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class Factura:Documento
    {
        public float Importe;

        public Factura(int numero):base(numero)
        {
            base.Numero = numero;
 
        }
        public Factura(int numero,string fecha,int nrocontrol):base(numero,fecha,nrocontrol)
        {
          
        }
    }
}
