using AlunoText.Controle;
using AlunoText.Model;
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
            try 
            { 
                string nome =txtNome.Text;
                string matricula =txtMatricula.Text;
                string prova1 =txtProva01.Text;
                string prova2 = txtProva02.Text;
                string media= AlunoClasse.VerificarMedia(nome,matricula,prova1,prova2);

                lblResultado.Text = $"MÉDIA:{media}";

                AlunoModel aluno = new AlunoModel(nome, matricula, prova1, prova2);
                aluno.VerificarMedia();
            }

            catch(ArgumentException ex) 
            { 
                MessageBox.Show(ex.Message, "erro",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
