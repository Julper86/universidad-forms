namespace universidad_forms
{
    partial class Form2
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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtEdad = new System.Windows.Forms.TextBox();
            this.TxtPrograma = new System.Windows.Forms.TextBox();
            this.BtAdicionar = new System.Windows.Forms.Button();
            this.BtConsultar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.BtEliminar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cbmTipoid = new System.Windows.Forms.ComboBox();
            this.rdbMasculino = new System.Windows.Forms.RadioButton();
            this.rdbFemenino = new System.Windows.Forms.RadioButton();
            this.dtfFecnac = new System.Windows.Forms.DateTimePicker();
            this.cmbTipoId = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.ClNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.identificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClEdad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClPrograma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Csexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ctipoid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtClose = new System.Windows.Forms.Button();
            this.MsArchivo = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.MsArchivo.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identificacion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 135);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Edad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 176);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Programa Academico";
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(166, 64);
            this.TxtId.Margin = new System.Windows.Forms.Padding(2);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(94, 20);
            this.TxtId.TabIndex = 1;
            this.TxtId.TextChanged += new System.EventHandler(this.TxtId_TextChanged);
            this.TxtId.Validating += new System.ComponentModel.CancelEventHandler(this.TxtId_Validating);
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(166, 96);
            this.TxtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(94, 20);
            this.TxtNombre.TabIndex = 5;
            this.TxtNombre.TextChanged += new System.EventHandler(this.TxtNombre_TextChanged);
            // 
            // TxtEdad
            // 
            this.TxtEdad.Location = new System.Drawing.Point(166, 130);
            this.TxtEdad.Margin = new System.Windows.Forms.Padding(2);
            this.TxtEdad.Name = "TxtEdad";
            this.TxtEdad.Size = new System.Drawing.Size(94, 20);
            this.TxtEdad.TabIndex = 6;
            this.TxtEdad.TextChanged += new System.EventHandler(this.TxtEdad_TextChanged);
            // 
            // TxtPrograma
            // 
            this.TxtPrograma.Location = new System.Drawing.Point(166, 171);
            this.TxtPrograma.Margin = new System.Windows.Forms.Padding(2);
            this.TxtPrograma.Name = "TxtPrograma";
            this.TxtPrograma.Size = new System.Drawing.Size(94, 20);
            this.TxtPrograma.TabIndex = 7;
            this.TxtPrograma.TextChanged += new System.EventHandler(this.TxtPrograma_TextChanged);
            // 
            // BtAdicionar
            // 
            this.BtAdicionar.Location = new System.Drawing.Point(304, 51);
            this.BtAdicionar.Margin = new System.Windows.Forms.Padding(2);
            this.BtAdicionar.Name = "BtAdicionar";
            this.BtAdicionar.Size = new System.Drawing.Size(86, 33);
            this.BtAdicionar.TabIndex = 8;
            this.BtAdicionar.Text = "Aicionar";
            this.BtAdicionar.UseVisualStyleBackColor = true;
            this.BtAdicionar.Click += new System.EventHandler(this.BtAdicionar_Click);
            // 
            // BtConsultar
            // 
            this.BtConsultar.Location = new System.Drawing.Point(304, 115);
            this.BtConsultar.Margin = new System.Windows.Forms.Padding(2);
            this.BtConsultar.Name = "BtConsultar";
            this.BtConsultar.Size = new System.Drawing.Size(86, 33);
            this.BtConsultar.TabIndex = 9;
            this.BtConsultar.Text = "Consultar";
            this.BtConsultar.UseVisualStyleBackColor = true;
            this.BtConsultar.Click += new System.EventHandler(this.BtConsultar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(527, 77);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 47);
            this.button2.TabIndex = 13;
            this.button2.Text = "Ver año de grado";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtEliminar
            // 
            this.BtEliminar.Location = new System.Drawing.Point(415, 51);
            this.BtEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.BtEliminar.Name = "BtEliminar";
            this.BtEliminar.Size = new System.Drawing.Size(86, 33);
            this.BtEliminar.TabIndex = 14;
            this.BtEliminar.Text = "Eliminar";
            this.BtEliminar.UseVisualStyleBackColor = true;
            this.BtEliminar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(415, 115);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 33);
            this.button1.TabIndex = 15;
            this.button1.Text = "Actualizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // cbmTipoid
            // 
            this.cbmTipoid.FormattingEnabled = true;
            this.cbmTipoid.Items.AddRange(new object[] {
            "",
            "CC.  identificacion",
            "T. Identidad",
            "Otro"});
            this.cbmTipoid.Location = new System.Drawing.Point(166, 30);
            this.cbmTipoid.Name = "cbmTipoid";
            this.cbmTipoid.Size = new System.Drawing.Size(121, 21);
            this.cbmTipoid.TabIndex = 16;
            // 
            // rdbMasculino
            // 
            this.rdbMasculino.AutoSize = true;
            this.rdbMasculino.Location = new System.Drawing.Point(317, 171);
            this.rdbMasculino.Name = "rdbMasculino";
            this.rdbMasculino.Size = new System.Drawing.Size(73, 17);
            this.rdbMasculino.TabIndex = 17;
            this.rdbMasculino.TabStop = true;
            this.rdbMasculino.Text = "Masculino";
            this.rdbMasculino.UseVisualStyleBackColor = true;
            this.rdbMasculino.Validating += new System.ComponentModel.CancelEventHandler(this.RdbMasculino_Validating);
            // 
            // rdbFemenino
            // 
            this.rdbFemenino.AutoSize = true;
            this.rdbFemenino.Location = new System.Drawing.Point(422, 171);
            this.rdbFemenino.Name = "rdbFemenino";
            this.rdbFemenino.Size = new System.Drawing.Size(71, 17);
            this.rdbFemenino.TabIndex = 18;
            this.rdbFemenino.TabStop = true;
            this.rdbFemenino.Text = "Femenino";
            this.rdbFemenino.UseVisualStyleBackColor = true;
            // 
            // dtfFecnac
            // 
            this.dtfFecnac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtfFecnac.Location = new System.Drawing.Point(158, 219);
            this.dtfFecnac.Name = "dtfFecnac";
            this.dtfFecnac.Size = new System.Drawing.Size(102, 20);
            this.dtfFecnac.TabIndex = 19;
            this.dtfFecnac.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // cmbTipoId
            // 
            this.cmbTipoId.AutoSize = true;
            this.cmbTipoId.Location = new System.Drawing.Point(49, 30);
            this.cmbTipoId.Name = "cmbTipoId";
            this.cmbTipoId.Size = new System.Drawing.Size(111, 13);
            this.cmbTipoId.TabIndex = 20;
            this.cmbTipoId.Text = "Tipo de identificacion ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Fecha de nac";
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClNombre,
            this.identificacion,
            this.ClEdad,
            this.ClPrograma,
            this.ClFecha,
            this.Csexo,
            this.Ctipoid});
            this.dgvDatos.Location = new System.Drawing.Point(52, 276);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.RowHeadersWidth = 51;
            this.dgvDatos.Size = new System.Drawing.Size(744, 192);
            this.dgvDatos.TabIndex = 22;
            this.dgvDatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatos_CellClick);
            this.dgvDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ClNombre
            // 
            this.ClNombre.DataPropertyName = "Nombre";
            this.ClNombre.HeaderText = "Nombre";
            this.ClNombre.MinimumWidth = 6;
            this.ClNombre.Name = "ClNombre";
            this.ClNombre.ReadOnly = true;
            this.ClNombre.Width = 125;
            // 
            // identificacion
            // 
            this.identificacion.DataPropertyName = "Id";
            this.identificacion.HeaderText = "Identificacion";
            this.identificacion.MinimumWidth = 6;
            this.identificacion.Name = "identificacion";
            this.identificacion.ReadOnly = true;
            this.identificacion.Width = 125;
            // 
            // ClEdad
            // 
            this.ClEdad.DataPropertyName = "Edad";
            this.ClEdad.HeaderText = "Edad";
            this.ClEdad.MinimumWidth = 6;
            this.ClEdad.Name = "ClEdad";
            this.ClEdad.ReadOnly = true;
            this.ClEdad.Width = 125;
            // 
            // ClPrograma
            // 
            this.ClPrograma.DataPropertyName = "Programaacadeico";
            this.ClPrograma.HeaderText = "Programa ";
            this.ClPrograma.MinimumWidth = 6;
            this.ClPrograma.Name = "ClPrograma";
            this.ClPrograma.ReadOnly = true;
            this.ClPrograma.Width = 125;
            // 
            // ClFecha
            // 
            this.ClFecha.DataPropertyName = "Fecnac";
            this.ClFecha.HeaderText = "Fecha";
            this.ClFecha.MinimumWidth = 6;
            this.ClFecha.Name = "ClFecha";
            this.ClFecha.ReadOnly = true;
            this.ClFecha.Width = 125;
            // 
            // Csexo
            // 
            this.Csexo.DataPropertyName = "Sexo";
            this.Csexo.HeaderText = "Sexo";
            this.Csexo.MinimumWidth = 6;
            this.Csexo.Name = "Csexo";
            this.Csexo.ReadOnly = true;
            this.Csexo.Width = 125;
            // 
            // Ctipoid
            // 
            this.Ctipoid.DataPropertyName = "Tipoid";
            this.Ctipoid.HeaderText = "T. Id";
            this.Ctipoid.MinimumWidth = 6;
            this.Ctipoid.Name = "Ctipoid";
            this.Ctipoid.ReadOnly = true;
            this.Ctipoid.Width = 125;
            // 
            // BtClose
            // 
            this.BtClose.Location = new System.Drawing.Point(746, 513);
            this.BtClose.Margin = new System.Windows.Forms.Padding(2);
            this.BtClose.Name = "BtClose";
            this.BtClose.Size = new System.Drawing.Size(98, 37);
            this.BtClose.TabIndex = 23;
            this.BtClose.Text = "Salir";
            this.BtClose.UseVisualStyleBackColor = true;
            this.BtClose.Click += new System.EventHandler(this.BtClose_Click);
            // 
            // MsArchivo
            // 
            this.MsArchivo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.verToolStripMenuItem});
            this.MsArchivo.Location = new System.Drawing.Point(0, 0);
            this.MsArchivo.Name = "MsArchivo";
            this.MsArchivo.Size = new System.Drawing.Size(897, 24);
            this.MsArchivo.TabIndex = 24;
            this.MsArchivo.Text = "&Archivo";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "&Archivo";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.editarToolStripMenuItem.Text = "Ed&itar";
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.verToolStripMenuItem.Text = "&Ver";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 576);
            this.Controls.Add(this.MsArchivo);
            this.Controls.Add(this.BtClose);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbTipoId);
            this.Controls.Add(this.dtfFecnac);
            this.Controls.Add(this.rdbFemenino);
            this.Controls.Add(this.rdbMasculino);
            this.Controls.Add(this.cbmTipoid);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtEliminar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BtConsultar);
            this.Controls.Add(this.BtAdicionar);
            this.Controls.Add(this.TxtPrograma);
            this.Controls.Add(this.TxtEdad);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.MsArchivo.ResumeLayout(false);
            this.MsArchivo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label cmbTipoId;
        private System.Windows.Forms.DateTimePicker dtfFecnac;
        private System.Windows.Forms.RadioButton rdbFemenino;
        private System.Windows.Forms.RadioButton rdbMasculino;
        private System.Windows.Forms.ComboBox cbmTipoid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtEliminar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BtConsultar;
        private System.Windows.Forms.Button BtAdicionar;
        private System.Windows.Forms.TextBox TxtPrograma;
        private System.Windows.Forms.TextBox TxtEdad;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.Button BtClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn identificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClEdad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClPrograma;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Csexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ctipoid;
        private System.Windows.Forms.MenuStrip MsArchivo;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
    }
}