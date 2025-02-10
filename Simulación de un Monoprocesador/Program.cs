using Simulación_de_un_Monoprocesador;

public class Program
{
    private static void Main(string[] args)
    {
         Monoprocesadorcs multiTarea = new Monoprocesadorcs();


        /*
          utilizar en caso de no querer agregar manualmente

         multiTarea.agregarTarea(new tarea("tarea 7",)
         multiTarea.agregarTarea(new tarea("proyecto ",9)
         multiTarea.agregarTarea(new tarea("tarea de paralela",5)
         
         
         */

        while (true)
        {

            Console.WriteLine("1- agreagar tareas 2-ejecutar las tareas almacenadas");
            string Opcion = Console.ReadLine();


            switch (Opcion)
            {

                case "1":
                    Console.WriteLine("nombre de la tarea\n");
                    string nombre = Console.ReadLine();

                    Console.WriteLine("ingrese la duracion");
                    int duracio = int.Parse(Console.ReadLine());


                    multiTarea.agregarTarea(new tarea(name: nombre, duracion: duracio));
                    break;

                case "2":

                    multiTarea.ejecutarTarea();
                    break;
            }


        }




    }
}