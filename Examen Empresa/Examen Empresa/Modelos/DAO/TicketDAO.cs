using Examen_Empresa.Modelos.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Empresa.Modelos.DAO
{
    public class TicketDAO : Conexion
    {
        SqlCommand comando = new SqlCommand();

        public bool InsertarTicket(Ticket ticket)
        {
            bool inserto = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" INSERT INTO TICKET ");
                sql.Append(" VALUES (@NombreCliente, @FechaInicio, @Soporte, @Estado); ");

                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.Parameters.Clear();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("@NombreCliente", SqlDbType.NVarChar, 50).Value = ticket.NombreCliente;
                comando.Parameters.Add("@Estado", SqlDbType.NVarChar, 50).Value = ticket.Estado;
                comando.Parameters.Add("@Soporte", SqlDbType.NVarChar, 50).Value = ticket.Soporte;
                comando.Parameters.Add("@FechaInicio", SqlDbType.DateTime).Value = ticket.FechaInicio;
                comando.ExecuteNonQuery();
                MiConexion.Close();
                inserto = true;
            }
            catch (Exception)
            {
                inserto = false;
            }
            return inserto;
        }

        public DataTable GetTicket()
        {
            DataTable dt = new DataTable();
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" SELECT * FROM TICKET ");

                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                SqlDataReader dr = comando.ExecuteReader();
                dt.Load(dr);
                MiConexion.Close();
            }
            catch (Exception)
            {
                throw;
            }
            return dt;
        }

        public bool ActulizarTicket(Ticket ticket)
        {
            bool modifico = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" UPDATE TICKET ");
                sql.Append(" SET NOMBRECLIENTE = @NombreCliente, SOPORTE = @Soporte, ESTADO = @Estado, FECHAINICIO = @FechaInicio ");
                sql.Append(" WHERE ID = @Id; ");

                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.Parameters.Clear();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("@Id", SqlDbType.Int).Value = ticket.Id;
                comando.Parameters.Add("@NombreCliente", SqlDbType.NVarChar, 50).Value = ticket.NombreCliente;
                comando.Parameters.Add("@Soporte", SqlDbType.NVarChar, 50).Value = ticket.Soporte;
                comando.Parameters.Add("@Estado", SqlDbType.NVarChar, 50).Value = ticket.Estado;
                comando.Parameters.Add("@FechaInicio", SqlDbType.DateTime).Value = ticket.FechaInicio;
                comando.ExecuteNonQuery();
                modifico = true;
                MiConexion.Close();
            }
            catch (Exception)
            {
                return modifico;
            }
            return modifico;
        }

        public bool EliminarTicket(int id)
        {
            bool modifico = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" DELETE FROM TICKET ");
                sql.Append(" WHERE ID = @Id; ");

                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.Parameters.Clear();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("@Id", SqlDbType.Int).Value = id;
                comando.ExecuteNonQuery();
                modifico = true;
                MiConexion.Close();
            }
            catch (Exception)
            {
                return modifico;
            }
            return modifico;
        }
    }
}
