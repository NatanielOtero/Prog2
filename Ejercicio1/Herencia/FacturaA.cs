using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class FacturaA:Factura
    {
        public int IVA;

        public FacturaA(int IVA, Factura fac):base(fac.Numero,fac.fecha,fac._numeroDeControl)
        {
            this.IVA = IVA;    
            
        }
    }
}
