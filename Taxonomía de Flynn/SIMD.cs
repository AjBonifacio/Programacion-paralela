using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Taxonomía_de_Flynn
{
    public class SIMD
    {
        public static void MultiplesDatos()
        {
            int[] lista1 = { 1, 2, 3, 4, 5 };
            int[] lista2 = { 10, 20, 30, 40, 50 };
            int[] resulto = new int[5];

            // suma un par de datos de forma paralela
            for (int i = 0; i < lista1.Length; i++)
            {
                resulto[i] = lista1[i] + lista2[i];
            }

            Console.WriteLine("Resultados:");
            foreach (var resul in resulto)
            {
                Console.WriteLine(resul);
            }
        }
    }
    }




