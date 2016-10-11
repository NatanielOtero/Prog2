using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abtraccion
{
    public class Carreta:Vehiculo
    {
        public override float CalcularCosto()
        {
            return 5f;
        }
        public Carreta(string paten)
            : base(paten)
        {
 
        }
    }
}
