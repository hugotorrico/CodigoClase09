using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesAbstractas
{
    public class Gato : Animal
    {
        public override void HacerSonido()//Implementación del método
        {
            Console.WriteLine("Miau mmiau");
        }
        public override void Comer()//Implementación del método
        {
            Console.WriteLine("Comida Gatos");
        }

    }
}
