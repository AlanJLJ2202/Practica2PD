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
    public partial class frmUsuarios : DevExpress.XtraEditors.XtraForm
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            usuarioBindingSource.DataSource = new Usuario().GetAll();
            gvUsuarios.BestFitColumns();
        }
    }
}