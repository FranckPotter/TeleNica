using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CapaNegocio.PersonaCD;

namespace CapaNegocio
{
    public class PersonaCD
    {
        public class PersonaCN
        {
            private PersonaCD personaCD = new PersonaCD();

            //Obtener las personas desde la Capa de datos
            public DataTable Obtener()
            {
                DataTable Tabla = new DataTable();
                Tabla = personaCD.Obtener();
                return Tabla;
            }

            public List<Persona> ObtenerPersonas()
            {
                return personaCD.ObtenerPersonas();
            }

            //Agregar la persona a la Capa de datos
            public bool Insertar(Persona persona)
            {
                return personaCD.Insertar(persona);
            }

            //Editar la persona a la Capa de datos
            public bool Editar(Persona persona)
            {
                return personaCD.Editar(persona);
            }

            //Eliminar la persona a la Capa de datos
            public bool Eliminar(int personaId)
            {
                return personaCD.Eliminar(personaId);
            }
        }
    }
}
