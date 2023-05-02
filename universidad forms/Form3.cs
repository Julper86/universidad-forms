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
    public partial class Form3 : Form
    {

        private Profesor objprofesor;
        private Metodosprofesor objmetodos = new Metodosprofesor();
        public Form3()
        {
            InitializeComponent();
        }

        private void BtAdicionar_Click(object sender, EventArgs e)
        {
            if (ValidarId() == false || Validarnombre() == false || validarEdad() == false || ValidarAsignatura() == false || ValidarProfesion() == false)
            {
                return;
            }
            objprofesor = new Profesor();

            objprofesor.Id = Convert.ToInt32(TxtId.Text);
            objprofesor.Edad = Convert.ToInt32(TxtEdad.Text);
            objprofesor.Nombre = TxtNombre.Text;
            objprofesor.Asignatura = TxtAsignatura.Text;
            objprofesor.Profecion = TxtProfesion.Text;
            objprofesor.Tipoid = cmbTipoId.Text;

            if (rdbMasculino.Checked == true)
            {
                objprofesor.Sexo = rdbMasculino.Text;
            }
            else if (rdbFemenino.Checked == true)
            {
                objprofesor.Sexo = rdbFemenino.Text;
            }
            else
            {
                MessageBox.Show("obligatoriamente debe selexionar un sexo");
                return;
            }

            objprofesor.Fecnac = dtfFecnac.Value.Date;

            objmetodos.adicionarproducto(objprofesor);
            objmetodos.adicionarproducto(objprofesor);
            dgvDatos.DataSource = objmetodos.listametodos;
            MessageBox.Show("Datos adicionados con exito", "Adicionar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimpiarControles();
        }

        private void BtConsultar_Click(object sender, EventArgs e)
        {
            if (ValidarId() == false )
            {
                return;
            }
            objprofesor = objmetodos.consultarproducto(Convert.ToInt32(TxtId.Text));


            TxtEdad.Text = objprofesor.Edad.ToString();
            TxtNombre.Text = objprofesor.Nombre;
            TxtAsignatura.Text = objprofesor.Asignatura;
            TxtProfesion.Text = objprofesor.Profecion;
            if (objprofesor.Sexo == "Masculino")
            {
                rdbMasculino.Checked = true;
            }
            else if (objprofesor.Sexo == "Femenino")
            {
                rdbFemenino.Checked = true;
            }
            MessageBox.Show("Datos Consultados con exito", "Consultar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ValidarId() == false || Validarnombre() == false || validarEdad() == false || ValidarAsignatura() == false || ValidarProfesion() == false)
            {
                return;
            }
            MessageBox.Show("hola mi nombre es, " + TxtNombre.Text + ": soy ," + TxtProfesion.Text + ": Doncente de la asignatura :" + TxtAsignatura.Text);
        }

        private void BtEliminar_Click(object sender, EventArgs e)
        {
            if (ValidarId() == false || Validarnombre() == false || validarEdad() == false || ValidarAsignatura() == false || ValidarProfesion() == false)
            {
                return;
            }

            DialogResult Resultado =
                MessageBox.Show("Desea eliminar este elmento", "Confirmar eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (Resultado == DialogResult.Yes)
            {
                objmetodos.EliminarPersona(Convert.ToInt32(TxtId.Text));
                LimpiarControles();
            }
            else
            {
                return;
            }
            objmetodos.EliminarPersona(Convert.ToInt32(TxtId.Text));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidarId() == false || Validarnombre() == false || validarEdad() == false || ValidarAsignatura() == false || ValidarProfesion() == false)
            {
                return;
            }
            objprofesor = new Profesor();

            objprofesor.Id = (Convert.ToInt32(TxtId.Text));
            objprofesor.Nombre = TxtNombre.Text;
            objprofesor.Edad = (Convert.ToInt32(TxtEdad.Text));
            objprofesor.Profecion = TxtProfesion.Text;
            objprofesor.Asignatura = TxtAsignatura.Text;

            objmetodos.ActualizarPersona(objprofesor);

            TxtNombre.Text = objprofesor.Nombre;
            TxtEdad.Text = objprofesor.Edad.ToString();
            TxtProfesion.Text = objprofesor.Profecion;
            TxtAsignatura.Text = objprofesor.Asignatura;

            MessageBox.Show("Desea Actualizar este elmento", "Confirmar Actualizacion", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void TxtId_TextChanged(object sender, EventArgs e)
        {

            ValidarId();

        }

        private bool ValidarId()
        {
            int id;
            if (!int.TryParse(TxtId.Text, out id) || TxtId.Text == "")
            {
                errorProvider1.SetError(TxtId, "ingrese una identificacion valida");
                return false;
            }
            else
            {
                errorProvider1.SetError(TxtId, "");
                return true;
            }
        }

        private void TxtId_Validating(object sender, CancelEventArgs e)
        {

        }

        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtEdad_TextChanged(object sender, EventArgs e)
        {

            validarEdad();

        }

        private bool validarEdad()
        {
            int Edad;
            if (!int.TryParse(TxtEdad.Text, out Edad) || TxtId.Text == "")
            {
                errorProvider1.SetError(TxtEdad, "ingrese una Edad valida");
                return false;
            }
            else
            {
                errorProvider1.SetError(TxtEdad, "");
                return true;
            }
        }

        private void TxtAsignatura_TextChanged(object sender, EventArgs e)
        {

            ValidarAsignatura();

        }

        private bool ValidarAsignatura()
        {


            if (string.IsNullOrEmpty(TxtAsignatura.Text))
            {
                errorProvider1.SetError(TxtAsignatura, "ingrese una asignatura valida");
                return false;
            }
            else
            {
                errorProvider1.SetError(TxtAsignatura, "");
                return true;
            }
        }

        private void TxtProfesion_TextChanged(object sender, EventArgs e)
        {

            ValidarProfesion();

        }

        private bool ValidarProfesion()
        {


            if (string.IsNullOrEmpty(TxtProfesion.Text))
            {
                errorProvider1.SetError(TxtProfesion, "ingrese una asignatura valida");
                return false;
            }
            else
            {
                errorProvider1.SetError(TxtProfesion, "");
                return true;
            }
        }

        private void TxtNombre_Validating(object sender, CancelEventArgs e)
        {

            Validarnombre();

        }

        private bool Validarnombre()
        {


            if (string.IsNullOrEmpty(TxtNombre.Text))
            {
                errorProvider1.SetError(TxtNombre, "ingrese una nombre valida");
                return false;
            }
            else
            {
                errorProvider1.SetError(TxtNombre, "");
                return true;
            }
        }
        private void LimpiarControles()
        {
            TxtId.Clear();
            TxtNombre.Clear();
            TxtEdad.Clear();
            TxtAsignatura.Clear();
            TxtProfesion.Clear();
            
        }

        private void dgvDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
