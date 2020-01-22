using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuscaCEP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CEP endereco = CEP.Busca(txtCEP.Text);

            if (endereco.erro)
            {
                MessageBox.Show("CEP Inexistente");
            }
            else
            {
                txtLogradouro.Text = endereco.logradouro;
                txtBairro.Text = endereco.bairro;
                txtCidade.Text = endereco.localidade;
                txtUf.Text = endereco.uf;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
