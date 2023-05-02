using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace universidad_forms
{
    internal class Metodosprofesor : Profesor

    {
       

        private List<Profesor> Listapersona;

        public Metodosprofesor()
        {
            Listapersona = new List<Profesor>();
        }

        public void adicionarproducto(Profesor clie)
        {
            Listapersona.Add(clie);

            
        }

        public Profesor consultarproducto(int IdClie)
        {
            Profesor objCli = new Profesor();

            objCli = Listapersona.Find(c => c.Id == IdClie);

            return objCli;


        }
        public void EliminarPersona(int consultarPersona)
        {
            Listapersona.RemoveAll(x => x.Id == consultarPersona);
           
        }
        public Profesor ActualizarPersona(Profesor actualizarPersona)
        {
            Profesor objprofesor = new Profesor();

            Listapersona.ForEach((personaList) =>
            {
                if (personaList.Id == actualizarPersona.Id)
                {
                    personaList.Nombre = actualizarPersona.Nombre;
                    personaList.Edad = actualizarPersona.Edad;
                    personaList.Profecion = actualizarPersona.Profecion;
                    personaList.Asignatura = actualizarPersona.Asignatura;
                }
            
                
            });
            return objprofesor = consultarproducto(actualizarPersona.Id);
        }

        public List<Profesor> listametodos
        {
            get

            {
                return Listapersona;
            }
        }











    }
}
