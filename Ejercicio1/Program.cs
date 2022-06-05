// See https://aka.ms/new-console-template for more information

namespace Ejercicio1
{
      class Program
    {
        static void Main(string[] args)
        {

          int cant, confirmar, cantidad; 

           List<tareas> listaTareasPendientes = new List<tareas>();
           List<tareas> listaTareasRealizadas = new List<tareas>();
           

           Console.WriteLine("Ingrese la cantidad de tareas : ");
           cant = Convert.ToInt32(Console.ReadLine());

           for (int i = 0; i < cant ; i++){
             listaTareasPendientes.Add( tareas.creartarea(i));

           }

            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Lista Tareas Pendientes");
           foreach(tareas tarea in listaTareasPendientes){
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Tareaid : " + tarea.TareaId);
            Console.WriteLine("Descripcion :" + tarea.Descripcion);
            Console.WriteLine("Duracion hs : " + tarea.Duracion);
           }
          
            Console.WriteLine("------------------------------------------");
            foreach(tareas tarea in listaTareasPendientes){
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Descripcion :" + tarea.Descripcion);
             Console.WriteLine("Tareaid : " + tarea.TareaId);
            Console.WriteLine("Se realizo la taraa ? 1-SI  0-NO");
            confirmar =  Convert.ToInt32(Console.ReadLine());
            if(confirmar == 1 ){
              listaTareasRealizadas.Add(tarea);
            }
            
          }

            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Lista Tareas Realizadas");
            foreach(tareas tarea in listaTareasRealizadas){
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Tareaid : " + tarea.TareaId);
            Console.WriteLine("Descripcion :" + tarea.Descripcion);
            Console.WriteLine("Duracion hs : " + tarea.Duracion);
           }

         foreach(tareas tarea in listaTareasRealizadas ){
           if(listaTareasPendientes.Contains(tarea)){
             listaTareasPendientes.Remove(tarea);
           }
         }

            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Lista Tareas Pendientes");
            foreach(tareas tarea in listaTareasPendientes){
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Tareaid : " + tarea.TareaId);
            Console.WriteLine("Descripcion :" + tarea.Descripcion);
            Console.WriteLine("Duracion hs : " + tarea.Duracion);
           }


          Console.WriteLine("------------------------------------------");
           Console.WriteLine("Ingrese la palabra a buscar : ");
          string  busqueda =Console.ReadLine();
          int encontrado = 0;

           foreach(var tarea in listaTareasPendientes){
             if(tarea.Descripcion == busqueda){
               encontrado = 1;
             }  else{
               encontrado = 0;
             }
           }
            if(encontrado ==1){
              Console.WriteLine("Palabra encontrada ");
            }else{
                Console.WriteLine("Palabra NO encontrada ");
            }

            int horas =0;

            foreach(tareas tarea in listaTareasRealizadas){
                horas += tarea.Duracion;
            }
            Console.WriteLine($"Horas trabajadas : {horas}");




      
          
          




}
}
}