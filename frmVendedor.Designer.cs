namespace prySerafiniGiorgi_EP
{
    partial class frmVendedor
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mskIDVendedor = new System.Windows.Forms.MaskedTextBox();
            this.txtNameVendedor = new System.Windows.Forms.TextBox();
            this.cmdRegistrarVendedores = new System.Windows.Forms.Button();
            this.chkComision = new System.Windows.Forms.CheckBox();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Vendedor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 99);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre Vendedor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(217, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "REGISTRO DE VENDEDOR";
            // 
            // mskIDVendedor
            // 
            this.mskIDVendedor.Location = new System.Drawing.Point(162, 52);
            this.mskIDVendedor.Mask = "99999";
            this.mskIDVendedor.Name = "mskIDVendedor";
            this.mskIDVendedor.Size = new System.Drawing.Size(168, 22);
            this.mskIDVendedor.TabIndex = 5;
            this.mskIDVendedor.ValidatingType = typeof(int);
            // 
            // txtNameVendedor
            // 
            this.txtNameVendedor.Location = new System.Drawing.Point(162, 96);
            this.txtNameVendedor.Name = "txtNameVendedor";
            this.txtNameVendedor.Size = new System.Drawing.Size(168, 22);
            this.txtNameVendedor.TabIndex = 6;
            // 
            // cmdRegistrarVendedores
            // 
            this.cmdRegistrarVendedores.Location = new System.Drawing.Point(246, 171);
            this.cmdRegistrarVendedores.Name = "cmdRegistrarVendedores";
            this.cmdRegistrarVendedores.Size = new System.Drawing.Size(84, 28);
            this.cmdRegistrarVendedores.TabIndex = 9;
            this.cmdRegistrarVendedores.Text = "Registrar";
            this.cmdRegistrarVendedores.UseVisualStyleBackColor = true;
            this.cmdRegistrarVendedores.Click += new System.EventHandler(this.cmdRegistrarVendedores_Click);
            // 
            // chkComision
            // 
            this.chkComision.AutoSize = true;
            this.chkComision.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkComision.Location = new System.Drawing.Point(18, 171);
            this.chkComision.Name = "chkComision";
            this.chkComision.Size = new System.Drawing.Size(90, 20);
            this.chkComision.TabIndex = 11;
            this.chkComision.Text = "Comisión";
            this.chkComision.UseVisualStyleBackColor = true;
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkActivo.Location = new System.Drawing.Point(19, 144);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(69, 20);
            this.chkActivo.TabIndex = 10;
            this.chkActivo.Text = "Activo";
            this.chkActivo.UseVisualStyleBackColor = true;
            // 
            // frmVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 206);
            this.Controls.Add(this.chkComision);
            this.Controls.Add(this.chkActivo);
            this.Controls.Add(this.cmdRegistrarVendedores);
            this.Controls.Add(this.txtNameVendedor);
            this.Controls.Add(this.mskIDVendedor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmVendedor";
            this.Text = "frmVendedor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mskIDVendedor;
        private System.Windows.Forms.TextBox txtNameVendedor;
        private System.Windows.Forms.Button cmdRegistrarVendedores;
        private System.Windows.Forms.CheckBox chkComision;
        private System.Windows.Forms.CheckBox chkActivo;
    }
}