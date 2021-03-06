using BML;
using DevExpress.XtraEditors;
using System;

namespace PV2
{
    public partial class frmNProducto : DevExpress.XtraEditors.XtraForm
    {
        //public Categoria categoria = new Categoria();
        private int idProducto = 0;
        public frmNProducto()
        {
            InitializeComponent();
            CenterToScreen();
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

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtPrecio.Text) || string.IsNullOrEmpty(txtStock.Text)
                || string.IsNullOrEmpty(txtCodigo.Text) || string.IsNullOrEmpty(cbCategoria.Text) || string.IsNullOrEmpty(cbMarcas.Text))
            {
                XtraMessageBox.Show("Debe completar la informacion", "Error 404");
                return;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}