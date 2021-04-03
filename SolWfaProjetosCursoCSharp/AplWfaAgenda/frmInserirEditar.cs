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
    public partial class frmInserirEditar : Form
    {
        public frmInserirEditar()
        {
            InitializeComponent();
            ConstroiLista();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            // FECHA O FORMULARIO
            this.Close();
        }

        private void frmInserirEditar_Load(object sender, EventArgs e)
        {

        }

        public void ConstroiLista()
        {
            // ADICIONA À LISTA DE CONTATOS OS CONTATOS REGISTRADOS
            lstContatos.Items.Clear();

            foreach (cl_Contato contato in cl_Geral.LISTA_CONTATOS)
            {
                lstContatos.Items.Add(contato.nome + " (" + contato.numero+")");
            }

            // ATUALIZA O NUMERO DE REGISTROS
            lblNumRegistros.Text = "Nº de Contatos: " + lstContatos.Items.Count;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            // INSERE UM NOVO REGISTRO NA LISTA

            // VERIFICA SE TODOS OS CAMPOS ESTÃO PREENCHIDOS
            if(txtNome.Text == "" || txtNumero.Text == "")
            {
                MessageBox.Show("Preencha todos os campos corretamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
