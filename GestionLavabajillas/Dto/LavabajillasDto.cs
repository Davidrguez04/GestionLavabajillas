using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionLavabajillas.Dto
{
    internal class LavabajillasDto
    {
        int nPlatos;
        int nVasos;

        public int NPlatos { get => nPlatos; set => nPlatos = value; }
        public int NVasos { get => nVasos; set => nVasos = value; }

        public LavabajillasDto(int nPlatos, int nVasos)
        {
            this.nPlatos = nPlatos;
            this.nVasos = nVasos;
        }

        public LavabajillasDto()
        {
        }
        override
        public string ToString()
        {
            string lavabajillas = "Numero de platos: " + this.nPlatos + " Numero de vasos: " + this.nVasos;

            return lavabajillas;
        }
    }
}
