using Club_Demo.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Club_Demo.Datos
{
    internal class Pago
    {
        public string Nuevo_Pago(E_Pago pago)
        {
            string Rpta = "";
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                // SP NuevaPers realiza el insert en la bd
                sqlCon = Conexion.getInstancia().CrearConexion();              

               
                string query = "INSERT INTO Pago (IdPers, Monto, FechaPago) VALUES (@IdPers, @Monto, @FechaPago)";

                //using (SqlCommand command = new SqlCommand(query, sqlCon))
                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                {
                    comando.Parameters.AddWithValue("@IdPers", pago.idPers);
                    comando.Parameters.AddWithValue("@Monto", pago.monto);
                    comando.Parameters.AddWithValue("@FechaPago", pago.fechaPago);
                    // comando.Parameters.AddWithValue("@TipoCuota", pago.TipoCuota);

                    sqlCon.Open();
                    Rpta = comando.ExecuteNonQuery() >= 1 ? "Ok" : "Ocurrio un error al registar el Pago";
                    
                }                            
                

            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }

            // como proceso final
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                { sqlCon.Close(); };
            }
            return Rpta;

        }
    }
}

