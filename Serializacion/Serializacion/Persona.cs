using System;
using System.Xml;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Serializacion
{
    [XmlInclude(typeof(Alumno))]
    public class Persona : ISerializable2016
    {
        public string Nombre;

        public Persona()
        {
 
        }
        public Persona(string nombre):this()
        {
            this.Nombre = nombre;
        }



        bool ISerializable2016.serializar()
        {
           return Serializador.SerializarPersona(this);
            
        }


        bool ISerializable2016.Deserializar()
        {
            bool flag = false;
            try
            {
                Persona aux = Serializador.DeserializarPersona();
                flag = true;

            }
            catch (Exception)
            {
                flag = false;
                throw;
            }
            return flag;
        }
    }
}
