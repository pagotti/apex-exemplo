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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAluno_Click(object sender, EventArgs e)
        {
            AlunoForm aluno = new AlunoForm();
            aluno.Show();
        }

        private void btnProfessor_Click(object sender, EventArgs e)
        {
            ProfessorForm professor = new ProfessorForm();
            professor.ShowDialog();
        }
    }
}
