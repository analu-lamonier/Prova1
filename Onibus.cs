using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace waAlguelVeiculo
{
    internal class Onibus : Veiculo
    {

        private int qtdAssentos;
        public int QtdAssentos { get => qtdAssentos; set => qtdAssentos = value; }

        
        
        public Onibus (string placa, int ano, int _qtdAssentos) : base(placa, ano)
        {
            qtdAssentos = _qtdAssentos;
        }

        public override double Alugar()
        {
            double diaria = (30 * qtdAssentos) - (2023 - Ano) * 70; 
            return diaria ;
        }

    }
}
