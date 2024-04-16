using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesAbstractas
{
    // Clase abstracta
    public abstract class Animal
    {
        // Método abstracto
        public abstract void HacerSonido();//Firma del método
        public abstract void Comer();//Firma del método
                                     // Método concreto
        public void Dormir()
        {
            Console.WriteLine("Zzz...");
        }
    }
}
