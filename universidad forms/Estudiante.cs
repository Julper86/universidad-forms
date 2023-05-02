using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace universidad_forms
{
    internal class Estudiante : Persona
    {
        private string programaAcadémico;
        public int edadgrado;
        public string Programaacadeico
        {
            get
            {
                return programaAcadémico;
            }
            set
            {
                if (value.Length == 0)
                {
                    MessageBox.Show("Error: Espacio vacío"); return;
                }
                programaAcadémico = value;
            }
        }


       
        
    }
}