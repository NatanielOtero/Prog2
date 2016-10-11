using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abtraccion
{
    public class Gestion
    {

        public static float mostrarIMP(IAFIP algo)
        {
            return algo.retornarImpuesto();
        }
    }
}
