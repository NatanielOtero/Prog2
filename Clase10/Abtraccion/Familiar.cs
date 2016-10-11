using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abtraccion
{
    public class Familiar:Auto
    {
        public Familiar(string patente)
            : base(patente)
        {
 
        }
        public override float CalcularCosto()
        {
            return 100f;
        }

        public override float calcularCosto
        {
            get
            {
                return base.cantidadPuertas;
            }
            set
            {
                base.cantidadPuertas = 2.55F;
            }
        }
    }
}
