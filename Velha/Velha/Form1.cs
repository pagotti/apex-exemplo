using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Velha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Velha_Click(object sender, EventArgs e)
        {
            if (((Button)sender).Text.Length == 0)
            {
                if (optX.Checked)
                {
                    ((Button)sender).Text = "X";
                    optO.Checked = true;
                }
                else
                {
                    ((Button)sender).Text = "O";
                    optX.Checked = true;
                }
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            optX.Checked = true;

            foreach (Control ctr in Controls)
            {
                if (ctr is Button && ctr.Name != "btnNovo")
                {
                    ctr.Text = "";
                }
            }
        }
    }
}
