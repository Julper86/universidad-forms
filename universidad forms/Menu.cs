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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip1.Visible = true;
           
        }

        private void nuevoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1 ();
            frm1.Show();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip1.Visible = false;
           
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            toolStrip1.Visible = false;
        }
    }
}
