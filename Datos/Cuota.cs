using Club_Demo.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Club_Demo.Datos
{
    internal class Cuota
    {
        private DateTime FechaPagoC;
        private string TipoCuota;
        private Double Monto;
        private string Estado;


        //public string Nueva_Cuota(E_Cuota cuota)
        //{
        //    string Rpta = "";
        //    MySqlConnection sqlCon = new MySqlConnection();
        //    try
        //    {
        //        // 
        //        sqlCon = Conexion.getInstancia().CrearConexion();


        //        string query = "INSERT INTO Cuota (FechaPagoC, TipoCuota,Monto,Estado,idPago,idPers) VALUES (@FechaPago, @TipoCuota, @Monto, @Estado, @idPago, @IdPers)";


        //        //using (SqlCommand command = new SqlCommand(query, sqlCon))
        //        MySqlCommand comando = new MySqlCommand(query, sqlCon);
        //        {
        //            comando.Parameters.AddWithValue("@FechaPago", cuota.FechaPagoC);
        //            comando.Parameters.AddWithValue("@TipoCuota", cuota.TipoCuota);                    
        //            comando.Parameters.AddWithValue("@Monto", cuota.Monto);                    
        //            comando.Parameters.AddWithValue("@Estado", cuota.Estado);
        //            comando.Parameters.AddWithValue("@idPago", cuota.idPago);
        //            comando.Parameters.AddWithValue("@IdPers", cuota.IdPers);

        //            sqlCon.Open();
        //            int rowsAffected = comando.ExecuteNonQuery();
        //            if (rowsAffected >= 1)
        //            {
        //               // MessageBox.Show("Cuota Registrada", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                Rpta = "Cuota Registrada";
                        
        //            }
        //            else
        //            {
        //               // MessageBox.Show("Ocurrio un error al registrar la cuota", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                Rpta = "Ocurrio un error al registrar la cuota";

        //            }
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        Rpta = ex.Message;
        //    }

        //    // como proceso final
        //    finally
        //    {
        //        if (sqlCon.State == ConnectionState.Open)
        //        { sqlCon.Close(); };
        //    }
        //    return Rpta;

        //}
    }
}

