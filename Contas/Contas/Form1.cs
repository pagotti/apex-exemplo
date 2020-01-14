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
            this.contas.Add(conta);
            txtNome.Clear();
            txtConta.Clear();
            updSaldo.Value = 0;
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            lbxContas.Items.Clear();
            if (optNome.Checked)
                lbxContas.DisplayMember = "DisplayNomeConta";
            else
                lbxContas.DisplayMember = "DisplayNomeSaldo";

            lbxContas.Items.AddRange(this.contas.ToArray());
        }
    }
}
