using AlunoText.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlunoText.Model
{
    internal class AlunoModel
    {
        string Nome{ get; set;}
        double Matricula {  get; set;}
        double Prova1 { get; set;}
        double Prova2 { get; set;}
        double media;

        public AlunoModel( string nome, string matricula, string prova1, string prova2) 
        { 
            this.Nome = nome;
            this.Matricula = AlunoUtil.ConferiValor(matricula);
            this.Prova1 = AlunoUtil.ConferiValor (prova1);
            this.Prova2 = AlunoUtil.ConferiValor(prova2);
        }
        public string CalcFinal() 
        {
            media = (Prova1 + Prova2) / 2;
            return media.ToString("F2");
        }

        public string VerificarMedia()
        {
            if (media >= 7)
            {
               return $"ALUNO {Nome} ESTA APROVADO";
            }
            else
            {
               return $"ALUNO {Nome} ESTA REPROVADO";
            }
        }

    }
}
