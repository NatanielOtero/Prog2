using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abtraccion
{
    public class Deportivo:Auto,IAFIP
    {
        public Deportivo(string paten)
            : base(paten)
        { 

        }
        public override float CalcularCosto()
        {
            return 150f;
        }
        public float retornarImpuesto()
        {
            return 15f;
        }
    }
}
