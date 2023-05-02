using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace universidad_forms
{
    internal class Profesor : Persona
    {
        private string nombreProfesor;
        private string asignatura;
        private string profesión;
        
        public string Nombreprofe
        {
            get
            {
                return nombreProfesor;
            }
            set
            {
                if (value.Length == 0)
                {
                    MessageBox.Show("Error: Espacio vacío"); return;
                }
                nombreProfesor = value;
            }
        }

        public string Asignatura
        {
            get
            {
                return asignatura;
            }
            set
            {
                if (value.Length == 0)
                {
                    MessageBox.Show("Error: Espacio vacío"); return;
                }
                asignatura = value;
            }
        }

        public string Profecion
        {
            get
            {
                return profesión;
            }
            set
            {
                if (value.Length == 0)
                {
                    MessageBox.Show("Error: Espacio vacío"); return;
                }
                profesión = value;
            }
        }

        
        }
    }

