﻿using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PV2
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        public frmLogin()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Login();
        }

        public void Login()
        {
            try
            {
                string con = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
                using (SqlConnection conexion = new SqlConnection(con))
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT nombre, password FROM usuarios where='" + txtUsuario.Text + "' AND password='" + txtClave.Text + "'", conexion))
                    {
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            MessageBox.Show("Login Exitoso");
                        }
                        else
                        {
                            MessageBox.Show("Login Fallido");
                        }
                    }
                }
            }
            catch(Exception Ex)
            {

            }
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}