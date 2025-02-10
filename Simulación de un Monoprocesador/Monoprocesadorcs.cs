using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulación_de_un_Monoprocesador
{
    public class Monoprocesadorcs
    {

        List<tarea> cola_tareas = new List<tarea>();

        public void agregarTarea(tarea tarea)
        {
            cola_tareas.Add(item: tarea);
            Console.WriteLine($"{tarea.name} agregada");
        }
        public void ejecutarTarea()
        {
            if (cola_tareas != null) {

                foreach (tarea tare in cola_tareas)
            {

                Console.WriteLine($"tarea {tare.name}");
                tare.ejecutar();
            }
            
            }
                Console.WriteLine("no se puede ejecutar porque no hay tareas");
            
        }
    }
}
