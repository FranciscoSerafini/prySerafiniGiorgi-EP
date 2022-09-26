namespace prySerafiniGiorgi_EP
{
    partial class frmVentas
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
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.lblMonto = new System.Windows.Forms.Label();
            this.lblVendedorID = new System.Windows.Forms.Label();
            this.mskIdVendedor = new System.Windows.Forms.MaskedTextBox();
            this.mskIDCliente = new System.Windows.Forms.MaskedTextBox();
            this.lblClienteID = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.mskNroFac = new System.Windows.Forms.MaskedTextBox();
            this.lblNumeroFactura = new System.Windows.Forms.Label();
            this.lblTipoFactura = new System.Windows.Forms.Label();
            this.lstTipoFactura = new System.Windows.Forms.ComboBox();
            this.cmdCargarVentas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.mskFechaVentas = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // txtMonto
            // 
            this.txtMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonto.Location = new System.Drawing.Point(153, 238);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(154, 23);
            this.txtMonto.TabIndex = 25;
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonto.Location = new System.Drawing.Point(12, 238);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(53, 16);
            this.lblMonto.TabIndex = 24;
            this.lblMonto.Text = "Monto:";
            // 
            // lblVendedorID
            // 
            this.lblVendedorID.AutoSize = true;
            this.lblVendedorID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendedorID.Location = new System.Drawing.Point(12, 201);
            this.lblVendedorID.Name = "lblVendedorID";
            this.lblVendedorID.Size = new System.Drawing.Size(120, 16);
            this.lblVendedorID.TabIndex = 23;
            this.lblVendedorID.Text = "ID de Vendedor:";
            // 
            // mskIdVendedor
            // 
            this.mskIdVendedor.Location = new System.Drawing.Point(153, 201);
            this.mskIdVendedor.Name = "mskIdVendedor";
            this.mskIdVendedor.Size = new System.Drawing.Size(154, 20);
            this.mskIdVendedor.TabIndex = 22;
            // 
            // mskIDCliente
            // 
            this.mskIDCliente.Location = new System.Drawing.Point(153, 162);
            this.mskIDCliente.Mask = "99999";
            this.mskIDCliente.Name = "mskIDCliente";
            this.mskIDCliente.Size = new System.Drawing.Size(154, 20);
            this.mskIDCliente.TabIndex = 21;
            this.mskIDCliente.ValidatingType = typeof(int);
            // 
            // lblClienteID
            // 
            this.lblClienteID.AutoSize = true;
            this.lblClienteID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClienteID.Location = new System.Drawing.Point(12, 162);
            this.lblClienteID.Name = "lblClienteID";
            this.lblClienteID.Size = new System.Drawing.Size(100, 16);
            this.lblClienteID.TabIndex = 20;
            this.lblClienteID.Text = "ID de Cliente:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(12, 127);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(135, 16);
            this.lblFecha.TabIndex = 18;
            this.lblFecha.Text = "Fecha de Emision:";
            // 
            // mskNroFac
            // 
            this.mskNroFac.Location = new System.Drawing.Point(153, 94);
            this.mskNroFac.Mask = "99999";
            this.mskNroFac.Name = "mskNroFac";
            this.mskNroFac.Size = new System.Drawing.Size(154, 20);
            this.mskNroFac.TabIndex = 17;
            this.mskNroFac.ValidatingType = typeof(int);
            // 
            // lblNumeroFactura
            // 
            this.lblNumeroFactura.AutoSize = true;
            this.lblNumeroFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroFactura.Location = new System.Drawing.Point(12, 94);
            this.lblNumeroFactura.Name = "lblNumeroFactura";
            this.lblNumeroFactura.Size = new System.Drawing.Size(135, 16);
            this.lblNumeroFactura.TabIndex = 16;
            this.lblNumeroFactura.Text = "Numero de Fatura:";
            // 
            // lblTipoFactura
            // 
            this.lblTipoFactura.AutoSize = true;
            this.lblTipoFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoFactura.Location = new System.Drawing.Point(12, 57);
            this.lblTipoFactura.Name = "lblTipoFactura";
            this.lblTipoFactura.Size = new System.Drawing.Size(121, 16);
            this.lblTipoFactura.TabIndex = 15;
            this.lblTipoFactura.Text = "Tipo de Factura:";
            // 
            // lstTipoFactura
            // 
            this.lstTipoFactura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstTipoFactura.FormattingEnabled = true;
            this.lstTipoFactura.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.lstTipoFactura.Location = new System.Drawing.Point(153, 52);
            this.lstTipoFactura.Name = "lstTipoFactura";
            this.lstTipoFactura.Size = new System.Drawing.Size(154, 21);
            this.lstTipoFactura.TabIndex = 14;
            // 
            // cmdCargarVentas
            // 
            this.cmdCargarVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCargarVentas.Location = new System.Drawing.Point(221, 279);
            this.cmdCargarVentas.Name = "cmdCargarVentas";
            this.cmdCargarVentas.Size = new System.Drawing.Size(75, 32);
            this.cmdCargarVentas.TabIndex = 13;
            this.cmdCargarVentas.Text = "Cargar";
            this.cmdCargarVentas.UseVisualStyleBackColor = true;
            this.cmdCargarVentas.Click += new System.EventHandler(this.cmdCargarVentas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 25);
            this.label1.TabIndex = 26;
            this.label1.Text = "CARGA DE VENTAS";
            // 
            // mskFechaVentas
            // 
            this.mskFechaVentas.Location = new System.Drawing.Point(154, 122);
            this.mskFechaVentas.Mask = "00/00/0000";
            this.mskFechaVentas.Name = "mskFechaVentas";
            this.mskFechaVentas.Size = new System.Drawing.Size(153, 20);
            this.mskFechaVentas.TabIndex = 27;
            this.mskFechaVentas.ValidatingType = typeof(System.DateTime);
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 323);
            this.Controls.Add(this.mskFechaVentas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.lblVendedorID);
            this.Controls.Add(this.mskIdVendedor);
            this.Controls.Add(this.mskIDCliente);
            this.Controls.Add(this.lblClienteID);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.mskNroFac);
            this.Controls.Add(this.lblNumeroFactura);
            this.Controls.Add(this.lblTipoFactura);
            this.Controls.Add(this.lstTipoFactura);
            this.Controls.Add(this.cmdCargarVentas);
            this.Name = "frmVentas";
            this.Text = "frmVentas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Label lblVendedorID;
        private System.Windows.Forms.MaskedTextBox mskIdVendedor;
        private System.Windows.Forms.MaskedTextBox mskIDCliente;
        private System.Windows.Forms.Label lblClienteID;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.MaskedTextBox mskNroFac;
        private System.Windows.Forms.Label lblNumeroFactura;
        private System.Windows.Forms.Label lblTipoFactura;
        private System.Windows.Forms.ComboBox lstTipoFactura;
        private System.Windows.Forms.Button cmdCargarVentas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mskFechaVentas;
    }
}