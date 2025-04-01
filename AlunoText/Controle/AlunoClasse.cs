using AlunoText.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlunoText.Controle
{
    internal class AlunoClasse
    {
        public static string VerificarMedia(string nome, string matricula, string prova1, string prova2) 
        {
            AlunoModel aluno = new AlunoModel(nome,matricula,prova1,prova2);

            string media = aluno.CalcFinal().ToString();
            aluno.VerificarMedia();
           return media;
        }




    }
}
