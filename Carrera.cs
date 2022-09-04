using Ej1_1Carreras.AccesoDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ej1_1Carreras.Dominio;
using Ej1_1Carreras.Presentacion;

namespace Ej1_1Carreras
{
    public partial class Carrera : Form
    {
        ConexionDB helper;
        Dominio.Carrera carrera;
        public Carrera()
        {
            InitializeComponent();
            helper = new ConexionDB();
            carrera = new Dominio.Carrera();
        }
        private void CargarPrimero()
        {
            txtAño.Text = "2022";
            txtCuatri.Text = "1";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarCombo("SP_COMBO_MATERIA", cboMateria, "descripcion", "id_materia");           
            ProximoDetalle();
            CargarPrimero();

        }

        public void CargarCombo(string sp, ComboBox cbo, string display, string value)
        {
            DataTable tabla = helper.ConsultarSQL(sp);
            cbo.DataSource = tabla;
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtCarrera.Text.Equals(string.Empty))
            {
                MessageBox.Show("Debe Ingresar al menos una Carrera!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (cboMateria.Text.Equals(string.Empty))
            {
                MessageBox.Show("Debe seleccionar al menos una Materia!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (txtCuatri.Text == "" || !int.TryParse(txtCuatri.Text, out _))
            {
                MessageBox.Show("Debe ingresar un numero de cuatrimestre", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (txtAño.Text == "" || !int.TryParse(txtAño.Text, out _))
            {
                MessageBox.Show("Debe ingresar un Año", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            foreach (DataGridViewRow row in dgvDetalle.Rows)
            {
                if (row.Cells["colMateria"].Value.ToString().Equals(cboMateria.Text))
                {
                    MessageBox.Show("Materia: " + cboMateria.Text + " ya se encuentra como detalle!", "Control",

                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            DataRowView item = (DataRowView)cboMateria.SelectedItem;

            int id = Convert.ToInt32(item.Row.ItemArray[0]);
            string nom = item.Row.ItemArray[1].ToString();
            Materia materia = new Materia(id, nom);
            int aniocurs = int.Parse(txtAño.Text);
            int cuatri = int.Parse(txtCuatri.Text);
            DetalleCarreras detalle = new DetalleCarreras(aniocurs, cuatri, materia);
            carrera.AgregarDetalle(detalle);
            dgvDetalle.Rows.Add(new object[] { item.Row.ItemArray[0], item.Row.ItemArray[1] });
         

            
        }

        private void dgvDetalle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvDetalle.CurrentCell.ColumnIndex == 2)
            {
                carrera.QuitarDetalle(dgvDetalle.CurrentRow.Index);
                dgvDetalle.Rows.Remove(dgvDetalle.CurrentRow);
            }

        }

        private void ProximoDetalle()
        {
            int next = helper.ProximoDetalle();
            if(next > 0)
            {
                lblDetalle.Text = "Detalle N° " + next.ToString();
            }
            else          
            {
                MessageBox.Show("Error de datos. No se puede obtener Nº de presupuesto!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GuardarDetalle()
        {
            
            carrera.Nombre = txtCarrera.Text;
            if (helper.ConfirmarDetalle(carrera))
            {
                MessageBox.Show("Carrera registrada", "Informe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("ERROR. No se pudo registrar la carrera", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if(dgvDetalle.Rows.Count == 0)
            {
                MessageBox.Show("Debe ingresar al menos detalle!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (txtCarrera.Text == ""){
                MessageBox.Show("Debe ingresar nombre de Carrera!", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;

            }
            GuardarDetalle();
          
        }

        private void btnInforme_Click(object sender, EventArgs e)
        {


        }

        private void informeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void informeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Reporte reporteSimple = new Reporte();
            reporteSimple.ShowDialog();
        }
    }
}
