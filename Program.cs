using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    class Program
    {
        static void Main(string[] args)
        {
            Principal p = new Principal();
            p.Welcome();
            Console.ReadKey();
        }
    }
}
