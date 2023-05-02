using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace universidad_forms
{
    public partial class Form1 : Form
    {
        //crear objetos para poder abrir formularios mediante un button 
        Form2 FormEstudiante;
        Form3 FormProfesor;
        public Form1()
        {
            InitializeComponent();
            
            
        }

        private void BtAdicionar_Click(object sender, EventArgs e)
        {
            
        }

        private void BtConsultar_Click(object sender, EventArgs e)
        {
        }

        private void BtEstudiante_Click(object sender, EventArgs e)
        {
            Form2 FormEstudiante = new Form2();
            FormEstudiante.Show();
        }

        private void BtProfesor_Click(object sender, EventArgs e)
        {
            Form3 FormProfesor = new Form3();
            FormProfesor.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
              
        }
    }
}
