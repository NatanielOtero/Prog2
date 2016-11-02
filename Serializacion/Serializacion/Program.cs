using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Serializacion
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona per = new Persona("Jorge");
            ((ISerializable2016)per).serializar();
            Persona per2 = //Serializador.DeserializarPersona();
            ((ISerializable2016)per).Deserializar();
            Console.WriteLine(per2.Nombre);
            Console.ReadKey();
                        
            /*List<Persona> personas = new List<Persona>();
            personas.Add(new Persona("Jony"));
            personas.Add(new Persona("Brayam"));            
            Alumno al = new Alumno("Brandom",1);
            personas.Add(al);
            Serializador.SerializarListadoPersonas(personas);            
            Aula au = new Aula(5,per,personas,"Aulita");                    
            Serializador.SerializarAula(au);*/
        }
    }
}
