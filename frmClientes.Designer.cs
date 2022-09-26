namespace prySerafiniGiorgi_EP
{
    partial class frmClientes
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtClienteName = new System.Windows.Forms.TextBox();
            this.mskClienteID = new System.Windows.Forms.MaskedTextBox();
            this.cmdRegistroCliente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "REGISTROS DE CLIENTES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID de clientes";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre de cliente";
            // 
            // txtClienteName
            // 
            this.txtClienteName.Location = new System.Drawing.Point(141, 103);
            this.txtClienteName.Name = "txtClienteName";
            this.txtClienteName.Size = new System.Drawing.Size(100, 20);
            this.txtClienteName.TabIndex = 3;
            this.txtClienteName.TextChanged += new System.EventHandler(this.txtClienteName_TextChanged);
            // 
            // mskClienteID
            // 
            this.mskClienteID.Location = new System.Drawing.Point(141, 61);
            this.mskClienteID.Mask = "99999";
            this.mskClienteID.Name = "mskClienteID";
            this.mskClienteID.Size = new System.Drawing.Size(100, 20);
            this.mskClienteID.TabIndex = 4;
            this.mskClienteID.ValidatingType = typeof(int);
            this.mskClienteID.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskClienteID_MaskInputRejected);
            // 
            // cmdRegistroCliente
            // 
            this.cmdRegistroCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRegistroCliente.Location = new System.Drawing.Point(166, 129);
            this.cmdRegistroCliente.Name = "cmdRegistroCliente";
            this.cmdRegistroCliente.Size = new System.Drawing.Size(75, 31);
            this.cmdRegistroCliente.TabIndex = 5;
            this.cmdRegistroCliente.Text = "Registrar";
            this.cmdRegistroCliente.UseVisualStyleBackColor = true;
            this.cmdRegistroCliente.Click += new System.EventHandler(this.cmdRegistroCliente_Click);
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 178);
            this.Controls.Add(this.cmdRegistroCliente);
            this.Controls.Add(this.mskClienteID);
            this.Controls.Add(this.txtClienteName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmClientes";
            this.Text = "frmClientes";
            this.Load += new System.EventHandler(this.frmClientes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtClienteName;
        private System.Windows.Forms.MaskedTextBox mskClienteID;
        private System.Windows.Forms.Button cmdRegistroCliente;
    }
}