using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlunoText.Util
{
    internal class AlunoUtil
    {
        public static double ConferiValor(string Valor ) 
        {
            if (Double.TryParse(Valor, out double ConferiValor))
            {
                return ConferiValor;
            }
            else 
            {
                throw new ArgumentException("O VALOR ESTA INCORRETO");
            }
        }
    }
}
