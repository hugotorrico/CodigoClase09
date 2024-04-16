using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Perro : IAnimal
    {
        public void HacerSonido()
        {
            Console.WriteLine("Guau guau");
        }
    }
}
