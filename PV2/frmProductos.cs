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

        private void btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form form in Application.OpenForms)

                if (form.GetType() == typeof(frmNProducto))
                {
                    form.Activate();
                    return;
                }
            new frmNProducto { Text = "Productos" }.Show();
            btnActualizar.PerformClick();
        }

        private void btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frmNProducto((int)gvProductos.GetFocusedRowCellValue("idProducto")) { Text = "Productos" }.ShowDialog();
            btnActualizar.PerformClick();
        }

        private void btnActualizar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            productoBindingSource.DataSource = new Producto().GetAll();
        }
    }
}