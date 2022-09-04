using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1_1Carreras.Dominio
{
    internal class DetalleCarreras
    {
        public int AnioCursado { get; set; }
        public int Cuatrimestre { get; set; }
        public Materia Materia { get; set; }

        public DetalleCarreras(int anioCursado, int cuatrimestre, Materia materia)
        {
            AnioCursado = anioCursado;
            Cuatrimestre = cuatrimestre;
            Materia = materia;
        }

        public DetalleCarreras()
        {
            AnioCursado = DateTime.Now.Year;
            Cuatrimestre = 0;
            Materia= new Materia();
        }
    }
}
