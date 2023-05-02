using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace universidad_forms
{
    public partial class Form2 : Form
    {
        //crear objetos que se usaran en el formulario
        private Estudiante objEstudiante;
        private Metodos objmetodos = new Metodos();
        public Form2()
        {
            InitializeComponent();
        }

        private void BtAdicionar_Click(object sender, EventArgs e)
            //validar si la informacion ingresada es nula o cntine caracteres no permitidos
        {
            if (ValidarId()== false || Validarnombre()==false || validarEdad()== false || ValidarPrograma()== false)
            {
                return;
            }
            //nuevo objeto de la calse estudiante
            objEstudiante = new Estudiante();

            //indicamos de donde y a donde adicionar las variables
            objEstudiante.Id = Convert.ToInt32(TxtId.Text);
            objEstudiante.Edad = Convert.ToInt32(TxtEdad.Text);
            objEstudiante.Nombre = TxtNombre.Text;
            objEstudiante.Programaacadeico = TxtPrograma.Text;
            objEstudiante.Tipoid = cmbTipoId.Text;
            
            //validar si selecciono un tipo de genero
            if(rdbMasculino.Checked == true)
            {
                objEstudiante.Sexo = rdbMasculino.Text;
            }
            else if(rdbFemenino.Checked == true)
            {
                objEstudiante.Sexo = rdbFemenino.Text;
            }else
            {
                MessageBox.Show("obligatoriamente debe selexionar un sexo");
                return;
            }
            //adicionar la fecha
            objEstudiante.Fecnac = dtfFecnac.Value.Date;

            objmetodos.adicionarproducto(objEstudiante);
            //indicar al data gred vew de donde obtener la informacion
            dgvDatos.DataSource = null;
            dgvDatos.DataSource = objmetodos.listametodos;

           

            MessageBox.Show("Datos adicionados con exito", "Adicionar", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LimpiarControles();
        }

        private void BtConsultar_Click(object sender, EventArgs e)
        {
            //button consultar
            if (ValidarId() == false ) 
            {
                return;
            }
            //consulta mediante el metodo consultar creado en la clase metodos 
            objEstudiante = objmetodos.consultarproducto(Convert.ToInt32(TxtId.Text));


            TxtEdad.Text = objEstudiante.Edad.ToString();
            TxtNombre.Text = objEstudiante.Nombre;
            TxtPrograma.Text = objEstudiante.Programaacadeico;
            cmbTipoId.Text = objEstudiante.Tipoid;
            dtfFecnac.Value = objEstudiante.Fecnac;
            
            if (objEstudiante.Sexo == "Masculino")
            {
                rdbMasculino.Checked = true;
            }
            else if(objEstudiante.Sexo == "Femenino")
            {
                rdbFemenino.Checked = true;
            }
            MessageBox.Show("Datos Consultados con exito", "Consultar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }


        private void button2_Click(object sender, EventArgs e)
        {
            //button ver año grado
            if (ValidarId() == false || Validarnombre() == false || validarEdad() == false || ValidarPrograma() == false)
            {
                return;
            }
            // al precionar el button ver año grado muestra un mensaje y le adiciona 5 a la edad ingresada 
            objEstudiante.edadgrado= objEstudiante.Edad += 5;
            MessageBox.Show("mi nombre es"+" "+TxtNombre.Text+","+"tengo"+" "+TxtEdad.Text +" "+"de edad" +""+ "y me graduo aproximadamente a los: " + objEstudiante.edadgrado);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //button eliminar 

            if (ValidarId() == false || Validarnombre() == false || validarEdad() == false || ValidarPrograma() == false)
            {
                return;
            }
           DialogResult Resultado=
                MessageBox.Show("Desea eliminar este elmento", "Confirmar eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if(Resultado == DialogResult.Yes)
            {
                objmetodos.EliminarPersona(Convert.ToInt32(TxtId.Text));
                LimpiarControles();
            }
            else
            {
                return;
            }


            
            
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            //buton actuializar 
            if (ValidarId() == false || Validarnombre() == false || validarEdad() == false || ValidarPrograma() == false)
            {
                return;
            }

            objEstudiante = new Estudiante();

            objEstudiante.Id = (Convert.ToInt32(TxtId.Text));
            objEstudiante.Nombre = TxtNombre.Text;
            objEstudiante.Edad = (Convert.ToInt32(TxtEdad.Text));
            objEstudiante.Programaacadeico = TxtPrograma.Text;

            objmetodos.ActualizarPersona(objEstudiante);

            TxtNombre.Text = objEstudiante.Nombre;
            TxtEdad.Text = objEstudiante.Edad.ToString();
            TxtPrograma.Text = objEstudiante.Programaacadeico;

            MessageBox.Show("Desea Actualizar este elmento", "Confirmar Actualizacion", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
        }

        private void TxtId_Validating(object sender, CancelEventArgs e)
        {
            ValidarId();
           
        }

        private bool ValidarId()
        {
            // validar entero: se crea una nueva varfiable de tipo int 
            // negar el entero y pedir mediante tryparce conprobar si el valor inmgresado es null 
            // mediante errorprovider  mostrar el icono de error 
            //eliminar el icono de error al comprobar que el valor es verdadero 
            int id;
            if (!int.TryParse(TxtId.Text, out id) || TxtId.Text == ""    )   
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

        private void TxtNombre_TextChanged(object sender, EventArgs e)
            //mediante textchanged asignar el metodo para validar 
        {
            Validarnombre();

        }

        private bool Validarnombre()
        {
            //validar string
            //mediante string.Isnullorempty comprovar si el string ingresado es null
            //mostrar icono de erroprovider si el valor es false
            //eliminar el icono de error si el valor es true 

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

        private void TxtPrograma_TextChanged(object sender, EventArgs e)
        {
            ValidarPrograma();

        }

        private bool ValidarPrograma()
        {
            string Programa;

            if (string.IsNullOrEmpty(TxtPrograma.Text))
            {
                errorProvider1.SetError(TxtPrograma, "ingrese una Programa valida");
                return false;
            }
            else
            {
                errorProvider1.SetError(TxtPrograma, "");
                return true;
            }
        }
        private void LimpiarControles()
        {
            //metodo para eliminar texto de los texbox
            TxtId.Clear();
            TxtNombre.Clear();
            TxtEdad.Clear();
            TxtPrograma.Clear();

        }
        

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TxtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void RdbMasculino_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void dgvDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ValidarId() == false )
            {
                return;
            }
           else  if  (e.RowIndex != -1)
            {
                TxtId.Text = dgvDatos.Rows[e.RowIndex].Cells["identificacion"].Value.ToString();
                cmbTipoId.Text = dgvDatos.Rows[e.RowIndex].Cells["Tipoid"].Value.ToString();
                TxtNombre.Text = dgvDatos.Rows[e.RowIndex].Cells["ClNombre"].Value.ToString();
                TxtEdad.Text = dgvDatos.Rows[e.RowIndex].Cells["ClEdad"].Value.ToString();
                dtfFecnac.Value = Convert.ToDateTime(dgvDatos.Rows[e.RowIndex].Cells["Fecnac"].Value);
                TxtPrograma.Text = dgvDatos.Rows[e.RowIndex].Cells["ClPrograma"].Value.ToString();

                if (dgvDatos.Rows[e.RowIndex].Cells["Sexo"].Value.ToString() == "Masculino")
                {
                    rdbFemenino.Checked = false;
                    rdbMasculino.Checked = true;
                }
                else if (dgvDatos.Rows[e.RowIndex].Cells["Sexo"].Value.ToString() == "Femenino")
                {
                    rdbMasculino.Checked = false;
                    rdbFemenino.Checked = true;
                }
            
        }
              
        }

        private void BtClose_Click(object sender, EventArgs e)
        {//button para cerrar ventana 
            Close();
        }
        
    }
    

}


