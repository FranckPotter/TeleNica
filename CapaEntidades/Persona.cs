using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Persona
    {
        int Id { get; set; }
        string Cedula { get; set; }
        string Nombre { get; set; }
        string Apellido { get; set; }
        int Edad { get; set; }
        int SexoId { get; set; }

        public Persona(int id, string cedula, string nombre, string apellido, int edad, int sexoId) 
        {
            Id = id;
            Cedula = cedula;    
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
            SexoId = sexoId;

        
        }




        
    }
}
