namespace Ej1_1Carreras
{
    partial class Carrera
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.Idclm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBorrar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cboMateria = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDetalle = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAño = new System.Windows.Forms.TextBox();
            this.txtCuatri = new System.Windows.Forms.TextBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtCarrera = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.informeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.AllowUserToAddRows = false;
            this.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Idclm,
            this.colMateria,
            this.clmBorrar});
            this.dgvDetalle.Location = new System.Drawing.Point(61, 240);
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.Size = new System.Drawing.Size(690, 180);
            this.dgvDetalle.TabIndex = 0;
            this.dgvDetalle.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalle_CellContentClick);
            // 
            // Idclm
            // 
            this.Idclm.HeaderText = "Id";
            this.Idclm.Name = "Idclm";
            this.Idclm.Visible = false;
            // 
            // colMateria
            // 
            this.colMateria.HeaderText = "Materia";
            this.colMateria.Name = "colMateria";
            this.colMateria.Width = 200;
            // 
            // clmBorrar
            // 
            this.clmBorrar.HeaderText = "Borrar";
            this.clmBorrar.Name = "clmBorrar";
            this.clmBorrar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmBorrar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clmBorrar.Text = "Quitar";
            this.clmBorrar.UseColumnTextForButtonValue = true;
            this.clmBorrar.Width = 250;
            // 
            // cboMateria
            // 
            this.cboMateria.FormattingEnabled = true;
            this.cboMateria.Location = new System.Drawing.Point(208, 195);
            this.cboMateria.Name = "cboMateria";
            this.cboMateria.Size = new System.Drawing.Size(391, 21);
            this.cboMateria.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Detalle Nro";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(676, 195);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(110, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Año";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(85, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Carrera";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Cuatrimestre";
            // 
            // lblDetalle
            // 
            this.lblDetalle.AutoSize = true;
            this.lblDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalle.Location = new System.Drawing.Point(205, 21);
            this.lblDetalle.Name = "lblDetalle";
            this.lblDetalle.Size = new System.Drawing.Size(0, 16);
            this.lblDetalle.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(85, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Materia";
            // 
            // txtAño
            // 
            this.txtAño.Location = new System.Drawing.Point(208, 113);
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(100, 20);
            this.txtAño.TabIndex = 14;
            // 
            // txtCuatri
            // 
            this.txtCuatri.Location = new System.Drawing.Point(208, 154);
            this.txtCuatri.Name = "txtCuatri";
            this.txtCuatri.Size = new System.Drawing.Size(100, 20);
            this.txtCuatri.TabIndex = 15;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(208, 434);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 16;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(524, 434);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtCarrera
            // 
            this.txtCarrera.Location = new System.Drawing.Point(208, 69);
            this.txtCarrera.Name = "txtCarrera";
            this.txtCarrera.Size = new System.Drawing.Size(391, 20);
            this.txtCarrera.TabIndex = 18;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // informeToolStripMenuItem
            // 
            this.informeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informeToolStripMenuItem1});
            this.informeToolStripMenuItem.Name = "informeToolStripMenuItem";
            this.informeToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.informeToolStripMenuItem.Text = "Diseño";
            this.informeToolStripMenuItem.Click += new System.EventHandler(this.informeToolStripMenuItem_Click);
            // 
            // informeToolStripMenuItem1
            // 
            this.informeToolStripMenuItem1.Name = "informeToolStripMenuItem1";
            this.informeToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.informeToolStripMenuItem1.Text = "Informe";
            this.informeToolStripMenuItem1.Click += new System.EventHandler(this.informeToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 469);
            this.Controls.Add(this.txtCarrera);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.txtCuatri);
            this.Controls.Add(this.txtAño);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblDetalle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboMateria);
            this.Controls.Add(this.dgvDetalle);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDetalle;
        private System.Windows.Forms.ComboBox cboMateria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDetalle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAño;
        private System.Windows.Forms.TextBox txtCuatri;
        private System.Windows.Forms.DataGridViewTextBoxColumn Idclm;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMateria;
        private System.Windows.Forms.DataGridViewButtonColumn clmBorrar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtCarrera;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem informeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informeToolStripMenuItem1;
    }
}

