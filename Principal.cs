using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    public class Principal
    {

        List<Usuario> lista = new List<Usuario>();
        Usuario usuario1 = new Usuario();
        DatosTarea dt = new DatosTarea();
        public void Welcome()
        {
            //Se hace un metodo llamado welcome para instanciar en el main
            Console.WriteLine("Bienvenido a la lista de tareas ");
            Menu(usuario1);
        }

        public void Menu(Usuario u)
        {
            
            Console.WriteLine("\nIngrese la opcion que desea: ");
            Console.WriteLine("1.-Crear Tarea \n2.-Lista de tareas \n3.-Detalle de tarea \n4.-Cambiar status");

            switch (Console.ReadLine())
            {
                case "1":
                    Getusuario();

                    Menu(usuario1);
                    break;

                case "2":
                    MostrarTarea();

                    Menu(usuario1);
                    break;

                case "3":
                    Verdetalle();
                    SelecDetalle();
                    break;
                
            }


        }

        public List<Usuario> Getusuario()
        {
            //Se capturan los valores que se requieren para la lista, 
            //cada vez que el usuario elige crear tarea se agregara una nueva lista



            Console.WriteLine("Ingrese nombre de quien hara la tarea: ");
            lista.Add(new Usuario { NombreUsuario=Console.ReadLine() });
            Console.WriteLine("Ingrese nombre de la tarea: ");
            lista.Add(new Usuario { NombreTarea= Console.ReadLine() });

            Console.WriteLine("Ingrese hora en que se realizara la tarea: ");
            lista.Add(new Usuario {HoraTarea= Console.ReadLine() });

            Console.WriteLine("Ingrese fecha: ");
            lista.Add(new Usuario { Fecha = Console.ReadLine() });

            Console.WriteLine("Ingrese status: ");
            lista.Add(new Usuario { Status = Console.ReadLine() });

            Console.WriteLine("Ingrese detalles de la tarea: ");
            lista.Add(new Usuario { Detalle = Console.ReadLine() });







            Menu(usuario1);



            return lista;

            
        }

        public void MostrarTarea()
        {


            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine(lista[i].NombreUsuario +"\t"+ lista[i].NombreTarea + "\t" + lista[i].HoraTarea + "\t" + lista[i].Fecha + "\t" + lista[i].Status);
            }
        }


        public void Verdetalle()
        {
            
            for (int i = 0; i < lista.Count; i++)
            {

                Console.WriteLine(lista[i].NombreUsuario + "\t" + lista[i].NombreTarea + "\t" + lista[i].HoraTarea + "\t" + lista[i].Fecha + "\t" + lista[i].Status);

                
            }

           


          

        }

        public void SelecDetalle()
        {
            foreach (var usuario in lista)
            {
                //Con este for each se busca la tarea que se quiera ver el detalle
                
                Console.WriteLine("Seleccione un nombre: ");

                string nombre = Console.ReadLine();
                if (nombre == usuario.NombreUsuario)
                {
                    usuario1= usuario;
                    

                    
                }

                Console.WriteLine("Detalle: " + usuario1.Detalle);

                Console.ReadKey();

                
            }
        }




    }

        

    }

