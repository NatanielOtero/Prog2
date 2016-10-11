using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abtraccion
{
    class Comercial:Avion
    {
        public Comercial(string patente)
            : base(patente)
        {
 
        }

        public  float retornarImpuesto()
        {
            return 15f;
        }

    }
}
