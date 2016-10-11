using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abtraccion
{
    public class Avion:Vehiculo,IAFIP
    {
        public override float CalcularCosto()
        {
            return 1500f;
        }
        public Avion(string paten)
            : base(paten)
        {
 
        }
        public  float retornarImpuesto()
        {
            return 15f;
        }

        
    }
}
