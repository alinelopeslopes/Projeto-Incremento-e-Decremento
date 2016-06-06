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
    }
}
