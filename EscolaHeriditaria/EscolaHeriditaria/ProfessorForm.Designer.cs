namespace EscolaHeriditaria
{
    partial class ProfessorForm
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
            this.cbxDisciplina = new System.Windows.Forms.ComboBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Disciplina";
            // 
            // cbxDisciplina
            // 
            this.cbxDisciplina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDisciplina.FormattingEnabled = true;
            this.cbxDisciplina.Items.AddRange(new object[] {
            "Português",
            "Matemática",
            "Geografia",
            "Quimica",
            "Física"});
            this.cbxDisciplina.Location = new System.Drawing.Point(27, 146);
            this.cbxDisciplina.Name = "cbxDisciplina";
            this.cbxDisciplina.Size = new System.Drawing.Size(371, 24);
            this.cbxDisciplina.TabIndex = 5;
            this.cbxDisciplina.Leave += new System.EventHandler(this.cbxDisciplina_Leave);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(279, 194);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(118, 45);
            this.btnEnviar.TabIndex = 6;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // ProfessorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 272);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.cbxDisciplina);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ProfessorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProfessorForm";
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.cbxDisciplina, 0);
            this.Controls.SetChildIndex(this.btnEnviar, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxDisciplina;
        private System.Windows.Forms.Button btnEnviar;
    }
}