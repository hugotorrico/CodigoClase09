using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Categoria : ITablasMaestras
    {
        public void Actualizar()
        {
            Console.WriteLine("Actualizar Categorias");
        }

        public void Eliminar()
        {
            Console.WriteLine("Eliminar Categorias");

        }

        public void Insertar()
        {
            Console.WriteLine("Insertar Categorias");
        }

        public void InsertarRango()
        {
            Console.WriteLine("Insertar Rango");
        }

        public void Listar()
        {
            Console.WriteLine("Listar Categorias");

        }
    }
}
