using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulación_de_un_Monoprocesador
{
    public class tarea
    {
        public string name {  get; set; }

        int duracion { get; set; }

        
        public tarea(string name, int duracion)
        {
            this.name = name;
            this.duracion = duracion;
        }

        public void ejecutar() {


            Stopwatch temporizador =  Stopwatch.StartNew();
            


            Console.WriteLine($"comenzo la tarea {name}");
            Thread.Sleep(duracion * 1000);

            temporizador.Stop();

            Console.WriteLine($"finalizo la tarea {name}");
            Console.WriteLine($"con una duracion de {temporizador.Elapsed.TotalSeconds}\n");
        }


    }
}
