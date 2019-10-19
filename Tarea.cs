using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    public class Tarea
    {
        
        public string NombreTarea { get; set; }
        public string HoraTarea { get; set; }
        public string Fecha { get; set; }
        public string Status { get; set; }
        public string Detalle { get; set; }

        public List<Tarea> ListaTarea()
        {
            List<Tarea> lista = new List<Tarea>();

            return lista;
        }
    }
}
