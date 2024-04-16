
using Interfaces;

public interface IReproductorMusical
{
    void Reproducir();
    void Pausar();
}

public interface ICamara
{
    void TomarFoto();
    void GrabarVideo();

    void Grabar360();



}


public class SmartphoneAndroid : IReproductorMusical, ICamara
{
    public void Grabar360()
    {
        Console.WriteLine(" Grabar 360.");
    }

    public void GrabarVideo()
    {
        Console.WriteLine(" Grabar Video.");
    }

    public void Pausar()
    {
        Console.WriteLine("Pausar");

    }

    public void Reproducir()
    {
        Console.WriteLine("Reproducir");
    }

    public void TomarFoto()
    {
        Console.WriteLine("Tomar Foto");
    }
}


public class SmartphoneIphone : IReproductorMusical, ICamara
{
    public void Grabar360()
    {
        throw new NotImplementedException();
    }

    public void GrabarVideo()
    {
        Console.WriteLine(" Grabar Video desde Iphone.");
    }

    public void Pausar()
    {
        Console.WriteLine("Pausar desde Iphone");

    }

    public void Reproducir()
    {
        Console.WriteLine("Reproducir desde Iphone");
    }

    public void TomarFoto()
    {
        Console.WriteLine("Tomar Foto desde Iphone");
    }
}



class Program
{
    static void Main(string[] args)
    {

        SmartphoneAndroid miAndroid = new SmartphoneAndroid();
        miAndroid.Reproducir(); // Salida: Reproduciendo música.
        miAndroid.Pausar(); // Salida: Pausando la reproducción.
        miAndroid.TomarFoto(); // Salida: Tomando una foto.
        miAndroid.GrabarVideo(); // Salida: Grabando un video.

        SmartphoneIphone miIphone = new SmartphoneIphone();
        miIphone.Reproducir(); // Salida: Reproduciendo música.
        miIphone.Pausar(); // Salida: Pausando la reproducción.
        miIphone.TomarFoto(); // Salida: Tomando una foto.
        miIphone.GrabarVideo(); // Salida: Grabando un video.



    }


    static void Ejemplo02()
    {
        ITablasMaestras categoria = new Categoria();
        ITablasMaestras tipoDocumento = new TipoDocumento();

        categoria.Insertar();
        categoria.Actualizar();
        categoria.Eliminar();
        categoria.Listar();

        tipoDocumento.Insertar();
        tipoDocumento.Actualizar();
        tipoDocumento.Eliminar();
        tipoDocumento.Listar();

    }
    static void Ejemplo01()
    {
        Perro perro = new Perro();
        perro.HacerSonido();

        IAnimal perro2 = new Perro();
        perro2.HacerSonido();

    }

}