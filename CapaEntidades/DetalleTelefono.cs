using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class DetalleTelefono
    {
        int Id {  get; set; }
        int Numero { get; set; }
        int PersonaId { get; set; }
        int OperadoraId { get; set; }

        public DetalleTelefono(int id, int numero, int personaId, int operadoraId)
        
        {
        
            Id = id;
            Numero = numero;
            PersonaId = personaId;
            OperadoraId = operadoraId;
        
        }
    }
}
