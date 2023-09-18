using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace waAlguelVeiculo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButtonOnibus_CheckedChanged(object sender, EventArgs e)
        {
            mtbPlaca.Mask = "000-0000";
            lbAssentosEixos.Text = "Assentos";
            pictureBox1.Image = Properties.Resources.Onibus;
        }

        private void radioButtonCaminhao_CheckedChanged(object sender, EventArgs e)
        {
            mtbPlaca.Mask = "000-0000";
            lbAssentosEixos.Text = "Eixos";
            pictureBox1.Image = Properties.Resources.Caminhao;
        }

        private void MensagemBotao(string nomelabel)
        {
            MessageBox.Show("Voce deve Informar o " + nomelabel + "!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public bool validaInformação()
        {
            bool validaInfo = true;

            if (mtbPlaca.MaskCompleted == false)
            {
                MensagemBotao(lbPlaca.Text);
                validaInfo = false;
            }
            else if (tbAno.Text.Trim() == string.Empty)
            {
                MensagemBotao(lbAno.Text);
                validaInfo = false;
            }
            else if (lbAssentosEixos.Text.Trim() == string.Empty)
            {
                MensagemBotao(lbAssentosEixos.Text);
                validaInfo = false;
            }





        

            return validaInfo;
        }

        public void gerarGradeListViewPf()// Gera as grades do List View PF
        {
            lvCO.Columns.Add("Placa", 150).TextAlign = HorizontalAlignment.Center;
            lvCO.Columns.Add("Ano", 150).TextAlign = HorizontalAlignment.Center;
            lvCO.Columns.Add("Assentos", 100).TextAlign = HorizontalAlignment.Center;
            lvCO.Columns.Add("Eixos", 80).TextAlign = HorizontalAlignment.Center;
            lvCO.Columns.Add("Diaria", 150).TextAlign = HorizontalAlignment.Center;
            
            lvCO.View = View.Details;
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            if (radioButtonOnibus.Checked == true)
            {
                Veiculo veiculoaluguel = new Veiculo( mtbPlaca.Text, Convert.ToInt32(tbAno.Text));



                ;
            }
            if (radioButtonCaminhao.Checked == true)
            {
                Veiculo veiculoalguel =  new Veiculo (Convert.ToDouble(mtbPlaca.Text), Convert.ToDouble(tbAno.Text));

                ;
            }
        }

        private void InserirDiariaOnibusListView(Veiculo veiculo)
        {
            string[] formasGeos = new string[7];

            formasGeos[0] = objformas.Nome;
            formasGeos[1] = tbTop.Text; // objformas.LadoQuadrado.toString();
            formasGeos[5] = Convert.ToString(objformas.Area());
            formasGeos[6] = Convert.ToString(objformas.Perimetro());
            listViewArea.Items.Add(new ListViewItem(formasGeos));
        }








    }
}
