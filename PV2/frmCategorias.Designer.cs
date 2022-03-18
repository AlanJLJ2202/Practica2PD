
namespace PV2
{
    partial class frmCategorias
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gcCategorias = new DevExpress.XtraGrid.GridControl();
            this.gvCategorias = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.gcCategorias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // gcCategorias
            // 
            this.gcCategorias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcCategorias.Location = new System.Drawing.Point(0, 0);
            this.gcCategorias.MainView = this.gvCategorias;
            this.gcCategorias.Name = "gcCategorias";
            this.gcCategorias.Size = new System.Drawing.Size(695, 458);
            this.gcCategorias.TabIndex = 0;
            this.gcCategorias.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCategorias});
            // 
            // gvCategorias
            // 
            this.gvCategorias.GridControl = this.gcCategorias;
            this.gvCategorias.Name = "gvCategorias";
            this.gvCategorias.OptionsView.ShowGroupPanel = false;
            // 
            // frmCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 458);
            this.Controls.Add(this.gcCategorias);
            this.Name = "frmCategorias";
            this.Text = "Categorias";
            ((System.ComponentModel.ISupportInitialize)(this.gcCategorias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCategorias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcCategorias;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCategorias;
    }
}