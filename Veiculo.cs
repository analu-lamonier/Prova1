using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace waAlguelVeiculo
{
    internal class Veiculo
    {


        private string placa;
        private int ano;

        public string Placa { get => placa; set => placa = value; }
        public int Ano { get => ano; set => ano = value; }

        public Veiculo (string _placa, int _ano)
        {
            placa = _placa;
            ano = _ano;
        }

        public virtual double Alugar()
        {
            return 0.0;
        }












    }
}
