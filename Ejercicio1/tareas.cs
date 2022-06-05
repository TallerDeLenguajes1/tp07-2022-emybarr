using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejercicio1
{
    public class tareas
    {
        private int tareaId;

        private string descripcion;

        private int duracion;

        public int TareaId { get => tareaId; set => tareaId = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int Duracion { get => duracion; set => duracion = value; }

        public static tareas creartarea( int i){
           
            tareas nuevatarea = new tareas();
            Random rand = new Random();
            Console.WriteLine("Ingrese Descripcion ");
            nuevatarea.Descripcion = Console.ReadLine();
            nuevatarea.TareaId +=i ;
            nuevatarea.Duracion = rand.Next(1,18);
            return nuevatarea;

        }

        
    }
}