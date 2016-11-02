using System;
using System.Xml;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Serializacion
{
    public static class Serializador
    {
        public static bool SerializarPersona(Persona per)
        {
            //XmlTextWriter escritor;
           // XmlSerializer serializador;
            using (XmlTextWriter escritor = new XmlTextWriter("persona.xml",Encoding.UTF8))
            {
                try
                {
                    XmlSerializer serializador = new XmlSerializer(typeof(Persona));
                    serializador.Serialize(escritor, per);
                    return true;
                }
                catch (Exception)
                {

                    return false;
                }
                
            }
            
        }
        public static void SerializarListadoPersonas(List<Persona> personas)
        {
            //XmlTextWriter escritor;
            // XmlSerializer serializador;
            using (XmlTextWriter escritor = new XmlTextWriter("persona2.xml", Encoding.UTF8))
            {
                try
                {
                    XmlSerializer serializador = new XmlSerializer(typeof(List<Persona>));
                    serializador.Serialize(escritor, personas);
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
        public static void SerializarAula(Aula aula)
        {
            //XmlTextWriter escritor;
            // XmlSerializer serializador;
            using (XmlTextWriter escritor = new XmlTextWriter("Aula.xml", Encoding.UTF8))
            {
                try
                {
                    XmlSerializer serializador = new XmlSerializer(typeof(Aula));
                    serializador.Serialize(escritor, aula);
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
        public static bool SerializarGenerico(ISerializable2016 is2016)
        {
            return is2016.serializar();
        }
        public static bool DerializarGenerico(ISerializable2016 is2016)
        {
            return is2016.Deserializar();
        }
        public static Persona DeserializarPersona()
        {
            using (XmlTextReader lector = new XmlTextReader("persona.xml"))
            {
                try
                {
                    Persona pers = new Persona();
                    XmlSerializer serializar = new XmlSerializer(typeof(Persona));
                    pers = (Persona)serializar.Deserialize(lector);
                    return pers;
                }
                catch (Exception)
                {
                    
                    throw;
                }
               

            }
        }
    }
    

}
