using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesAbstractas
{
    // Clase derivada de Animal
    public class Perro : Animal
    {
        // Implementación del método abstracto
        public override void HacerSonido()//Implementación del método
        {
            Console.WriteLine("Guau guau");
        }
        public override void Comer()//Implementación del método
        {
            Console.WriteLine("Comida Perros");
        }
    }

}
