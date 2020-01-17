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
    public partial class ProfessorForm : BaseForm
    {
        public ProfessorForm()
        {
            InitializeComponent();
        }

        public bool ValidaDisciplina()
        {
            if (cbxDisciplina.SelectedIndex == -1)
            {
                MessageBox.Show("A disciplina não foi selecionada");
                cbxDisciplina.Focus();
                return false;
            }
            return true;
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (ValidaNome() && ValidaDataNascimento() && ValidaDisciplina())
            {
                string mensagem = $"Nome: {Nome}, Data de Nascimento {DataNascimento}, Disciplina: {cbxDisciplina.Text}";
                MessageBox.Show(mensagem);
            }
        }

        private void cbxDisciplina_Leave(object sender, EventArgs e)
        {
            ValidaDisciplina();
        }
    }
}
