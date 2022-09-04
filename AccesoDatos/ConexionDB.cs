using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Ej1_1Carreras.Dominio;

namespace Ej1_1Carreras.AccesoDatos
{
    internal class ConexionDB
    {
        SqlConnection cnn;
        
        public ConexionDB()
        {
            cnn = new SqlConnection(Properties.Resources.cnnString);
        }

        public DataTable ConsultarSQL(string SP)
        {
            DataTable dt = new DataTable();
            cnn.Open();
            SqlCommand cmd = new SqlCommand(SP,cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            dt.Load(cmd.ExecuteReader());
            cnn.Close();
            return dt;
        }

        public int EjecutarSQL(string SP, CommandType type)
        {
            int afectadas = 0;
            cnn.Open();
            SqlCommand cmd = new SqlCommand(SP, cnn);
            afectadas = cmd.ExecuteNonQuery();
            cnn.Close();
            return afectadas;
        }

        public int ProximoDetalle()
        {
            SqlCommand cmd = new SqlCommand();
            cnn.Open();
            cmd.Connection = cnn;
            cmd.CommandText = "SP_PROXIMO_NRO_DETALLE2";
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter salida = new SqlParameter("@next",SqlDbType.Int);           
            salida.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(salida);
            cmd.ExecuteNonQuery();
            int nextID;
            if (salida.Value == DBNull.Value){
                nextID = 1;
            }
            else { nextID = Convert.ToInt32(salida.Value); }
             
            cnn.Close();          

            return nextID;
        }

        public bool ConfirmarDetalle(Dominio.Carrera carrera)
        {
            bool ok = true;
            SqlCommand cmd = new SqlCommand();
            SqlTransaction trans = null;
            try
            {
                cnn.Open();
                trans = cnn.BeginTransaction();
                cmd.Connection = cnn;
                cmd.Transaction = trans;

                
                cmd.CommandText = "SP_INSERTAR_MAESTRO";
                cmd.CommandType = CommandType.StoredProcedure;

                //Parametro de entrada
                cmd.Parameters.AddWithValue("@nombre",carrera.Nombre);              

                //Parametro de salida
                SqlParameter salida = new SqlParameter("@id_carrera", DbType.Int32);
                salida.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(salida);
                cmd.ExecuteNonQuery();

                int idCarrera = (int)salida.Value;

                SqlCommand cmdDetalle;

                int detalleNro = 1;
                foreach(DetalleCarreras item in carrera.Detalle)
                {
                    cmdDetalle = new SqlCommand("SP_INSERT_MATERIA", cnn, trans);
                    cmdDetalle.CommandType = CommandType.StoredProcedure;
                    cmdDetalle.Parameters.AddWithValue("@id_carrera",idCarrera);
                    cmdDetalle.Parameters.AddWithValue("@anio_cursado", item.AnioCursado);
                    cmdDetalle.Parameters.AddWithValue("@cuatrimestre", item.Cuatrimestre);
                    cmdDetalle.Parameters.AddWithValue("@id_materia", item.Materia.IdMateria);
                    cmdDetalle.ExecuteNonQuery();

                    detalleNro++;
                }
                trans.Commit();
            }
            catch(Exception)
            {
                if (trans != null)
                {
                    trans.Rollback();
                    ok = false;
                }
            }
            finally
            {
                if(cnn.State == ConnectionState.Open)
                {
                    cnn.Close();
                }
            }
            return ok;
        }


    }
}
