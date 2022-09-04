using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1_1Carreras.Dominio
{
    internal class Carrera
    {
        public int IdCarrera { get; set; }
        public string Nombre { get; set; }       

        public List<DetalleCarreras> Detalle { get; set; }

        public Carrera()
        {
            IdCarrera = 0;
            Nombre = "";           
            Detalle = new List<DetalleCarreras>();
        }

        public Carrera(int idCarrera, string nombre, List<DetalleCarreras> detalle)
        {
            IdCarrera = idCarrera;
            Nombre = nombre;
            Detalle = detalle;
        }

        public void AgregarDetalle(DetalleCarreras detalle)
        {
            if(detalle != null)
            {
                Detalle.Add(detalle);
            }
        }

        public void QuitarDetalle(int indice)
        {
            Detalle.RemoveAt(indice);
        }
        public void LimpiarDetalle()
        {
            Detalle.Clear();
        }
    }
}
