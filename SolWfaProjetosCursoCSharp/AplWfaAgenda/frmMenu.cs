using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplWfaAgenda
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();

            // Apresenta versão do programa
            lblVersao.Text = cl_Geral.versão;
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            // SAIR DA APLICAÇÃO
            // PERGUNTA SE PRETENDE REALMENTE SAIR DA APLICAÇÃO

            if (MessageBox.Show("Deseja sair da Aplicação?", "SAIR", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.No) return;

            // SAI DA APLICAÇÃO
            Application.Exit();
        }

        private void btnInserirEditar_Click(object sender, EventArgs e)
        {
            // APRE QUADRO PARA GESTÃO DOS CONTATOS
            frmInserirEditar formulario = new frmInserirEditar();
            formulario.ShowDialog();
        }
    }
}
