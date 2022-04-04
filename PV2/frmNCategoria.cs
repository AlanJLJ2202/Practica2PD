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
    public partial class frmNCategoria : DevExpress.XtraEditors.XtraForm
    {
       // private Categoria categoria = new Categoria();
        private int idCategoria = 0;
        public frmNCategoria()
        {
            InitializeComponent();
            CenterToScreen();
        }

        public frmNCategoria(int idCategoria)
        {
            
            InitializeComponent();
            this.idCategoria = idCategoria;
            Categoria categoria = new Categoria() { idCategoria = this.idCategoria }.GetById();
            CenterToScreen();
            //categoria.idCategoria = idCategoria;
            txtNombre.Text = categoria.descripcion;
        }

        private void frmNCategoria_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {

                MessageBox.Show("Debe completar la informacion");

                return;

            }

            if (idCategoria > 0)
            {
                if (new Categoria()
                {
                    idCategoria = idCategoria,
                    descripcion = txtNombre.Text
                }.Update() > 0)
                {
                    XtraMessageBox.Show("Categoria actualizada correctamente", "Categorias",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                if (new Categoria()
                {
                    descripcion = txtNombre.Text
                }.Add() >  0)
                {
                    XtraMessageBox.Show("Categoria almacenada correctamente", "Categorias",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    //Close();
                }
            }

           
            
            



        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}