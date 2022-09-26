namespace prySerafiniGiorgi_EP
{
    partial class frmConsultaVentas
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
            this.GRLConsultaVentas = new System.Windows.Forms.DataGridView();
            this.cmdListarVentas = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GRLConsultaVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // GRLConsultaVentas
            // 
            this.GRLConsultaVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GRLConsultaVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.GRLConsultaVentas.Location = new System.Drawing.Point(12, 12);
            this.GRLConsultaVentas.Name = "GRLConsultaVentas";
            this.GRLConsultaVentas.Size = new System.Drawing.Size(644, 408);
            this.GRLConsultaVentas.TabIndex = 1;
            // 
            // cmdListarVentas
            // 
            this.cmdListarVentas.Location = new System.Drawing.Point(555, 426);
            this.cmdListarVentas.Name = "cmdListarVentas";
            this.cmdListarVentas.Size = new System.Drawing.Size(75, 23);
            this.cmdListarVentas.TabIndex = 2;
            this.cmdListarVentas.Text = "Listar";
            this.cmdListarVentas.UseVisualStyleBackColor = true;
            this.cmdListarVentas.Click += new System.EventHandler(this.cmdListarVentas_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Factura Numero";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Factura Tipo";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Fecha";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "ClienteID";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "VendedorID";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Monto";
            this.Column6.Name = "Column6";
            // 
            // frmConsultaVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 457);
            this.Controls.Add(this.cmdListarVentas);
            this.Controls.Add(this.GRLConsultaVentas);
            this.Name = "frmConsultaVentas";
            this.Text = "ConsultaVentas";
            ((System.ComponentModel.ISupportInitialize)(this.GRLConsultaVentas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GRLConsultaVentas;
        private System.Windows.Forms.Button cmdListarVentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}