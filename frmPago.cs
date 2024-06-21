using Club_Demo.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Club_Demo
{
    public partial class frmPago : Form
    {
        public frmPago()
        {
            InitializeComponent();
        }

        private void btnPago_Click(object sender, EventArgs e)
        {
            E_Pago pago = new E_Pago();
            E_Cuota cuota = new E_Cuota();

            pago.idPers = Convert.ToInt32(txtIdPers.Text.Trim());
            cuota.IdPers = Convert.ToInt32(txtIdPers.Text.Trim());
            cuota.TipoCuota = cmbTipoCuota.Text.Trim();
            pago.monto = Convert.ToDouble(txtMonto.Text.Trim());
            cuota.Monto = pago.monto = Convert.ToDouble(txtMonto.Text.Trim());
            pago.fechaPago = DateTime.Now;
            cuota.FechaPagoC = DateTime.Now;
            cuota.Estado = "PAGADO";


            Datos.Pago nuevoPago = new Datos.Pago();
            Datos.Cuota nuevaCuota = new Datos.Cuota();

            // Metodo que interactua con la bd
            nuevoPago.Nuevo_Pago(pago, cuota);
          //  nuevaCuota.Nueva_Cuota(cuota);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal();
            principal.Show();
            this.Hide();
        }
    }
}
