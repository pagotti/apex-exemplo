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
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
        }

        protected string Nome
        {
            get
            {
                return txtNome.Text;
            }
        }

        protected DateTime DataNascimento
        {
            get
            {
                return dtpNascimento.Value;
            }
        }

        public bool ValidaNome()
        {
            if (txtNome.TextLength > 30)
            {
                MessageBox.Show("O nome não pode ter mais que 30 letras");
                return false;
            }
            for (int i = 0; i < txtNome.Text.Length; i++)
            {
                char caractere = txtNome.Text[i];
                if ("@#$%0123456789".Contains(caractere))
                {
                    MessageBox.Show("O nome é inválido");
                    txtNome.Clear();
                    txtNome.Focus();
                    return false;
                }
            }
            return true;
        }

        public bool ValidaDataNascimento()
        {
            if (dtpNascimento.Value.Date > DateTime.Today.AddYears(-5))
            {
                MessageBox.Show("Data de Nascimento inválida");
                dtpNascimento.Focus();
                return false;
            }
            return true;
        }

        private void txtNome_Leave(object sender, EventArgs e)
        {
            ValidaNome();
        }

        private void dtpNascimento_Leave(object sender, EventArgs e)
        {
            ValidaDataNascimento();
        }
    }
}
