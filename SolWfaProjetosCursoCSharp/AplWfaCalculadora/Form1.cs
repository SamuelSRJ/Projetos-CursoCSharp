using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplWfaCalculadora
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            // FECHAR A APLICAÇÃO
            Application.Exit();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // EXECUTA O CALCULO DA OPERACAO

            int parcela1;
            int parcela2;
            string op;

            string algoritmo = txtOperacao.Text;

            //123+456

            string sinais = "+-*/";

            int index = 0;
            foreach(char c in algoritmo)
            {
                foreach(char s in sinais)
                {
                    if(c == s)
                    {
                        // DEFINE OS 3 ELEMENTOS DA OPERACAO
                        // PARCELA 1
                        parcela1 = int.Parse(algoritmo.Substring(0, index));

                        // SINAL
                        op = c.ToString();

                        // PARCELA 2
                        parcela2 = int.Parse(algoritmo.Substring(index+1));
                    }
                }
                index++;
            }
        }
    }
}
