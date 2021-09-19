
namespace Winform_app
{
    partial class FrmDetalleDeArticulo
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
            this.dgvDetalleArticulo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDetalleArticulo
            // 
            this.dgvDetalleArticulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleArticulo.Location = new System.Drawing.Point(12, 12);
            this.dgvDetalleArticulo.Name = "dgvDetalleArticulo";
            this.dgvDetalleArticulo.Size = new System.Drawing.Size(699, 141);
            this.dgvDetalleArticulo.TabIndex = 0;
            // 
            // FrmDetalleDeArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(739, 165);
            this.Controls.Add(this.dgvDetalleArticulo);
            this.Name = "FrmDetalleDeArticulo";
            this.Text = "DetalleDeArticulo";
            this.Load += new System.EventHandler(this.FrmDetalleDeArticulo_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleArticulo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDetalleArticulo;
    }
}