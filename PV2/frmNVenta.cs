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
    public partial class frmNVenta : DevExpress.XtraEditors.XtraForm
    {
        public frmNVenta()
        {
            InitializeComponent();
        }

        private void frmNVenta_Load(object sender, EventArgs e)
        {
            ventasBindingSource.DataSource = new Ventas().GetAll();
            gvVentas.BestFitColumns();
        }
    }
}