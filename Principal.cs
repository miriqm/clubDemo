﻿using System;
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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        internal string rol;
        internal string usuario;
        private void Principal_Load(object sender, EventArgs e)
        {
            

            lblIngreso.Text = "Usuario: " + usuario + " " + " (" + rol + ")";
        }

        private void btnInscribir_Click(object sender, EventArgs e)
        {
            frmInscripcion inscripcion = new frmInscripcion();

            inscripcion.Show();
            this.Hide();
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            frmPago frmpago = new frmPago();
            frmpago.Show();
            this.Hide();
        }
    }
}
