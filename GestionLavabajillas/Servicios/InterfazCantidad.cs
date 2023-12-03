using GestionLavabajillas.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionLavabajillas.Servicios
{
    internal interface InterfazCantidad
    {
        public void gestionPlatos(List<LavabajillasDto> listaCan);

        public void borrarLava(List<LavabajillasDto> listaCan);

        public void agregarLava(List<LavabajillasDto> listaCan);
    }
}
