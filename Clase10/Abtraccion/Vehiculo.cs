using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abtraccion
{
    public abstract class Vehiculo
    {
        public string patente;

        public Vehiculo(string paten)
        {
            this.patente = paten;
        }

        public virtual string MostrarDatos()
        {
            return this.patente;
        }
        public abstract float CalcularCosto();
        public abstract float calcularCosto
        {
            get;
            set;
        }

        

        /*public abstract float Calcular
        {
           set;
           
        }*/
        
        
            
        


        public override string ToString()
        {

            return this.patente;
        }
    }
}
