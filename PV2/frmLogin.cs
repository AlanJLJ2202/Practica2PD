using BML;
using DevExpress.XtraEditors;
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

        Usuario usuario = new Usuario();
        string nombre = "";
        string password = "";
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
            

            if (string.IsNullOrEmpty(txtUsuario.Text) || string.IsNullOrEmpty(txtClave.Text))
            {

                MessageBox.Show("Debe completar la informacion");

                return;

            }

            
            if(new Usuario()
            {
                nombre = txtUsuario.Text,
                password = txtClave.Text
            }.Login() != null)
            {
                
                MessageBox.Show("Ingreso correctamente");
                this.Hide();
                new frmMain { Text = "Principal" }.ShowDialog();
                this.Show();
               
            }
            else
            {
                MessageBox.Show("No pudiste ingresar");
            }

            }

         
            
    
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
           
        }

        private void Clean()
        {
            txtUsuario.Text = "";
            txtClave.Text = "";
            txtUsuario.Focus();
        }
    }
}