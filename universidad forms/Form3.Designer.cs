namespace universidad_forms
{
    partial class Form3
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
            this.button2 = new System.Windows.Forms.Button();
            this.BtConsultar = new System.Windows.Forms.Button();
            this.BtAdicionar = new System.Windows.Forms.Button();
            this.TxtAsignatura = new System.Windows.Forms.TextBox();
            this.TxtEdad = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtProfesion = new System.Windows.Forms.TextBox();
            this.BtEliminar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cmbTipoId = new System.Windows.Forms.Label();
            this.cbmTipoid = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtfFecnac = new System.Windows.Forms.DateTimePicker();
            this.rdbFemenino = new System.Windows.Forms.RadioButton();
            this.rdbMasculino = new System.Windows.Forms.RadioButton();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.ClNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClEdad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClPrograma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Profesion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Csexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ctipoid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(394, 219);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 47);
            this.button2.TabIndex = 24;
            this.button2.Text = "Saludo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtConsultar
            // 
            this.BtConsultar.Location = new System.Drawing.Point(341, 143);
            this.BtConsultar.Margin = new System.Windows.Forms.Padding(2);
            this.BtConsultar.Name = "BtConsultar";
            this.BtConsultar.Size = new System.Drawing.Size(102, 32);
            this.BtConsultar.TabIndex = 23;
            this.BtConsultar.Text = "Consultar";
            this.BtConsultar.UseVisualStyleBackColor = true;
            this.BtConsultar.Click += new System.EventHandler(this.BtConsultar_Click);
            // 
            // BtAdicionar
            // 
            this.BtAdicionar.Location = new System.Drawing.Point(341, 80);
            this.BtAdicionar.Margin = new System.Windows.Forms.Padding(2);
            this.BtAdicionar.Name = "BtAdicionar";
            this.BtAdicionar.Size = new System.Drawing.Size(102, 31);
            this.BtAdicionar.TabIndex = 22;
            this.BtAdicionar.Text = "Aicionar";
            this.BtAdicionar.UseVisualStyleBackColor = true;
            this.BtAdicionar.Click += new System.EventHandler(this.BtAdicionar_Click);
            // 
            // TxtAsignatura
            // 
            this.TxtAsignatura.Location = new System.Drawing.Point(220, 202);
            this.TxtAsignatura.Margin = new System.Windows.Forms.Padding(2);
            this.TxtAsignatura.Name = "TxtAsignatura";
            this.TxtAsignatura.Size = new System.Drawing.Size(94, 20);
            this.TxtAsignatura.TabIndex = 21;
            this.TxtAsignatura.TextChanged += new System.EventHandler(this.TxtAsignatura_TextChanged);
            // 
            // TxtEdad
            // 
            this.TxtEdad.Location = new System.Drawing.Point(220, 162);
            this.TxtEdad.Margin = new System.Windows.Forms.Padding(2);
            this.TxtEdad.Name = "TxtEdad";
            this.TxtEdad.Size = new System.Drawing.Size(94, 20);
            this.TxtEdad.TabIndex = 20;
            this.TxtEdad.TextChanged += new System.EventHandler(this.TxtEdad_TextChanged);
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(220, 121);
            this.TxtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(94, 20);
            this.TxtNombre.TabIndex = 19;
            this.TxtNombre.TextChanged += new System.EventHandler(this.TxtNombre_TextChanged);
            this.TxtNombre.Validating += new System.ComponentModel.CancelEventHandler(this.TxtNombre_Validating);
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(220, 83);
            this.TxtId.Margin = new System.Windows.Forms.Padding(2);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(94, 20);
            this.TxtId.TabIndex = 1;
            this.TxtId.TextChanged += new System.EventHandler(this.TxtId_TextChanged);
            this.TxtId.Validating += new System.ComponentModel.CancelEventHandler(this.TxtId_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(102, 202);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Asignatura";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 162);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Edad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 121);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 83);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Identificacion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(102, 254);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Profesion";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // TxtProfesion
            // 
            this.TxtProfesion.Location = new System.Drawing.Point(220, 249);
            this.TxtProfesion.Margin = new System.Windows.Forms.Padding(2);
            this.TxtProfesion.Name = "TxtProfesion";
            this.TxtProfesion.Size = new System.Drawing.Size(94, 20);
            this.TxtProfesion.TabIndex = 26;
            this.TxtProfesion.TextChanged += new System.EventHandler(this.TxtProfesion_TextChanged);
            // 
            // BtEliminar
            // 
            this.BtEliminar.Location = new System.Drawing.Point(469, 83);
            this.BtEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.BtEliminar.Name = "BtEliminar";
            this.BtEliminar.Size = new System.Drawing.Size(102, 28);
            this.BtEliminar.TabIndex = 27;
            this.BtEliminar.Text = "Eliminar";
            this.BtEliminar.UseVisualStyleBackColor = true;
            this.BtEliminar.Click += new System.EventHandler(this.BtEliminar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(469, 143);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 32);
            this.button1.TabIndex = 28;
            this.button1.Text = "Actualizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // cmbTipoId
            // 
            this.cmbTipoId.AutoSize = true;
            this.cmbTipoId.Location = new System.Drawing.Point(102, 44);
            this.cmbTipoId.Name = "cmbTipoId";
            this.cmbTipoId.Size = new System.Drawing.Size(111, 13);
            this.cmbTipoId.TabIndex = 30;
            this.cmbTipoId.Text = "Tipo de identificacion ";
            // 
            // cbmTipoid
            // 
            this.cbmTipoid.FormattingEnabled = true;
            this.cbmTipoid.Items.AddRange(new object[] {
            "",
            "CC.  identificacion",
            "T. Identidad",
            "Otro"});
            this.cbmTipoid.Location = new System.Drawing.Point(219, 44);
            this.cbmTipoid.Name = "cbmTipoid";
            this.cbmTipoid.Size = new System.Drawing.Size(121, 21);
            this.cbmTipoid.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(99, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Fecha de nac";
            // 
            // dtfFecnac
            // 
            this.dtfFecnac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtfFecnac.Location = new System.Drawing.Point(208, 291);
            this.dtfFecnac.Name = "dtfFecnac";
            this.dtfFecnac.Size = new System.Drawing.Size(102, 20);
            this.dtfFecnac.TabIndex = 31;
            // 
            // rdbFemenino
            // 
            this.rdbFemenino.AutoSize = true;
            this.rdbFemenino.Location = new System.Drawing.Point(469, 48);
            this.rdbFemenino.Name = "rdbFemenino";
            this.rdbFemenino.Size = new System.Drawing.Size(71, 17);
            this.rdbFemenino.TabIndex = 34;
            this.rdbFemenino.TabStop = true;
            this.rdbFemenino.Text = "Femenino";
            this.rdbFemenino.UseVisualStyleBackColor = true;
            // 
            // rdbMasculino
            // 
            this.rdbMasculino.AutoSize = true;
            this.rdbMasculino.Location = new System.Drawing.Point(364, 48);
            this.rdbMasculino.Name = "rdbMasculino";
            this.rdbMasculino.Size = new System.Drawing.Size(73, 17);
            this.rdbMasculino.TabIndex = 33;
            this.rdbMasculino.TabStop = true;
            this.rdbMasculino.Text = "Masculino";
            this.rdbMasculino.UseVisualStyleBackColor = true;
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClNombre,
            this.ClEdad,
            this.ClPrograma,
            this.Profesion,
            this.ClFecha,
            this.Csexo,
            this.Column2,
            this.Ctipoid});
            this.dgvDatos.Location = new System.Drawing.Point(85, 337);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.RowHeadersWidth = 51;
            this.dgvDatos.Size = new System.Drawing.Size(744, 192);
            this.dgvDatos.TabIndex = 35;
            this.dgvDatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatos_CellClick);
            this.dgvDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatos_CellContentClick);
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
            this.ClPrograma.DataPropertyName = "Asignatura";
            this.ClPrograma.HeaderText = "Asignatura";
            this.ClPrograma.MinimumWidth = 6;
            this.ClPrograma.Name = "ClPrograma";
            this.ClPrograma.ReadOnly = true;
            this.ClPrograma.Width = 125;
            // 
            // Profesion
            // 
            this.Profesion.DataPropertyName = "Profecion";
            this.Profesion.HeaderText = "Profesion ";
            this.Profesion.MinimumWidth = 6;
            this.Profesion.Name = "Profesion";
            this.Profesion.ReadOnly = true;
            this.Profesion.Width = 125;
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
            // Column2
            // 
            this.Column2.DataPropertyName = "Id";
            this.Column2.HeaderText = "Identificacion";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
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
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 540);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.rdbFemenino);
            this.Controls.Add(this.rdbMasculino);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtfFecnac);
            this.Controls.Add(this.cmbTipoId);
            this.Controls.Add(this.cbmTipoid);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtEliminar);
            this.Controls.Add(this.TxtProfesion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BtConsultar);
            this.Controls.Add(this.BtAdicionar);
            this.Controls.Add(this.TxtAsignatura);
            this.Controls.Add(this.TxtEdad);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.TxtId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BtConsultar;
        private System.Windows.Forms.Button BtAdicionar;
        private System.Windows.Forms.TextBox TxtAsignatura;
        private System.Windows.Forms.TextBox TxtEdad;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtProfesion;
        private System.Windows.Forms.Button BtEliminar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label cmbTipoId;
        private System.Windows.Forms.ComboBox cbmTipoid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtfFecnac;
        private System.Windows.Forms.RadioButton rdbFemenino;
        private System.Windows.Forms.RadioButton rdbMasculino;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClEdad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClPrograma;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profesion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Csexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ctipoid;
    }
}