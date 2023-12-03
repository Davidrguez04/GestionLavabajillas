using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionLavabajillas.Servicios
{
    internal class MenuImpl:InterfazMenu
    {
        public void mensajeBienvenida()
        {
            string mensaje = "Bienvenido a la gestion de tu lavabajilla";
            Console.WriteLine("\n\t"+ mensaje);
        }

        public int mostrarMenu()
        {
            int opcion;

            Console.WriteLine("\t\t Menu opciones:");
            Console.WriteLine("\t\t1-Cantidad platos");
            Console.WriteLine("\t\t2-Eliminar platos");
            Console.WriteLine("\t\t3-Agregar paltos");
            Console.WriteLine("\t\t4-Mostrar paltos");
            Console.WriteLine("\t\t0-salir");
            Console.WriteLine("\t\tElija una opcion: ");
            
            opcion= Console.ReadKey(true).KeyChar - ('0');
            return opcion;
            
        }
    }
}
