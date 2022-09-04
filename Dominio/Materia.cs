using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1_1Carreras.Dominio
{
    internal class Materia
    {
        public int IdMateria { get; set; }
        public string Nombre { get; set; }

        public Materia(int idMateria, string nombre)
        {
            IdMateria = idMateria;
            Nombre = nombre;
        }
        public Materia()
        {
            IdMateria = 0;
            Nombre = "";
        }
    }
}
