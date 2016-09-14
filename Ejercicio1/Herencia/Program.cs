using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Factura miFactura = new Factura(100);
            FacturaA miFacturaA = new FacturaA(21,miFactura);
            FacturaAPagada miFacturaAPagada = new FacturaAPagada("hoy",miFacturaA);
            THE_Remito miRemito = new THE_Remito(666);
            List<Documento> misDocumentos = new List<Documento>();

            misDocumentos.Add(miFactura);
            misDocumentos.Add(miRemito);
            misDocumentos.Add(miFacturaA);
            misDocumentos.Add(miFacturaAPagada);

            foreach (Documento item in misDocumentos)
            {
                item.Mostrar();
            }

            Console.ReadKey();
        }
    }
}
