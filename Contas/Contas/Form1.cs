using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contas
{
    public partial class Form1 : Form
    {

        private List<Conta> contas = new List<Conta>();

        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Conta conta = new Conta();
            conta.Nome = txtNome.Text;
            conta.Numero = txtConta.Text;
            conta.Saldo = updSaldo.Value;
            conta.Especial = updLimite.Value > 0;
            conta.Limite = updLimite.Value;
            this.contas.Add(conta);
            txtNome.Clear();
            txtConta.Clear();
            updSaldo.Value = 0;
            this.AtualizaContas();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
        }

        private void AtualizaContas()
        {
            lbxContas.Items.Clear();
            if (optNome.Checked)
                lbxContas.DisplayMember = "DisplayNomeConta";
            else
                lbxContas.DisplayMember = "DisplayNomeSaldo";

            lbxContas.Items.AddRange(this.contas.ToArray());
        }

        private void btnSaque_Click(object sender, EventArgs e)
        {
            //verificar se tem uma conta selecionada na lista
            if (lbxContas.SelectedItem != null)
            {
                //pegar a conta selecionada
                Conta contaSelecionada = lbxContas.SelectedItem as Conta;
                try
                {
                    //tirar do saldo o valor especificado de saque
                    contaSelecionada.Saldo -= updValor.Value;
                    this.AtualizaContas();
                }
                catch (InvalidOperationException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                               
            }

        }

        private void btnDeposito_Click(object sender, EventArgs e)
        {
            //verificar se tem uma conta selecionada na lista
            if (lbxContas.SelectedItem != null)
            {
                //pegar a conta selecionada
                Conta contaSelecionada = lbxContas.SelectedItem as Conta;
                //adicionar ao saldo o valor especificado de deposito
                contaSelecionada.Saldo += updValor.Value;
                this.AtualizaContas();
            }

        }

        private void optNome_CheckedChanged(object sender, EventArgs e)
        {
            this.AtualizaContas();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Estou carregando o formulário...");
        }

        private void txtConta_TextChanged(object sender, EventArgs e)
        {
            if (txtConta.Text.Length > 9)
            {
                MessageBox.Show("A conta não pode ter mais que 9 números");
                txtConta.Text = txtConta.Text.Substring(0, 9);
            }
        }

        private void txtConta_Leave(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt32(txtConta.Text);

            }
            catch (FormatException)
            {
                MessageBox.Show("A conta precisa ser numérica");
                txtConta.Clear();
                txtConta.Focus();
            }
        }
    }
}
