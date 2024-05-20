using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoCsharp.OpLogicos
{
    public partial class frmOpLogicos : Form
    {
        public frmOpLogicos()
        {
            InitializeComponent();
        }

        int numero1;
        int numero2;
        bool resultado;

        private void asignacion()
        {
            numero1 = Convert.ToInt32(txtNumero1.Text);
            numero2 = Convert.ToInt32(txtNumero2.Text);
        }

        private void frmOpLogicos_Load(object sender, EventArgs e)
        {

        }

        private void Mayorque()
        {
            asignacion();

            if (numero1 > numero2)
            {
                resultado = true;
            }
            else
            {
                resultado = false;
            }

            lblResultado.Text = resultado.ToString();
        }

        private void Menorque()
        {
            asignacion();

            if (numero1 < numero2)
            {
                resultado = true;
            }
            else
            {
                resultado = false;
            }

            lblResultado.Text = resultado.ToString();
        }

        private void btnMayor_Click(object sender, EventArgs e)
        {


        }
    }
}
