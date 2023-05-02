namespace universidad_forms
{
    partial class Form1
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
            this.BtEstudiante = new System.Windows.Forms.Button();
            this.BtProfesor = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtEstudiante
            // 
            this.BtEstudiante.Location = new System.Drawing.Point(85, 316);
            this.BtEstudiante.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtEstudiante.Name = "BtEstudiante";
            this.BtEstudiante.Size = new System.Drawing.Size(213, 106);
            this.BtEstudiante.TabIndex = 10;
            this.BtEstudiante.Text = "Estudiante";
            this.BtEstudiante.UseVisualStyleBackColor = true;
            this.BtEstudiante.Click += new System.EventHandler(this.BtEstudiante_Click);
            // 
            // BtProfesor
            // 
            this.BtProfesor.Location = new System.Drawing.Point(681, 316);
            this.BtProfesor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtProfesor.Name = "BtProfesor";
            this.BtProfesor.Size = new System.Drawing.Size(218, 106);
            this.BtProfesor.TabIndex = 11;
            this.BtProfesor.Text = "Profesor";
            this.BtProfesor.UseVisualStyleBackColor = true;
            this.BtProfesor.Click += new System.EventHandler(this.BtProfesor_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::universidad_forms.Properties.Resources.unilibre;
            this.pictureBox1.Location = new System.Drawing.Point(381, 71);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(246, 225);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1031, 620);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtProfesor);
            this.Controls.Add(this.BtEstudiante);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtEstudiante;
        private System.Windows.Forms.Button BtProfesor;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

