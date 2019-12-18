namespace Traductor_de_Señas
{
    partial class INDEX
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(INDEX));
            this.textBUsca = new System.Windows.Forms.TextBox();
            this.P_Box = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.P_Box)).BeginInit();
            this.SuspendLayout();
            // 
            // textBUsca
            // 
            this.textBUsca.Location = new System.Drawing.Point(12, 12);
            this.textBUsca.Name = "textBUsca";
            this.textBUsca.Size = new System.Drawing.Size(205, 20);
            this.textBUsca.TabIndex = 2;
            this.textBUsca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBUsca_KeyPress);
            this.textBUsca.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBUscar_KeyUp);
            // 
            // P_Box
            // 
            this.P_Box.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.P_Box.BackColor = System.Drawing.Color.Black;
            this.P_Box.Image = global::Traductor_de_Señas.Properties.Resources.INICIO;
            this.P_Box.Location = new System.Drawing.Point(12, 57);
            this.P_Box.Name = "P_Box";
            this.P_Box.Size = new System.Drawing.Size(205, 146);
            this.P_Box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.P_Box.TabIndex = 3;
            this.P_Box.TabStop = false;
            // 
            // INDEX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(229, 215);
            this.Controls.Add(this.P_Box);
            this.Controls.Add(this.textBUsca);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "INDEX";
            this.Text = "Traductor de Señas";
            this.Load += new System.EventHandler(this.INDEX_Load);
            ((System.ComponentModel.ISupportInitialize)(this.P_Box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBUsca;
        private System.Windows.Forms.PictureBox P_Box;
    }
}

