using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesAbstractas
{
    public abstract class Figura
    {
        public double Area { get; set; }
        public abstract double CalcularArea();//Firma del método

    }
}
