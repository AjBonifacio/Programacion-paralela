using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxonomía_de_Flynn
{
    public class SISD
    {
       public static void Procesamiento_secuencial()
        {
            int[] datos = { 1, 2, 3, 4, 5 };
            int suma = 0;

            // una sola instrucción sobre un solo flujo de datos
            for (int i = 0; i < datos.Length; i++)
            {
                suma += datos[i]; 
            }

            Console.WriteLine($"Resultado SISD:{suma}");
        }
    }
}
    
