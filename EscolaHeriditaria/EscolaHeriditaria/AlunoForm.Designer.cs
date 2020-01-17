namespace EscolaHeriditaria
{
    partial class AlunoForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.cbxCurso = new System.Windows.Forms.ComboBox();
            this.chkAprovado = new System.Windows.Forms.CheckBox();
            this.optMasculino = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.optOutro = new System.Windows.Forms.RadioButton();
            this.optFeminino = new System.Windows.Forms.RadioButton();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Curso";
            // 
            // cbxCurso
            // 
            this.cbxCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCurso.FormattingEnabled = true;
            this.cbxCurso.Items.AddRange(new object[] {
            "Fundamental",
            "Ensino Médio",
            "Superior"});
            this.cbxCurso.Location = new System.Drawing.Point(27, 153);
            this.cbxCurso.Name = "cbxCurso";
            this.cbxCurso.Size = new System.Drawing.Size(371, 26);
            this.cbxCurso.TabIndex = 5;
            this.cbxCurso.Leave += new System.EventHandler(this.cbxCurso_Leave);
            // 
            // chkAprovado
            // 
            this.chkAprovado.AutoSize = true;
            this.chkAprovado.Location = new System.Drawing.Point(30, 319);
            this.chkAprovado.Name = "chkAprovado";
            this.chkAprovado.Size = new System.Drawing.Size(93, 22);
            this.chkAprovado.TabIndex = 6;
            this.chkAprovado.Text = "Aprovado";
            this.chkAprovado.UseVisualStyleBackColor = true;
            // 
            // optMasculino
            // 
            this.optMasculino.AutoSize = true;
            this.optMasculino.Location = new System.Drawing.Point(24, 21);
            this.optMasculino.Name = "optMasculino";
            this.optMasculino.Size = new System.Drawing.Size(97, 22);
            this.optMasculino.TabIndex = 7;
            this.optMasculino.Text = "Masculino";
            this.optMasculino.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.optOutro);
            this.groupBox1.Controls.Add(this.optFeminino);
            this.groupBox1.Controls.Add(this.optMasculino);
            this.groupBox1.Location = new System.Drawing.Point(30, 201);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 112);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sexo";
            // 
            // optOutro
            // 
            this.optOutro.AutoSize = true;
            this.optOutro.Checked = true;
            this.optOutro.Location = new System.Drawing.Point(24, 73);
            this.optOutro.Name = "optOutro";
            this.optOutro.Size = new System.Drawing.Size(170, 22);
            this.optOutro.TabIndex = 9;
            this.optOutro.TabStop = true;
            this.optOutro.Text = "Outro/Não Informado";
            this.optOutro.UseVisualStyleBackColor = true;
            // 
            // optFeminino
            // 
            this.optFeminino.AutoSize = true;
            this.optFeminino.Location = new System.Drawing.Point(24, 48);
            this.optFeminino.Name = "optFeminino";
            this.optFeminino.Size = new System.Drawing.Size(90, 22);
            this.optFeminino.TabIndex = 8;
            this.optFeminino.Text = "Feminino";
            this.optFeminino.UseVisualStyleBackColor = true;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(282, 352);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(116, 56);
            this.btnEnviar.TabIndex = 9;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // AlunoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 420);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chkAprovado);
            this.Controls.Add(this.cbxCurso);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AlunoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AlunoForm";
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.cbxCurso, 0);
            this.Controls.SetChildIndex(this.chkAprovado, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.btnEnviar, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxCurso;
        private System.Windows.Forms.CheckBox chkAprovado;
        private System.Windows.Forms.RadioButton optMasculino;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton optOutro;
        private System.Windows.Forms.RadioButton optFeminino;
        private System.Windows.Forms.Button btnEnviar;
    }
}