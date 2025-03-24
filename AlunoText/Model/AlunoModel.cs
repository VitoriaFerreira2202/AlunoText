using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlunoText.Model
{
    internal class AlunoModel
    {
        string Nome{ get; set;}
        double Matricula {  get; set;}
        double Prova1 { get; set;}
        double Prova2 { get; set;}

        public AlunoModel( string nome, double matricula, double prova1,double prova2) 
        { 
            this.Nome = nome;
            this.Matricula = matricula;
            this.Prova1 = prova1;
            this.Prova2 = prova2;
        }

    }
}
