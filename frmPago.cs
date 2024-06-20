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

            pago.idPers = Convert.ToInt32(txtIdPers.Text.Trim());
            pago.monto = Convert.ToDouble(txtMonto.Text.Trim());
            pago.fechaPago = DateTime.Now;

            Datos.Pago nuevoPago = new Datos.Pago();
            nuevoPago.Nuevo_Pago(pago);
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
