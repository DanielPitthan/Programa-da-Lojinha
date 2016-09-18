namespace ProgramadaLojinha
{
    partial class FrmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHome));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidoDeVendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.impressosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conexãoDataBaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.picImagemFundo = new System.Windows.Forms.PictureBox();
            this.impressãoDePedidoLojinhaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImagemFundo)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pedidoToolStripMenuItem,
            this.impressosToolStripMenuItem,
            this.configuraçãoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(942, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pedidoToolStripMenuItem
            // 
            this.pedidoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pedidoDeVendaToolStripMenuItem});
            this.pedidoToolStripMenuItem.Name = "pedidoToolStripMenuItem";
            this.pedidoToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.pedidoToolStripMenuItem.Text = "Operações";
            // 
            // pedidoDeVendaToolStripMenuItem
            // 
            this.pedidoDeVendaToolStripMenuItem.Name = "pedidoDeVendaToolStripMenuItem";
            this.pedidoDeVendaToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.pedidoDeVendaToolStripMenuItem.Text = "Pedido Lojinha (Protheus)";
            this.pedidoDeVendaToolStripMenuItem.Click += new System.EventHandler(this.pedidoDeVendaToolStripMenuItem_Click);
            // 
            // impressosToolStripMenuItem
            // 
            this.impressosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.impressãoDePedidoLojinhaToolStripMenuItem1});
            this.impressosToolStripMenuItem.Name = "impressosToolStripMenuItem";
            this.impressosToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.impressosToolStripMenuItem.Text = "Impressos";
            // 
            // configuraçãoToolStripMenuItem
            // 
            this.configuraçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.conexãoDataBaseToolStripMenuItem});
            this.configuraçãoToolStripMenuItem.Name = "configuraçãoToolStripMenuItem";
            this.configuraçãoToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.configuraçãoToolStripMenuItem.Text = "Configuração";
            // 
            // conexãoDataBaseToolStripMenuItem
            // 
            this.conexãoDataBaseToolStripMenuItem.Name = "conexãoDataBaseToolStripMenuItem";
            this.conexãoDataBaseToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.conexãoDataBaseToolStripMenuItem.Text = "Conexão Data Base";
            this.conexãoDataBaseToolStripMenuItem.Click += new System.EventHandler(this.conexãoDataBaseToolStripMenuItem_Click);
            // 
            // picImagemFundo
            // 
            this.picImagemFundo.Image = ((System.Drawing.Image)(resources.GetObject("picImagemFundo.Image")));
            this.picImagemFundo.Location = new System.Drawing.Point(0, 27);
            this.picImagemFundo.Name = "picImagemFundo";
            this.picImagemFundo.Size = new System.Drawing.Size(1128, 663);
            this.picImagemFundo.TabIndex = 1;
            this.picImagemFundo.TabStop = false;
            // 
            // impressãoDePedidoLojinhaToolStripMenuItem1
            // 
            this.impressãoDePedidoLojinhaToolStripMenuItem1.Name = "impressãoDePedidoLojinhaToolStripMenuItem1";
            this.impressãoDePedidoLojinhaToolStripMenuItem1.Size = new System.Drawing.Size(234, 22);
            this.impressãoDePedidoLojinhaToolStripMenuItem1.Text = "Impressão de Pedido (Lojinha)";
            this.impressãoDePedidoLojinhaToolStripMenuItem1.Click += new System.EventHandler(this.impressãoDePedidoLojinhaToolStripMenuItem1_Click);
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 687);
            this.Controls.Add(this.picImagemFundo);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmHome";
            this.Text = "Home";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImagemFundo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pedidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedidoDeVendaToolStripMenuItem;
        private System.Windows.Forms.PictureBox picImagemFundo;
        private System.Windows.Forms.ToolStripMenuItem impressosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conexãoDataBaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem impressãoDePedidoLojinhaToolStripMenuItem1;
    }
}