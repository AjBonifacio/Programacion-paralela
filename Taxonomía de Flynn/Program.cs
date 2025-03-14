using Taxonomía_de_Flynn;

internal class Program
{
    public static void Main(string[] args)
    {

        
        Console.WriteLine("Implementación de los Modelos Basados en Flynn:\n");

        Console.WriteLine("proceso SISD, (una instruccion, un dato)");
        SISD.Procesamiento_secuencial();


        Console.WriteLine("\nproceso SIMD, (una instruccion, multiples datos)");
        SIMD.MultiplesDatos();

        Console.WriteLine("\nproceso MIMD, (multiples intrucciones, multiples datos) ");
        MIMD.multiplesProceso();


    }
}