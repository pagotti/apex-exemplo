using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscolaHeriditaria
{
    public partial class AlunoForm : BaseForm
    {
        public AlunoForm()
        {
            InitializeComponent();
        }

        public bool ValidaCurso()
        {
            if (cbxCurso.SelectedIndex == -1)
            {
                MessageBox.Show("O curso não foi selecionado");
                cbxCurso.Focus();
                return false;
            }
            return true;
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (ValidaNome() && ValidaDataNascimento() && ValidaCurso())
            {
                string mensagem = $"Nome: {Nome}, Data Nascimento: {DataNascimento}, Curso: {cbxCurso.Text}";
                if (chkAprovado.Checked)
                {
                    mensagem += ", **Aprovado**";
                }
                mensagem += ", Sexo: " + (optMasculino.Checked ? "Masculino" :
                                         optFeminino.Checked ? "Feminino" :
                                         "Outro");
                MessageBox.Show(mensagem);
            }
        }

        private void cbxCurso_Leave(object sender, EventArgs e)
        {
            ValidaCurso();
        }
    }
}
