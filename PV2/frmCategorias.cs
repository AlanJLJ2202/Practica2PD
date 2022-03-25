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
    }
}