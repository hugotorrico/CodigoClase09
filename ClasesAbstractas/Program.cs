using ClasesAbstractas;
using System;



class Program
{
    static void Main(string[] args)
    {

        Figura circulo = new Circulo { Radio = 10 };
        Figura rectangulo = new Rectangulo { Base = 10, Altura = 20 };


        Console.WriteLine("El area circulo es:");
        Console.WriteLine( circulo.CalcularArea());
        Console.WriteLine("El area rectángulo es:");
        Console.WriteLine(rectangulo.CalcularArea());

        // Pero sí se puede crear una instancia de una clase derivada
        Animal miPerro = new Perro();
        Animal miGato = new Gato();
        miPerro.HacerSonido(); // Salida: Guau guau
        miPerro.Dormir(); // Salida: Zzz...

        miGato.HacerSonido(); // Salida: Guau guau
        miGato.Dormir(); // Salida: Zzz...

        Console.Read();
    }
}
