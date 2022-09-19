namespace prySerafiniGiorgi_EP
{
    partial class frmKAKTUS
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.rEGISTRARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cLIENTESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vENDEDORToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vENTASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cONSULTARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vENTASToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cLIENTESToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rEGISTRARToolStripMenuItem,
            this.cONSULTARToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // rEGISTRARToolStripMenuItem
            // 
            this.rEGISTRARToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cLIENTESToolStripMenuItem,
            this.vENDEDORToolStripMenuItem,
            this.vENTASToolStripMenuItem});
            this.rEGISTRARToolStripMenuItem.Name = "rEGISTRARToolStripMenuItem";
            this.rEGISTRARToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.rEGISTRARToolStripMenuItem.Text = "REGISTRAR";
            // 
            // cLIENTESToolStripMenuItem
            // 
            this.cLIENTESToolStripMenuItem.Name = "cLIENTESToolStripMenuItem";
            this.cLIENTESToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.cLIENTESToolStripMenuItem.Text = "CLIENTES";
            this.cLIENTESToolStripMenuItem.Click += new System.EventHandler(this.cLIENTESToolStripMenuItem_Click);
            // 
            // vENDEDORToolStripMenuItem
            // 
            this.vENDEDORToolStripMenuItem.Name = "vENDEDORToolStripMenuItem";
            this.vENDEDORToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.vENDEDORToolStripMenuItem.Text = "VENDEDOR";
            this.vENDEDORToolStripMenuItem.Click += new System.EventHandler(this.vENDEDORToolStripMenuItem_Click);
            // 
            // vENTASToolStripMenuItem
            // 
            this.vENTASToolStripMenuItem.Name = "vENTASToolStripMenuItem";
            this.vENTASToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.vENTASToolStripMenuItem.Text = "VENTAS";
            this.vENTASToolStripMenuItem.Click += new System.EventHandler(this.vENTASToolStripMenuItem_Click);
            // 
            // cONSULTARToolStripMenuItem
            // 
            this.cONSULTARToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vENTASToolStripMenuItem1,
            this.cLIENTESToolStripMenuItem1});
            this.cONSULTARToolStripMenuItem.Name = "cONSULTARToolStripMenuItem";
            this.cONSULTARToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.cONSULTARToolStripMenuItem.Text = "CONSULTAR";
            // 
            // vENTASToolStripMenuItem1
            // 
            this.vENTASToolStripMenuItem1.Name = "vENTASToolStripMenuItem1";
            this.vENTASToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.vENTASToolStripMenuItem1.Text = "VENTAS";
            this.vENTASToolStripMenuItem1.Click += new System.EventHandler(this.vENTASToolStripMenuItem1_Click);
            // 
            // cLIENTESToolStripMenuItem1
            // 
            this.cLIENTESToolStripMenuItem1.Name = "cLIENTESToolStripMenuItem1";
            this.cLIENTESToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.cLIENTESToolStripMenuItem1.Text = "CLIENTES";
            this.cLIENTESToolStripMenuItem1.Click += new System.EventHandler(this.cLIENTESToolStripMenuItem1_Click);
            // 
            // frmKAKTUS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmKAKTUS";
            this.Text = "KAKTUS";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem rEGISTRARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cLIENTESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vENDEDORToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vENTASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cONSULTARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vENTASToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cLIENTESToolStripMenuItem1;
    }
}

