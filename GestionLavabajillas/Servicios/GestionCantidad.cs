using GestionLavabajillas.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionLavabajillas.Servicios
{
    internal class GestionCantidad:InterfazCantidad
    {
        public void gestionPlatos(List<LavabajillasDto>listaCan)
        {
            LavabajillasDto li=new LavabajillasDto();

            Console.WriteLine("Cuantos platos tiene actualmente?: ");
            li.NPlatos=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Cuantos vasos tiene actualmente?: ");
            li.NVasos = Convert.ToInt32(Console.ReadLine());

            listaCan.Add(li);


        }

        public void borrarLava(List<LavabajillasDto>listaCan)
        {

            LavabajillasDto lava = new LavabajillasDto();

            Console.WriteLine("Cuantos platos quiere borrar?: ");
            int nPlat=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Cuantos vasos quiere borrar?: ");
            int nVaso = Convert.ToInt32(Console.ReadLine());

            foreach(LavabajillasDto li in listaCan)
            {
                lava = li;

                 li.NVasos=li.NVasos - nVaso;
                li.NPlatos = li.NPlatos - nPlat;

            }

            //No hace falta poner el add ya que se cambiua solo y nio crea otra posicion de la lista listaCan.Add(lava);

        }

        public void agregarLava(List<LavabajillasDto> listaCan)
        {

            LavabajillasDto lava = new LavabajillasDto();

            Console.WriteLine("Cuantos platos quiere agregar?: ");
            int nPlat = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Cuantos vasos quiere agregar?: ");
            int nVaso = Convert.ToInt32(Console.ReadLine());

            foreach (LavabajillasDto li in listaCan)
            {
                lava = li;

                li.NVasos = li.NVasos + nVaso;
                li.NPlatos = li.NPlatos + nPlat;

            }

            //listaCan.Add(lava);

        }
    }
}
