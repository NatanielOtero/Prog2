using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class FacturaAPagada:FacturaA
    {
        public string fechadepago;

        public FacturaAPagada(string fechaDePago, FacturaA facA):base(facA.IVA,facA)
        {
            this.fechadepago = fechaDePago;
            
        }
    }
}
