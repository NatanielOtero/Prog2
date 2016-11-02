using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Serializacion
{
    public class Aula
    {
        public int numero;
        private List<Persona> personas;
        public Persona profe;
        private string _nombreAula;

        public Aula()
        {
 
        }
        public Aula(int numero, Persona prof,List<Persona> persos,string nombreAula)
        {
            this.profe = prof;
            this.numero = numero;
            this.personas = persos;
            NombreAula = nombreAula;
        }
        public string NombreAula
        {
            set
            {
                this._nombreAula = value;
            }
            get
            {
                return this._nombreAula;
            }
        }
        public List<Persona> listaDePersonas
        {
            get { return this.personas; }
        }

    }
}
