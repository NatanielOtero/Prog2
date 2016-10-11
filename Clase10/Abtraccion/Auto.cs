using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abtraccion
{
    public abstract class Auto:Vehiculo
    {


        public int cantidadPuertas;

        public Auto(string paten):base(paten)
        {
 
        }

        public int CantidadPuertas
        {
            set
            {
                this.cantidadPuertas = value;
            }

        }
       
        /*public override float CalcularCosto()
        {
            return 15f;
        }*/
        

        public override string MostrarDatos()
        {
            StringBuilder sn = new StringBuilder();
            sn.AppendLine(base.MostrarDatos());
            sn.AppendLine(this.cantidadPuertas.ToString());
            return sn.ToString();
        }
    }
}
