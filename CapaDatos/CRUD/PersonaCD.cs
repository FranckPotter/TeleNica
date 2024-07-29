using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;

namespace CapaDatos.CRUD
{
    public class PersonaCD
    {
        //Cadena de Conexion
        private ConexionCD Conexion = new ConexionCD();

        //Variables a Utilizar
        SqlDataReader LectorDatos;
        DataTable Tabla = new DataTable();
        SqlCommand Comando = new SqlCommand();

        //Obtenemos todos los registros de la tabla
        public DataTable Obtener()
        {
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "ObtenerPersonas";
            Comando.CommandType = CommandType.StoredProcedure;
            LectorDatos = Comando.ExecuteReader();
            Tabla.Load(LectorDatos);
            Conexion.CerrarConexion();

            return Tabla;
        }

        public List<Persona> ObtenerPersonas()
        {
            List<Persona> persona = new List<Persona>();

            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "ObtenerPersonas";
            Comando.CommandType = CommandType.StoredProcedure;

            LectorDatos = Comando.ExecuteReader();

            while (LectorDatos.Read())
            {
                persona.Add(new Persona
                {
                    Id = (int)LectorDatos["Id"],
                    Cedula = (int)LectorDatos["Cedula"],
                    Nombre = (string)LectorDatos["Nombres"],
                    Apellido = (string)LectorDatos["Apellidos"],
                    Edad = (int)LectorDatos["Edad"]
                });
            }

            return persona;
        }



        //Para insertar un registro en la tabla 
        public bool Insertar(Persona persona)
        {
            bool agregado = false;
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "InsertarPersona";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@Cedula", persona.Cedula);
            Comando.Parameters.AddWithValue("@Nombres", persona.Nombre);
            Comando.Parameters.AddWithValue("@Apellidos", persona.Apellido);
            Comando.Parameters.AddWithValue("@Edad", persona.Edad);
            agregado = Comando.ExecuteNonQuery() > 0;
            Comando.Parameters.Clear();
            Conexion.CerrarConexion();

            return agregado;
        }

        //Para editar un registro en la tabla cliente
        public bool Editar(Persona persona)
        {
            bool editado = false;

            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "ActualizarPersona";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@Cedula", persona.Cedula);
            Comando.Parameters.AddWithValue("@Nombre", persona.Nombre);
            Comando.Parameters.AddWithValue("@Apellido", persona.Apellido);
            Comando.Parameters.AddWithValue("@Edad", persona.Edad);
            Comando.Parameters.AddWithValue("@Id", persona.Id);
            editado = Comando.ExecuteNonQuery() > 0;
            Comando.Parameters.Clear();
            Conexion.CerrarConexion();

            return editado;
        }

        //Para eliminar un registro en la tabla 
        public bool Eliminar(int personaId)
        {
            bool eliminado = false;
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "EliminarPersona";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@Id", personaId);
            eliminado = Comando.ExecuteNonQuery() > 0;
            Comando.Parameters.Clear();
            Conexion.CerrarConexion();

            return eliminado;
        }




    }
}
