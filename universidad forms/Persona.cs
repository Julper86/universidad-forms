using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace universidad_forms
{
    internal class Persona {

        private int identificación;
        private string nombre;
        private int edad;
        private string tipodeid;
        private string sexo;
        private DateTime fecnac;
        public int Id
        {
            get
            {
                return identificación;
            }
            set
            {
                if (value == 0)
                {
                    MessageBox.Show("Error: Espacio vacío"); return;
                }
                identificación = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                if (value.Length == 0)
                {
                    MessageBox.Show("Error: Espacio vacío"); return;
                }
                nombre = value;
            }
        }

        public int Edad
        {
            get
            {
                return edad;
            }
            set
            {
                if (value == 0)
                {
                    MessageBox.Show("Error: Espacio vacío"); return;
                }
                edad = value;
            }
        }
        public string Tipoid
        {
            get
            {
                return tipodeid;
            }
            set
            {
            tipodeid= value;
            }

        }
        public string Sexo
        {
            get
            {
                return sexo;
            }
            set
            {
                sexo = value;
            }

        }
        public DateTime Fecnac
        {
            get
            {
                return fecnac;
            }
            set
            {
                fecnac = value.Date;
            }

        }

    }
}
