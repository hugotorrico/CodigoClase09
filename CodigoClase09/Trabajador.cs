using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigoClase09
{
    public class Trabajador
    {
        public string Nombre { get; set; }
        public decimal SalarioBase { get; set; }

        public virtual decimal CalcularSueldo()
        {
            return SalarioBase;
        }

        public virtual void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Salario Base: ${SalarioBase}");
        }
    }
}
