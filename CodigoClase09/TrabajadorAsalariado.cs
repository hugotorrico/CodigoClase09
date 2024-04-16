using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigoClase09
{
    public class TrabajadorAsalariado : Trabajador
    {

      
        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine("Tipo: Asalariado");
        }
    }
}
