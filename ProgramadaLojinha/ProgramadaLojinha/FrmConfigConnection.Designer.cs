namespace ProgramadaLojinha
{
    partial class FrmConfigConnection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConfigConnection));
            this.label1 = new System.Windows.Forms.Label();
            this.txServer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txDabaBase = new System.Windows.Forms.TextBox();
            this.btGravaConfigDb = new System.Windows.Forms.Button();
            this.ckTrustedConnection = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txUserdb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txPassword = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Servidor:";
            // 
            // txServer
            // 
            this.txServer.Location = new System.Drawing.Point(169, 12);
            this.txServer.Name = "txServer";
            this.txServer.Size = new System.Drawing.Size(145, 20);
            this.txServer.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(332, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Banco de Dados";
            // 
            // txDabaBase
            // 
            this.txDabaBase.Location = new System.Drawing.Point(425, 12);
            this.txDabaBase.Name = "txDabaBase";
            this.txDabaBase.Size = new System.Drawing.Size(145, 20);
            this.txDabaBase.TabIndex = 3;
            // 
            // btGravaConfigDb
            // 
            this.btGravaConfigDb.Location = new System.Drawing.Point(495, 98);
            this.btGravaConfigDb.Name = "btGravaConfigDb";
            this.btGravaConfigDb.Size = new System.Drawing.Size(75, 23);
            this.btGravaConfigDb.TabIndex = 4;
            this.btGravaConfigDb.Text = "Gravar";
            this.btGravaConfigDb.UseVisualStyleBackColor = true;
            this.btGravaConfigDb.Click += new System.EventHandler(this.btGravaConfigDb_Click);
            // 
            // ckTrustedConnection
            // 
            this.ckTrustedConnection.AutoSize = true;
            this.ckTrustedConnection.Location = new System.Drawing.Point(79, 98);
            this.ckTrustedConnection.Name = "ckTrustedConnection";
            this.ckTrustedConnection.Size = new System.Drawing.Size(119, 17);
            this.ckTrustedConnection.TabIndex = 5;
            this.ckTrustedConnection.Text = "Trusted Connection";
            this.ckTrustedConnection.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Usuário";
            // 
            // txUserdb
            // 
            this.txUserdb.Location = new System.Drawing.Point(169, 54);
            this.txUserdb.Name = "txUserdb";
            this.txUserdb.Size = new System.Drawing.Size(145, 20);
            this.txUserdb.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(332, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Senha";
            // 
            // txPassword
            // 
            this.txPassword.Location = new System.Drawing.Point(425, 54);
            this.txPassword.Name = "txPassword";
            this.txPassword.Size = new System.Drawing.Size(145, 20);
            this.txPassword.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // FrmConfigConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 136);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txUserdb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ckTrustedConnection);
            this.Controls.Add(this.btGravaConfigDb);
            this.Controls.Add(this.txDabaBase);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txServer);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmConfigConnection";
            this.Text = "FrmConfigConnection";
            this.Load += new System.EventHandler(this.FrmConfigConnection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txServer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txDabaBase;
        private System.Windows.Forms.Button btGravaConfigDb;
        private System.Windows.Forms.CheckBox ckTrustedConnection;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txUserdb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txPassword;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}