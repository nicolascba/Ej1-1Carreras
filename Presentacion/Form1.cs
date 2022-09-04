using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej1_1Carreras.Presentacion
{
    public partial class Reporte : Form
    {
        public Reporte()
        {
            InitializeComponent();
        }

        private void Reporte_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dSlistado.Carreras' Puede moverla o quitarla según sea necesario.
            this.carrerasTableAdapter.Fill(this.dSlistado.Carreras);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
