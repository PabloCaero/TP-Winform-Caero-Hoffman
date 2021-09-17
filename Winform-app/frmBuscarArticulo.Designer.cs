
namespace Winform_app
{
    partial class frmBuscarArticulo
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
            this.lblBuscarCodigo = new System.Windows.Forms.Label();
            this.lblBuscarNombre = new System.Windows.Forms.Label();
            this.btnBuscarNombre = new System.Windows.Forms.Button();
            this.btnBuscarCodigo = new System.Windows.Forms.Button();
            this.txtBuscarCodigo = new System.Windows.Forms.TextBox();
            this.txtBuscarNombre = new System.Windows.Forms.TextBox();
            this.dgvBuscarArticulo = new System.Windows.Forms.DataGridView();
            this.pbxBuscarArticulo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarArticulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBuscarArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBuscarCodigo
            // 
            this.lblBuscarCodigo.AutoSize = true;
            this.lblBuscarCodigo.Location = new System.Drawing.Point(21, 28);
            this.lblBuscarCodigo.Name = "lblBuscarCodigo";
            this.lblBuscarCodigo.Size = new System.Drawing.Size(94, 13);
            this.lblBuscarCodigo.TabIndex = 1;
            this.lblBuscarCodigo.Text = "Buscar por Codigo";
            // 
            // lblBuscarNombre
            // 
            this.lblBuscarNombre.AutoSize = true;
            this.lblBuscarNombre.Location = new System.Drawing.Point(21, 60);
            this.lblBuscarNombre.Name = "lblBuscarNombre";
            this.lblBuscarNombre.Size = new System.Drawing.Size(98, 13);
            this.lblBuscarNombre.TabIndex = 2;
            this.lblBuscarNombre.Text = "Buscar por Nombre";
            // 
            // btnBuscarNombre
            // 
            this.btnBuscarNombre.Location = new System.Drawing.Point(231, 53);
            this.btnBuscarNombre.Name = "btnBuscarNombre";
            this.btnBuscarNombre.Size = new System.Drawing.Size(75, 20);
            this.btnBuscarNombre.TabIndex = 3;
            this.btnBuscarNombre.Text = "Buscar";
            this.btnBuscarNombre.UseVisualStyleBackColor = true;
            this.btnBuscarNombre.Click += new System.EventHandler(this.btnBuscarNombre_Click);
            // 
            // btnBuscarCodigo
            // 
            this.btnBuscarCodigo.Location = new System.Drawing.Point(231, 21);
            this.btnBuscarCodigo.Name = "btnBuscarCodigo";
            this.btnBuscarCodigo.Size = new System.Drawing.Size(75, 20);
            this.btnBuscarCodigo.TabIndex = 4;
            this.btnBuscarCodigo.Text = "Buscar";
            this.btnBuscarCodigo.UseVisualStyleBackColor = true;
            this.btnBuscarCodigo.Click += new System.EventHandler(this.btnBuscarCodigo_Click);
            // 
            // txtBuscarCodigo
            // 
            this.txtBuscarCodigo.Location = new System.Drawing.Point(125, 21);
            this.txtBuscarCodigo.Name = "txtBuscarCodigo";
            this.txtBuscarCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtBuscarCodigo.TabIndex = 5;
            // 
            // txtBuscarNombre
            // 
            this.txtBuscarNombre.Location = new System.Drawing.Point(125, 53);
            this.txtBuscarNombre.Name = "txtBuscarNombre";
            this.txtBuscarNombre.Size = new System.Drawing.Size(100, 20);
            this.txtBuscarNombre.TabIndex = 6;
            // 
            // dgvBuscarArticulo
            // 
            this.dgvBuscarArticulo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscarArticulo.Location = new System.Drawing.Point(24, 88);
            this.dgvBuscarArticulo.Name = "dgvBuscarArticulo";
            this.dgvBuscarArticulo.Size = new System.Drawing.Size(282, 78);
            this.dgvBuscarArticulo.TabIndex = 7;
            // 
            // pbxBuscarArticulo
            // 
            this.pbxBuscarArticulo.Location = new System.Drawing.Point(24, 182);
            this.pbxBuscarArticulo.Name = "pbxBuscarArticulo";
            this.pbxBuscarArticulo.Size = new System.Drawing.Size(282, 231);
            this.pbxBuscarArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxBuscarArticulo.TabIndex = 8;
            this.pbxBuscarArticulo.TabStop = false;
            // 
            // frmBuscarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(330, 436);
            this.Controls.Add(this.pbxBuscarArticulo);
            this.Controls.Add(this.dgvBuscarArticulo);
            this.Controls.Add(this.txtBuscarNombre);
            this.Controls.Add(this.txtBuscarCodigo);
            this.Controls.Add(this.btnBuscarCodigo);
            this.Controls.Add(this.btnBuscarNombre);
            this.Controls.Add(this.lblBuscarNombre);
            this.Controls.Add(this.lblBuscarCodigo);
            this.Name = "frmBuscarArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Articulo";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarArticulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxBuscarArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblBuscarCodigo;
        private System.Windows.Forms.Label lblBuscarNombre;
        private System.Windows.Forms.Button btnBuscarNombre;
        private System.Windows.Forms.Button btnBuscarCodigo;
        private System.Windows.Forms.TextBox txtBuscarCodigo;
        private System.Windows.Forms.TextBox txtBuscarNombre;
        private System.Windows.Forms.DataGridView dgvBuscarArticulo;
        private System.Windows.Forms.PictureBox pbxBuscarArticulo;
    }
}