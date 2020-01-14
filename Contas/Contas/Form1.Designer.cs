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
            this.btnListar = new System.Windows.Forms.Button();
            this.lbxContas = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.optNumero = new System.Windows.Forms.RadioButton();
            this.optNome = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.updSaldo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(12, 31);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(216, 22);
            this.txtNome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Conta";
            // 
            // txtConta
            // 
            this.txtConta.Location = new System.Drawing.Point(12, 78);
            this.txtConta.Name = "txtConta";
            this.txtConta.Size = new System.Drawing.Size(164, 22);
            this.txtConta.TabIndex = 3;
            // 
            // updSaldo
            // 
            this.updSaldo.Location = new System.Drawing.Point(12, 129);
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
            this.updSaldo.Size = new System.Drawing.Size(103, 22);
            this.updSaldo.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Saldo";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(15, 172);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(80, 29);
            this.btnAdicionar.TabIndex = 6;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(136, 172);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(92, 29);
            this.btnListar.TabIndex = 7;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // lbxContas
            // 
            this.lbxContas.DisplayMember = "Numero";
            this.lbxContas.FormattingEnabled = true;
            this.lbxContas.ItemHeight = 16;
            this.lbxContas.Location = new System.Drawing.Point(275, 53);
            this.lbxContas.Name = "lbxContas";
            this.lbxContas.Size = new System.Drawing.Size(444, 148);
            this.lbxContas.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(272, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Contas";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // optNumero
            // 
            this.optNumero.Checked = true;
            this.optNumero.Location = new System.Drawing.Point(275, 221);
            this.optNumero.Name = "optNumero";
            this.optNumero.Size = new System.Drawing.Size(143, 21);
            this.optNumero.TabIndex = 10;
            this.optNumero.TabStop = true;
            this.optNumero.Text = "Numero - Conta";
            this.optNumero.UseVisualStyleBackColor = true;
            // 
            // optNome
            // 
            this.optNome.Location = new System.Drawing.Point(482, 221);
            this.optNome.Name = "optNome";
            this.optNome.Size = new System.Drawing.Size(163, 21);
            this.optNome.TabIndex = 11;
            this.optNome.Text = "Nome Conta";
            this.optNome.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 317);
            this.Controls.Add(this.optNome);
            this.Controls.Add(this.optNumero);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbxContas);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.updSaldo);
            this.Controls.Add(this.txtConta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Contas Correntes";
            ((System.ComponentModel.ISupportInitialize)(this.updSaldo)).EndInit();
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
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.ListBox lbxContas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton optNumero;
        private System.Windows.Forms.RadioButton optNome;
    }
}

