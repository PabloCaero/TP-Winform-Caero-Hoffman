
namespace Winform_app
{
    partial class FormMenu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.btnListarArt = new System.Windows.Forms.Button();
            this.btnBuscarArt = new System.Windows.Forms.Button();
            this.btnAgregarArt = new System.Windows.Forms.Button();
            this.btnModificarArt = new System.Windows.Forms.Button();
            this.btnEliminarArt = new System.Windows.Forms.Button();
            this.btnVerDetalleArt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnListarArt
            // 
           this.btnListarArt.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnListarArt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnListarArt.Font = new System.Drawing.Font("Malgun Gothic Semilight", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarArt.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnListarArt.Image = ((System.Drawing.Image)(resources.GetObject("btnListarArt.Image")));
            this.btnListarArt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListarArt.Location = new System.Drawing.Point(12, 46);
            this.btnListarArt.Name = "btnListarArt";
            this.btnListarArt.Size = new System.Drawing.Size(231, 37);
            this.btnListarArt.TabIndex = 0;
            this.btnListarArt.Text = "Listar Articulos";
            this.btnListarArt.UseVisualStyleBackColor = false;
            this.btnListarArt.Click += new System.EventHandler(this.btnListarArt_Click);
            // 
            // btnBuscarArt
            // 
            this.btnBuscarArt.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnBuscarArt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarArt.Font = new System.Drawing.Font("Malgun Gothic Semilight", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarArt.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnBuscarArt.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarArt.Image")));
            this.btnBuscarArt.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnBuscarArt.Location = new System.Drawing.Point(12, 98);
            this.btnBuscarArt.Name = "btnBuscarArt";
            this.btnBuscarArt.Size = new System.Drawing.Size(231, 38);
            this.btnBuscarArt.TabIndex = 1;
            this.btnBuscarArt.Text = "Buscar Articulo";
            this.btnBuscarArt.UseVisualStyleBackColor = false;
            // 
            // btnAgregarArt
            // 
            this.btnAgregarArt.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAgregarArt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarArt.Font = new System.Drawing.Font("Malgun Gothic Semilight", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarArt.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnAgregarArt.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarArt.Image")));
            this.btnAgregarArt.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAgregarArt.Location = new System.Drawing.Point(12, 151);
            this.btnAgregarArt.Name = "btnAgregarArt";
            this.btnAgregarArt.Size = new System.Drawing.Size(231, 39);
            this.btnAgregarArt.TabIndex = 2;
            this.btnAgregarArt.Text = "Agregar Articulo";
            this.btnAgregarArt.UseVisualStyleBackColor = false;
            // 
            // btnModificarArt
            // 
            this.btnModificarArt.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnModificarArt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModificarArt.Font = new System.Drawing.Font("Malgun Gothic Semilight", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarArt.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnModificarArt.Image = ((System.Drawing.Image)(resources.GetObject("btnModificarArt.Image")));
            this.btnModificarArt.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnModificarArt.Location = new System.Drawing.Point(12, 205);
            this.btnModificarArt.Name = "btnModificarArt";
            this.btnModificarArt.Size = new System.Drawing.Size(231, 41);
            this.btnModificarArt.TabIndex = 3;
            this.btnModificarArt.Text = "Modificar Articulo";
            this.btnModificarArt.UseVisualStyleBackColor = false;
            // 
            // btnEliminarArt
            // 
            this.btnEliminarArt.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnEliminarArt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminarArt.Font = new System.Drawing.Font("Malgun Gothic Semilight", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarArt.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnEliminarArt.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarArt.Image")));
            this.btnEliminarArt.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnEliminarArt.Location = new System.Drawing.Point(12, 263);
            this.btnEliminarArt.Name = "btnEliminarArt";
            this.btnEliminarArt.Size = new System.Drawing.Size(231, 37);
            this.btnEliminarArt.TabIndex = 4;
            this.btnEliminarArt.Text = "Eliminar Articulo";
            this.btnEliminarArt.UseVisualStyleBackColor = false;
            // 
            // btnVerDetalleArt
            // 
            this.btnVerDetalleArt.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnVerDetalleArt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVerDetalleArt.Font = new System.Drawing.Font("Malgun Gothic Semilight", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerDetalleArt.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnVerDetalleArt.Location = new System.Drawing.Point(12, 315);
            this.btnVerDetalleArt.Name = "btnVerDetalleArt";
            this.btnVerDetalleArt.Size = new System.Drawing.Size(231, 36);
            this.btnVerDetalleArt.TabIndex = 5;
            this.btnVerDetalleArt.Text = "Ver Detalle De Articulo";
            this.btnVerDetalleArt.UseVisualStyleBackColor = false;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(258, 396);
            this.Controls.Add(this.btnVerDetalleArt);
            this.Controls.Add(this.btnEliminarArt);
            this.Controls.Add(this.btnModificarArt);
            this.Controls.Add(this.btnAgregarArt);
            this.Controls.Add(this.btnBuscarArt);
            this.Controls.Add(this.btnListarArt);
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MENU";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnListarArt;
        private System.Windows.Forms.Button btnBuscarArt;
        private System.Windows.Forms.Button btnAgregarArt;
        private System.Windows.Forms.Button btnModificarArt;
        private System.Windows.Forms.Button btnEliminarArt;
        private System.Windows.Forms.Button btnVerDetalleArt;
    }
}

