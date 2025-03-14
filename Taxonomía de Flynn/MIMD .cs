using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxonomía_de_Flynn
{
    public class MIMD
    {

        static int[] arregloSuma = { 1, 2, 3, 4, 5 };
        static int[] arregloMultiplicacion = { 2, 3, 4, 5, 6 };

       public static void multiplesProceso()
        {
            
            Thread procesoSuma = new Thread(Sumar);
            Thread procesoMultiplicacion = new Thread(Multiplicar);

            // Iniciar proceso
            procesoSuma.Start();
            procesoMultiplicacion.Start();

            // Esperar a que ambos terminen
            procesoSuma.Join();
            procesoMultiplicacion.Join();

            Console.WriteLine("Tareas completadas.");
        }

       
        static void Sumar()
        {
            int suma = 0;
            foreach (var numero in arregloSuma)
            {
                suma += numero;
            }
            Console.WriteLine($"Suma:{suma}");
        }

      
        static void Multiplicar()
        {
            int producto = 1;
            foreach (var numero in arregloMultiplicacion)
            {
                producto *= numero;
            }
            Console.WriteLine($"Multiplicación: {producto}");
        }
    }
}
