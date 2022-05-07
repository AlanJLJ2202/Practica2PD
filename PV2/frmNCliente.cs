using BML;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PV2
{
    public partial class frmNCliente : DevExpress.XtraEditors.XtraForm
    {
        private int idCliente = 0;

        public frmNCliente()
        {
            InitializeComponent();
            CenterToScreen();
        }

        public frmNCliente(int idCliente)
        {
            InitializeComponent();
            this.idCliente = idCliente;
            CenterToScreen();
            
            Cliente cliente = new Cliente() { idCliente = this.idCliente }.GetById();
            CenterToScreen();
            
            txtNombre.Text = cliente.nombre;
            txtApaterno.Text = cliente.apPaterno.ToString();
            txtAmaterno.Text = cliente.apPaterno.ToString();
            txtTelefono.Text = cliente.telefono.ToString();
            txtDireccion.Text = cliente.direccion.ToString();
            txtCodigo.Text = cliente.codigo.ToString();
        }




        private void frmNCliente_Load(object sender, EventArgs e)
        {
           
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
           /* if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtApaterno.Text) || string.IsNullOrEmpty(txtAmaterno.Text)
               || string.IsNullOrEmpty(txtDireccion.Text) || string.IsNullOrEmpty(txtTelefono.Text) || string.IsNullOrEmpty(txtCodigo.Text))
            {
                MessageBox.Show("Debe completar la informacion");
                return;
            } */


            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Debe completar la informacion en el Nombre");
                txtNombre.Focus();
                return;
            } 
            else if (string.IsNullOrEmpty(txtApaterno.Text))
            {
                MessageBox.Show("Debe completar la informacion en Apellido paterno");
                txtApaterno.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(txtAmaterno.Text))
            {
                MessageBox.Show("Debe completar la informacion en Apellido materno");
                txtAmaterno.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(txtDireccion.Text))
            {
                MessageBox.Show("Debe completar la informacion en Direccion");
                txtDireccion.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(txtTelefono.Text))
            {
                MessageBox.Show("Debe completar la informacion en Telefono");
                txtTelefono.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(txtCodigo.Text))
            {
                MessageBox.Show("Debe completar la informacion en Codigo");
                txtCodigo.Focus();
                return;
            }

            if (idCliente > 0)
            {
                if (new Cliente()
                {
                    idCliente = idCliente,
                    nombre = txtNombre.Text,
                    apPaterno = txtApaterno.Text,
                    apMaterno = txtAmaterno.Text,
                    direccion = txtDireccion.Text,
                    telefono = txtTelefono.Text,
                    codigo = txtCodigo.Text
                }.Update() > 0)
                {
                    XtraMessageBox.Show("Clientes actualizado correctamente", "Clientes",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                if (new Cliente()
                {
                    nombre = txtNombre.Text,
                    apPaterno = txtApaterno.Text,
                    apMaterno = txtAmaterno.Text,
                    direccion = txtDireccion.Text,
                    telefono = txtTelefono.Text,
                    codigo = txtCodigo.Text
                }.Add() > 0)
                {
                    XtraMessageBox.Show("Clientes almacenado correctamente", "Clientes",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Close();
                }
            }
        }
    }
}