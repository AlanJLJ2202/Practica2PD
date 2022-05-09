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

        double importe = 0;
        public frmNVenta()
        {
            InitializeComponent();
        }

        private void frmNVenta_Load(object sender, EventArgs e)
        {
            ventasBindingSource.DataSource = new Ventas().GetAll();
            productoBindingSource.DataSource = new Producto().GetAll();
            clienteBindingSource.DataSource = new Cliente().GetAll();
            usuarioBindingSource.DataSource = new Usuario().GetAll();
            gvVentas.BestFitColumns();
        }

        private void gcVentas_Click(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if(checkMayoreo.CheckState == CheckState.Checked)
            {
                importe = 12.00;
                lblImporte.Text = "$" + importe.ToString();
            }
            else
            {
                importe = 15.00;
                lblImporte.Text = "$" + importe.ToString();
            }
            
        }
    }
}