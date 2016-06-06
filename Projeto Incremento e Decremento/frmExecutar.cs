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
        DateTime data_hora;//criando variavel global para usar em metodos diferentes
        
        string tipoPeriodo;//criando o tipo de periodo para definir a mensagem para "Bom Dia" ou "Boa noite"
        
        int hora;//criando variavel global para fazer comparação do horário, para definir o periodo

        public frmExecutar()
        {
            InitializeComponent();
        }

        public void TipoPediodo()//criando método para definir periodo
        {
            //condição para definição de periodo
            if ((hora >= 00) && (hora <= 11))
            {
                tipoPeriodo = "Bom Dia!";
            }
            else if ((hora >= 12) && (hora <= 18))
            {
                tipoPeriodo = "Boa Tarde !";
            }
            else
                tipoPeriodo = "Boa Noite";
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            if (txtQuantidade.Text != "")
            {
                string agora;//criei outra variavel para salvar o valor atual após incremento/decremento.

                /*estou estanciando um tipo de hora com a função TimeSpan consigo escolher com o que quero 
                trabalhar. Se com HH, min ou segundos.*/
                var tipohora = new TimeSpan(0, Convert.ToInt32(txtQuantidade.Text), 0);
                //estou puxando o valor que será digitado no textBox, mas tive que converter para inteiro.

                if (rbIncrementar.Checked)//Se incremento estiver selecionado executa
                {
                    data_hora = data_hora.Add(tipohora);//função "Add" soma valor.
                    agora = data_hora.ToString();//salvando valor ´pós a soma.

                    //salvando valor apenas da hora, após converter em 'int' dentro da variavel hora
                    hora = Convert.ToInt32(Convert.ToDateTime(agora).Hour.ToString());
                    TipoPediodo();//chamando o método para testar o periodo do dia

                    MessageBox.Show(tipoPeriodo + " Hoje é : " + agora);
                    data_hora = DateTime.Now;//retornando o valor da data atual
                    txtQuantidade.Clear();//limpando a caixa de texto
                }
                else if (rbDecrementar.Checked)//se decremento estiver selecionado executa.
                {
                    data_hora = data_hora.Subtract(tipohora);//função "Subtract" Subtrai valor.
                    agora = data_hora.ToString();
                    hora = Convert.ToInt32(Convert.ToDateTime(agora).Hour.ToString());
                    TipoPediodo();

                    MessageBox.Show(tipoPeriodo + "Hoje é : " + agora);
                    data_hora = DateTime.Now;
                    txtQuantidade.Clear();
                }
                else //se nenhuma opção estiver selecionada aparece a mensagem de erro
                {
                    MessageBox.Show("Selecione uma das opçoes: 'Incremento' ou 'Decremento'");
                }
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            data_hora = DateTime.Now;//colocando valor da data e hora atual e local.

            //colocando o valor da data na label "lbApresentacaoData"(para mostrar no formulario inicial).
            lbApresentacaoData.Text = "Data Inicial : " + data_hora.ToShortDateString() + " - " + data_hora.ToShortTimeString();
        }

        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número
            if (!char.IsDigit(e.KeyChar))
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }
    }
}
