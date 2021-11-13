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
    public class TipoDAO : Conexion
    {
        SqlCommand comando = new SqlCommand();

        public bool InsertarSoporte(Tipo tipo)
        {
            bool inserto = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" INSERT INTO TIPOS ");
                sql.Append(" VALUES (@Soporte); ");

                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.Parameters.Clear();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("@Soporte", SqlDbType.NVarChar, 50).Value = tipo.Soporte;
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

        public DataTable GetSoporte()
        {
            DataTable dt = new DataTable();
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" SELECT * FROM TIPOS ");

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

        public bool ActulizarSoporte(Tipo tipo)
        {
            bool modifico = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" UPDATE TIPOS ");
                sql.Append(" SET SOPORTE = @Soporte ");
                sql.Append(" WHERE ID = @Id; ");

                comando.Connection = MiConexion;
                MiConexion.Open();
                comando.Parameters.Clear();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Parameters.Add("@Id", SqlDbType.Int).Value = tipo.Id;
                comando.Parameters.Add("@Soporte", SqlDbType.NVarChar, 50).Value = tipo.Soporte;
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

        public bool EliminarSoporte(int id)
        {
            bool modifico = false;
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" DELETE FROM TIPOS ");
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
