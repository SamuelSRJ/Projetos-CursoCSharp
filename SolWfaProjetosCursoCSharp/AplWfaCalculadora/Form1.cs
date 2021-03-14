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

            int res= -1111111111;

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

                        // ANALISE DA OPERACAO
                        switch(op)
                        {
                            // ADICAO
                            case "+":
                                res = parcela1 + parcela2;
                                break;

                            // SUBTRACAO
                            case "-":
                                res = parcela1 - parcela2;
                                break;

                            // MULTIPLICACAO
                            case "*":
                                res = parcela1 * parcela2;
                                break;

                            // DIVISAO
                            case "/":
                                res = parcela1 / parcela2;
                                break;

                            // DEFAULT
                            default:
                                MessageBox.Show("ERRO!");
                                break;
                        }

                        break;
                    }
                }
                // VERIFICA RESULTADO
                if (res != -1111111111)
                    break;
                index++;
            }

            // APRESENTACAO DO RESULTADO
            MessageBox.Show("O resultado é: " + res, "RESULTADO");

            // LIMPAR TEXTBOX   
            txtOperacao.Clear();
        }

        private void txtOperacao_KeyDown(object sender, KeyEventArgs e)
        {
            // EXECUTA A OPERACAO AO PRESSIONAR A TECLA "ENTER"
            // EXCETO, NO CASO DO CAMPO ESTAR VAZIO

            //VERIFICA SE EXISTE TEXTO
            if (txtOperacao.Text == "") return;

            // ANALISA SE ENTER FOI ACIONADO
            if (e.KeyCode == Keys.Return)
                btnCalcular_Click(btnCalcular, EventArgs.Empty);
        }
    }
}
