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
    public partial class frmNProducto : DevExpress.XtraEditors.XtraForm
    {
        //public Categoria categoria = new Categoria();
        private int idProducto = 0;
        public frmNProducto()
        {
            InitializeComponent();
        }

        public frmNProducto(int idProducto)
        {

            InitializeComponent();
            this.idProducto = idProducto;
            Producto producto = new Producto() { idProducto = this.idProducto }.GetById();
            CenterToScreen();
            //categoria.idCategoria = idCategoria;
            txtNombre.Text = producto.descripcion;
            cbCategoria.EditValue = producto.idCategoria;
            cbMarcas.EditValue = producto.idMarca;
            txtPrecio.Text = producto.precioUnitario.ToString();
            txtStock.Text = producto.stock.ToString();
            txtCodigo.Text = producto.codigo.ToString();
        }

        private void frmNProducto_Load(object sender, EventArgs e)
        {
            categoriaBindingSource.DataSource = new Categoria().GetAll();
            marcaBindingSource.DataSource = new Marca().GetAll();
        }
    }
}