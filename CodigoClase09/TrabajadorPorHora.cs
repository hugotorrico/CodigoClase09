using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigoClase09
{
    public class TrabajadorPorHora : Trabajador
    {
        public int HorasTrabajadas { get; set; }
        public decimal PrecioHora { get; set; }

        public override decimal CalcularSueldo()
        {
            decimal sueldo = HorasTrabajadas * PrecioHora;
            // Aplica un descuento del 10% al sueldo por hora
            sueldo -= sueldo * 0.1m;
            return sueldo;
        }

        public override void MostrarInformacion()
        {          
            //Base: Hace referencia a la clase
            base.MostrarInformacion();            
            Console.WriteLine($"Horas Trabajadas: {HorasTrabajadas}");
            Console.WriteLine($"Precio por Hora: ${PrecioHora}");
        }
    }
}
