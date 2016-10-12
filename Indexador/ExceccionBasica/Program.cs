using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceccionBasica
{
    class Program
    {
        static void Main(string[] args)
        {


            try
            {
                lanzarError();
                operar();

            }
            catch (FormatException x)
            {
                Console.Write(x.Message);

            }
            catch (DivideByZeroException x)
            {
                Console.Write(x.Message);

            }
            catch (Exception x)
            {
                Console.Write(x.Message);

            }
            finally
            {
                Console.WriteLine(" Dios te odia");
            }
            Console.ReadKey();
        }

        public static void operar()
        {
          

            try
            {
                string dato;
                int numero;

                dato = Console.ReadLine();
                numero = int.Parse(dato);
                numero = numero / numero;
            }
            catch (Exception x)
            {
                //operaciones para guardar informacion de la exception
                throw new Exception("Se quedo sin internet");
                
            }
           
        }
        public static void lanzarError()
        {
            throw new Exception("No tenes ram");
        }
    }
}
