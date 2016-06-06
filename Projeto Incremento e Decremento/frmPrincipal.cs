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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void iniciarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //chamada do formulário "executar"
            frmExecutar executar = new frmExecutar();
            executar.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Usando métodos de confirmação "Janela de confirmação antes de sair do Programa".
            if (MessageBox.Show("Deseja Realmente Sair?", "Confirmação", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();//fechando formulário atual
            }
        }
    }
}
