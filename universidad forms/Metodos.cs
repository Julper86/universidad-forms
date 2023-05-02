using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace universidad_forms
{//eredar todo lo que contiene la clase persona(clase padre) a la clase estudinate(clase hijo)
    internal class Metodos: Estudiante
    {
       
        //crear una nueva lista de la clase estudiante 
        private List<Estudiante> Listapersona;

        public Metodos()
        {
            //indicar que listapersoan es una nueva lista de la clase estudiante 
            Listapersona = new List<Estudiante>();
        }

        public void adicionarproducto(Estudiante clie)
        {//adicionar a la lista indicada con .add
            Listapersona.Add(clie);

          
        }

        public Estudiante consultarproducto(int IdClie)
        {//consultar de la lista indicada con el .find
            Estudiante objCli = new Estudiante ();

            objCli = Listapersona.Find(c => c.Id == IdClie);

            return objCli;


        }
        public void EliminarPersona(int consultarPersona)
            //remover todo de una lista con removeall
        {
            Listapersona.RemoveAll(x => x.Id == consultarPersona);
           
        }

        public Estudiante ActualizarPersona(Estudiante actualizarPersona)
        {//actualizar lo indiicado
            //consultar de una lista con foreach
            Estudiante objPersona = new Estudiante();

            Listapersona.ForEach((personaList) =>
            {
                if (personaList.Id == actualizarPersona.Id)
                {
                    personaList.Nombre = actualizarPersona.Nombre;
                    personaList.Edad = actualizarPersona.Edad;
                    personaList.Programaacadeico = actualizarPersona.Programaacadeico;
                    personaList.Tipoid = actualizarPersona.Tipoid;
                    personaList.Sexo = actualizarPersona.Sexo;  
                    personaList.Fecnac = actualizarPersona.Fecnac;
                }
                MessageBox.Show("persona actualizada");
            });
            return objPersona = consultarproducto(actualizarPersona.Id);
        }
        public List<Estudiante> listametodos
        {// crear lista para el data gred vew 
            get

            {
                return Listapersona;
            }
        }











    }
}

