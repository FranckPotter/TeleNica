using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Operadora
    {
        int Id { get; set; }
        int Codigo { get; set; }
        string Descripcion { get; set; }

        public Operadora(int id, int codigo, string descripcion) 
        { 
            Id = id;
            Codigo = codigo;
            Descripcion = descripcion;
        
        }

        
    }
}
