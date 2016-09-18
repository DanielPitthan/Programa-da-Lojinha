using System;

namespace ProgramadaLojinha
{
    partial class FrmLojinha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLojinha));
            this.label1 = new System.Windows.Forms.Label();
            this.cBEmpresa = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txMatricula = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbBoxSRA = new System.Windows.Forms.ComboBox();
            this.btGrava = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txTotal = new System.Windows.Forms.Label();
            this.lstvItens = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.txCodbar = new System.Windows.Forms.TextBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btExclui = new System.Windows.Forms.Button();
            this.btImprime = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(258, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pesquisa Nome";
            // 
            // cBEmpresa
            // 
            this.cBEmpresa.FormattingEnabled = true;
            this.cBEmpresa.Location = new System.Drawing.Point(103, 30);
            this.cBEmpresa.Name = "cBEmpresa";
            this.cBEmpresa.Size = new System.Drawing.Size(149, 21);
            this.cBEmpresa.TabIndex = 1;
            this.cBEmpresa.SelectedIndexChanged += new System.EventHandler(this.ValidaEmpresa);
            this.cBEmpresa.Leave += new System.EventHandler(this.ValidaEmpresa);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Empresa";
            // 
            // txMatricula
            // 
            this.txMatricula.Location = new System.Drawing.Point(345, 29);
            this.txMatricula.Name = "txMatricula";
            this.txMatricula.Size = new System.Drawing.Size(125, 20);
            this.txMatricula.TabIndex = 3;
            this.txMatricula.Leave += new System.EventHandler(this.txMatricula_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbBoxSRA);
            this.groupBox1.Controls.Add(this.txMatricula);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cBEmpresa);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(135, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(736, 70);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações";
            // 
            // cbBoxSRA
            // 
            this.cbBoxSRA.FormattingEnabled = true;
            this.cbBoxSRA.Location = new System.Drawing.Point(476, 29);
            this.cbBoxSRA.Name = "cbBoxSRA";
            this.cbBoxSRA.Size = new System.Drawing.Size(254, 21);
            this.cbBoxSRA.TabIndex = 4;
            // 
            // btGrava
            // 
            this.btGrava.Location = new System.Drawing.Point(796, 466);
            this.btGrava.Name = "btGrava";
            this.btGrava.Size = new System.Drawing.Size(75, 23);
            this.btGrava.TabIndex = 5;
            this.btGrava.Text = "Gravar";
            this.btGrava.UseVisualStyleBackColor = true;
            this.btGrava.Click += new System.EventHandler(this.btGrava_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(8, 436);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Total: R$";
            // 
            // txTotal
            // 
            this.txTotal.AutoSize = true;
            this.txTotal.BackColor = System.Drawing.Color.White;
            this.txTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txTotal.ForeColor = System.Drawing.Color.RoyalBlue;
            this.txTotal.Location = new System.Drawing.Point(89, 436);
            this.txTotal.Name = "txTotal";
            this.txTotal.Size = new System.Drawing.Size(0, 17);
            this.txTotal.TabIndex = 8;
            // 
            // lstvItens
            // 
            this.lstvItens.AllowColumnReorder = true;
            this.lstvItens.AllowDrop = true;
            this.lstvItens.BackgroundImageTiled = true;
            this.lstvItens.CheckBoxes = true;
            this.lstvItens.FullRowSelect = true;
            this.lstvItens.GridLines = true;
            this.lstvItens.LabelEdit = true;
            this.lstvItens.Location = new System.Drawing.Point(12, 145);
            this.lstvItens.Name = "lstvItens";
            this.lstvItens.Size = new System.Drawing.Size(859, 278);
            this.lstvItens.TabIndex = 9;
            this.lstvItens.UseCompatibleStateImageBehavior = false;
            this.lstvItens.View = System.Windows.Forms.View.Details;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(132, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Código de Barras";
            // 
            // txCodbar
            // 
            this.txCodbar.Location = new System.Drawing.Point(238, 114);
            this.txCodbar.Name = "txCodbar";
            this.txCodbar.Size = new System.Drawing.Size(244, 20);
            this.txCodbar.TabIndex = 6;
            this.txCodbar.Leave += new System.EventHandler(this.LeiaCodBar);
            // 
            // picLogo
            // 
            this.picLogo.Image = global::ProgramadaLojinha.Properties.Resources.lgmid01;
            this.picLogo.Location = new System.Drawing.Point(12, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(114, 118);
            this.picLogo.TabIndex = 12;
            this.picLogo.TabStop = false;
            // 
            // btExclui
            // 
            this.btExclui.Location = new System.Drawing.Point(668, 466);
            this.btExclui.Name = "btExclui";
            this.btExclui.Size = new System.Drawing.Size(112, 23);
            this.btExclui.TabIndex = 13;
            this.btExclui.Text = "Excluir Selecionado";
            this.btExclui.UseVisualStyleBackColor = true;
            this.btExclui.Click += new System.EventHandler(this.btExclui_Click);
            // 
            // btImprime
            // 
            this.btImprime.Location = new System.Drawing.Point(587, 466);
            this.btImprime.Name = "btImprime";
            this.btImprime.Size = new System.Drawing.Size(75, 23);
            this.btImprime.TabIndex = 14;
            this.btImprime.Text = "Imprimir";
            this.btImprime.UseVisualStyleBackColor = true;
            this.btImprime.Click += new System.EventHandler(this.btImprime_Click);
            // 
            // FrmLojinha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 503);
            this.Controls.Add(this.btImprime);
            this.Controls.Add(this.btExclui);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.txCodbar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstvItens);
            this.Controls.Add(this.txTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btGrava);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLojinha";
            this.Text = "Entrada de Pedido";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBEmpresa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txMatricula;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btGrava;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txTotal;
        private System.Windows.Forms.ListView lstvItens;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbBoxSRA;
        private System.Windows.Forms.TextBox txCodbar;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Button btExclui;
        private System.Windows.Forms.Button btImprime;
    }
}

