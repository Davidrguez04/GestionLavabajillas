using GestionLavabajillas.Dto;
using GestionLavabajillas.Servicios;

namespace GestionLavabajillas
{
    class Program
    {
        static void Main(string[] args)
        {
            InterfazMenu mi = new MenuImpl();
            InterfazCantidad ni=new GestionCantidad();

            List<LavabajillasDto> list = new List <LavabajillasDto>();

            mi.mensajeBienvenida();

            bool opcionSeleccionada=false;
            int opcion;

            while (!opcionSeleccionada)
            {
                 opcion = mi.mostrarMenu();
                Console.WriteLine("\n\t[INFO] - Has seleccionado la opción: " + opcion);

                switch (opcion)
                {
                    case 0:
                        Console.WriteLine("\n\t[INFO]---Has seleccionado al opcion para salir");
                        opcionSeleccionada = true;
                        break;

                    case 1:
                        Console.WriteLine("\n\t");
                        ni.gestionPlatos(list);

                        foreach(LavabajillasDto lavad in list)
                        {
                            Console.WriteLine(lavad.ToString());

                        }
                        break;

                    case 2:
                        ni.borrarLava(list);

                        foreach (LavabajillasDto lavad in list)
                        {
                            Console.WriteLine(lavad.ToString());
                            
                            
                        }
                        break;

                    case 3:
                        ni.agregarLava(list);

                        foreach (LavabajillasDto lavad in list)
                        {
                            Console.WriteLine(lavad.ToString());
                        }
                        break;

                    case 4:
                        foreach (LavabajillasDto lavad in list)
                        {
                            Console.WriteLine(lavad.ToString());

                        }
                        break;

                    default:
                        Console.WriteLine("\n\t[ERROR]-- Has seleccionado una opcion incorrecta");
                        
                        break;
                }


            }
        }
    }
}
