using AlunoText.Controle;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlunoText
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            AlunoClasse.VerificarMedia(txtMatricula.Text,txtNome.Text,txtProva01.Text,txtProva02.Text);

            vi  

        }
    }
}
