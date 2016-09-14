using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class THE_Remito:Documento
    {
        public string Fecha;

        public THE_Remito(int numero):base(numero)
        {
            base.Numero = numero;
 
        }
        
    }


 }

