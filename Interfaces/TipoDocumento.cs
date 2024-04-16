using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class TipoDocumento : ITablasMaestras
    {
        public void Actualizar()
        {
            Console.WriteLine("Actualizar TipoDocumento");
        }

        public void Eliminar()
        {
            Console.WriteLine("Eliminar TipoDocumento");

        }

        public void Insertar()
        {
            Console.WriteLine("Insertar TipoDocumento");

        }

        public void InsertarRango()
        {
            Console.WriteLine("Insertar Rango");
        }

        public void Listar()
        {
            Console.WriteLine("Listar TipoDocumento");

        }
    }
}
