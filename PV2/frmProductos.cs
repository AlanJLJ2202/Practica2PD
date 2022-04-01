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
    public partial class frmProductos : DevExpress.XtraEditors.XtraForm
    {
        
        public frmProductos()
        {
            InitializeComponent();
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            productoBindingSource.DataSource = new Producto().GetAll();
            categoriaBindingSource.DataSource = new Categoria().GetAll();
            marcaBindingSource.DataSource = new Marca().GetAll();
            gvProductos.BestFitColumns();
        }
    }
}