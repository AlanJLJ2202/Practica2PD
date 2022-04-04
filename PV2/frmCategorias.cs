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
    public partial class frmCategorias : DevExpress.XtraEditors.XtraForm
    {

        //Categoria categoria = new Categoria();

        public frmCategorias()
        {
            InitializeComponent();
        }

        private void frmCategorias_Load(object sender, EventArgs e)
        {
            categoriaBindingSource.DataSource = new Categoria().GetAll();
            gvCategorias.BestFitColumns();
        }

        private void btnNuevo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form form in Application.OpenForms)

                if (form.GetType() == typeof(frmNCategoria))
                {
                    form.Activate();
                    return;
                }
            new frmNCategoria { Text = "Nueva Categoria" }.Show();
            btnActualizar.PerformClick();
        }

        private void btnActualizar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            categoriaBindingSource.DataSource = new Categoria().GetAll();
        }

        private void btnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int idCategoria = (int)gvCategorias.GetFocusedRowCellValue("idCategoria");

            if (new Categoria()
            {
                idCategoria = idCategoria
            }.Delete() > 0)
            {
                XtraMessageBox.Show("Categoria eliminada correctamente", Application.ProductName,
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnActualizar.PerformClick();
            }
            else
                XtraMessageBox.Show("No se elimino correctamente", Application.ProductName,
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnModificar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frmNCategoria((int)gvCategorias.GetFocusedRowCellValue("idCategoria")) { Text = "Categorias" }.ShowDialog();
            btnActualizar.PerformClick();
        }
    }
}