using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Projeto_Incremento_e_Decremento
{
    public partial class frmExecutar : Form
    {
        DateTime data_hora;
        public frmExecutar()
        {
            InitializeComponent();
        }

        private void frmExecutar_Load(object sender, EventArgs e)
        {
            data_hora = DateTime.Now;//colocando valor da data e hora atual e local.

            //colocando o valor da data na label "lbApresentacaoData"(para mostrar no formulario inicial).
            lbApresentacaoData.Text = "Data Inicial : " + data_hora.ToShortDateString() + " - " + data_hora.ToShortTimeString();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            string agora;//criei outra variavel para salvar o valor atual após incremento/decremento.

            /*estou estanciando um tipo de hora com a função TimeSpan consigo escolher com o que quero 
            trabalhar. Se com HH, min ou segundos.*/
            var tipohora = new TimeSpan(0, Convert.ToInt32(txtQuantidade.Text), 0);
            //estou puxando o valor que será digitado no textBox, mas tive que converter para inteiro.

            if (rbIncrementar.Checked)//Se incremento estiver selecionado executa
            {
                data_hora = data_hora.Add(tipohora);//função "Add" soma valor.
                agora = data_hora.ToString();
                MessageBox.Show(" Hoje é : " + agora);
            }
            else if (rbDecrementar.Checked)//se decremento estiver selecionado executa.
            {
                data_hora = data_hora.Subtract(tipohora);//função "Subtract" Subtrai valor.
                agora = data_hora.ToString();
                MessageBox.Show(" Hoje é : " + agora);
            }
            else //se nenhuma opção estiver selecionada aparece a mensagem de erro
            {
                MessageBox.Show("Selecione uma das opçoes: 'Incremento' ou 'Decremento'");
            }

        }
    }
}
