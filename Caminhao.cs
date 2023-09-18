using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace waAlguelVeiculo
{
    internal class Caminhao : Veiculo
    {
        private int eixos;
        
        public int Eixos { get => eixos; set => eixos = value; }
        
        public Caminhao(string placa, int ano, int _eixos) : base(placa, ano)
        {
            eixos = _eixos;
        }

        

        public override double Alugar()
        {
            double diaria = (300 * eixos) - (2023 - Ano) * 50;
            return diaria;
        }
    }
}
