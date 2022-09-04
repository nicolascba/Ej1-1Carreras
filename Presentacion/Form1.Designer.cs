namespace Ej1_1Carreras.Presentacion
{
    partial class Reporte
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dSlistado = new Ej1_1Carreras.Presentacion.DSlistado();
            this.dSlistadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CarrerasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carrerasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.carrerasTableAdapter = new Ej1_1Carreras.Presentacion.DSlistadoTableAdapters.CarrerasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dSlistado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSlistadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarrerasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carrerasBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.carrerasBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Ej1_1Carreras.Presentacion.ReporteCarreras.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(647, 365);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // dSlistado
            // 
            this.dSlistado.DataSetName = "DSlistado";
            this.dSlistado.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dSlistadoBindingSource
            // 
            this.dSlistadoBindingSource.DataSource = this.dSlistado;
            this.dSlistadoBindingSource.Position = 0;
            // 
            // CarrerasBindingSource
            // 
            this.CarrerasBindingSource.DataMember = "Carreras";
            this.CarrerasBindingSource.DataSource = this.dSlistado;
            // 
            // carrerasBindingSource1
            // 
            this.carrerasBindingSource1.DataMember = "Carreras";
            this.carrerasBindingSource1.DataSource = this.dSlistado;
            // 
            // carrerasTableAdapter
            // 
            this.carrerasTableAdapter.ClearBeforeFill = true;
            // 
            // Reporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 365);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Reporte";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Reporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSlistado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSlistadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarrerasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carrerasBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dSlistadoBindingSource;
        private DSlistado dSlistado;
        private System.Windows.Forms.BindingSource CarrerasBindingSource;
        private System.Windows.Forms.BindingSource carrerasBindingSource1;
        private DSlistadoTableAdapters.CarrerasTableAdapter carrerasTableAdapter;
    }
}