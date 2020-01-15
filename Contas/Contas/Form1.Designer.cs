namespace Contas
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtConta = new System.Windows.Forms.TextBox();
            this.updSaldo = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.lbxContas = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.optNumero = new System.Windows.Forms.RadioButton();
            this.optNome = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.updValor = new System.Windows.Forms.NumericUpDown();
            this.btnSaque = new System.Windows.Forms.Button();
            this.btnDeposito = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.updLimite = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.updSaldo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updValor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updLimite)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(14, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(14, 39);
            this.txtNome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(242, 26);
            this.txtNome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(14, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Conta";
            // 
            // txtConta
            // 
            this.txtConta.Location = new System.Drawing.Point(14, 98);
            this.txtConta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtConta.Name = "txtConta";
            this.txtConta.Size = new System.Drawing.Size(184, 26);
            this.txtConta.TabIndex = 3;
            this.txtConta.TextChanged += new System.EventHandler(this.txtConta_TextChanged);
            this.txtConta.Leave += new System.EventHandler(this.txtConta_Leave);
            // 
            // updSaldo
            // 
            this.updSaldo.Location = new System.Drawing.Point(14, 161);
            this.updSaldo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.updSaldo.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.updSaldo.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.updSaldo.Name = "updSaldo";
            this.updSaldo.Size = new System.Drawing.Size(116, 26);
            this.updSaldo.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(14, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Saldo";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(12, 214);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(90, 36);
            this.btnAdicionar.TabIndex = 6;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // lbxContas
            // 
            this.lbxContas.DisplayMember = "Numero";
            this.lbxContas.FormattingEnabled = true;
            this.lbxContas.ItemHeight = 20;
            this.lbxContas.Location = new System.Drawing.Point(309, 66);
            this.lbxContas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbxContas.Name = "lbxContas";
            this.lbxContas.Size = new System.Drawing.Size(499, 184);
            this.lbxContas.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(306, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Contas";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // optNumero
            // 
            this.optNumero.Checked = true;
            this.optNumero.Location = new System.Drawing.Point(309, 276);
            this.optNumero.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.optNumero.Name = "optNumero";
            this.optNumero.Size = new System.Drawing.Size(161, 26);
            this.optNumero.TabIndex = 10;
            this.optNumero.TabStop = true;
            this.optNumero.Text = "Conta e Saldo";
            this.optNumero.UseVisualStyleBackColor = true;
            // 
            // optNome
            // 
            this.optNome.Location = new System.Drawing.Point(542, 276);
            this.optNome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.optNome.Name = "optNome";
            this.optNome.Size = new System.Drawing.Size(183, 26);
            this.optNome.TabIndex = 11;
            this.optNome.Text = "Conta e Número";
            this.optNome.UseVisualStyleBackColor = true;
            this.optNome.CheckedChanged += new System.EventHandler(this.optNome_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 343);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Valor";
            // 
            // updValor
            // 
            this.updValor.Location = new System.Drawing.Point(18, 371);
            this.updValor.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.updValor.Name = "updValor";
            this.updValor.Size = new System.Drawing.Size(120, 26);
            this.updValor.TabIndex = 13;
            // 
            // btnSaque
            // 
            this.btnSaque.Location = new System.Drawing.Point(144, 367);
            this.btnSaque.Name = "btnSaque";
            this.btnSaque.Size = new System.Drawing.Size(73, 33);
            this.btnSaque.TabIndex = 14;
            this.btnSaque.Text = "Saque";
            this.btnSaque.UseVisualStyleBackColor = true;
            this.btnSaque.Click += new System.EventHandler(this.btnSaque_Click);
            // 
            // btnDeposito
            // 
            this.btnDeposito.Location = new System.Drawing.Point(223, 367);
            this.btnDeposito.Name = "btnDeposito";
            this.btnDeposito.Size = new System.Drawing.Size(86, 34);
            this.btnDeposito.TabIndex = 15;
            this.btnDeposito.Text = "Depósito";
            this.btnDeposito.UseVisualStyleBackColor = true;
            this.btnDeposito.Click += new System.EventHandler(this.btnDeposito_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(147, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Limite";
            // 
            // updLimite
            // 
            this.updLimite.Location = new System.Drawing.Point(151, 160);
            this.updLimite.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.updLimite.Name = "updLimite";
            this.updLimite.Size = new System.Drawing.Size(120, 26);
            this.updLimite.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 440);
            this.Controls.Add(this.updLimite);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnDeposito);
            this.Controls.Add(this.btnSaque);
            this.Controls.Add(this.updValor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.optNome);
            this.Controls.Add(this.optNumero);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbxContas);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.updSaldo);
            this.Controls.Add(this.txtConta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Contas Correntes";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.updSaldo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updValor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updLimite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtConta;
        private System.Windows.Forms.NumericUpDown updSaldo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.ListBox lbxContas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton optNumero;
        private System.Windows.Forms.RadioButton optNome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown updValor;
        private System.Windows.Forms.Button btnSaque;
        private System.Windows.Forms.Button btnDeposito;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown updLimite;
    }
}

