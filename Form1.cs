using Org.BouncyCastle.Pqc.Crypto.Lms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Club_Demo;

namespace Club_Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtUser_Ente(object sender, EventArgs e)
        {

        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            // este evento se ejecuta cuando llega el foco
            if(txtUser.Text == "usuario")
            {
                txtUser.Text = "";
            }

        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            // este evento se ejecuta cuando se va el foco
            if (txtUser.Text == "")
            {
                txtUser.Text = "usuario";
            }

        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if(txtPass.Text == "contraseña")
            {
                txtPass.Text = "";
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = "contraseña";
                txtPass.UseSystemPasswordChar = false;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DataTable tablaLogin = new DataTable(); // es la que recibe los datos desde el formulario
            Usuario dato = new Usuario(); // variable que contiene todas las caracteristicas de la clase
            tablaLogin = dato.Log_Usu(txtUser.Text, txtPass.Text);

            if(tablaLogin.Rows.Count > 0 ) { 
                MessageBox.Show("Ingreso Exitoso! ", "MENSAJE DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // una vez que tenemos la conexion establecida PASAMOS al 
                // formulario PRINCIPAL. Se debe "Instanciar" un objeto de la clase formulario principal

                Principal principal = new Principal();

                principal.rol = Convert.ToString(tablaLogin.Rows[0][0]);
                principal.usuario = Convert.ToString(txtUser.Text);
                principal.Show();
                this.Hide();
            }
            else
                
            {
                MessageBox.Show("Usuario y/o password incorrecto");
            }
            
        }
    }
}
