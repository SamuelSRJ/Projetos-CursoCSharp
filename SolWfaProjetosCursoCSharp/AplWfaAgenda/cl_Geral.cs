using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace AplWfaAgenda
{
    public static class cl_Geral
    {
        public static string versão = "v 1.0.2";

        // LISTA DE CONTATOS
        public static List<cl_Contato> LISTA_CONTATOS;


        public static void ConstroiListaContatos()
        {
            // METODO PARA CARREGAMENTO DA LISTA DE CONTATOS

            // VERIFICAR SE O FICHEIRO EXISTE
            string pasta_documentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string nome_ficheiro = pasta_documentos + @"\ficheiro_contatos.txt";

            // CRIA A LISTA VAZIA
            LISTA_CONTATOS = new List<cl_Contato>();

            if (File.Exists(nome_ficheiro))
            {
                // CARREGA TODOS OS CONTATOS DO FICHEIRO
                StreamReader ficheiro = new StreamReader(nome_ficheiro, Encoding.Default);
                while (!ficheiro.EndOfStream)
                {
                    // CARREGA NOME
                    string nome = ficheiro.ReadLine();
                    // CARREGA NUMERO
                    string numero = ficheiro.ReadLine();

                    // ADICIONAR À LISTA DE CONTATOS O CONTATO CARREGADO
                    cl_Contato novo_contato = new cl_Contato();
                    novo_contato.nome = nome;
                    novo_contato.numero = numero;
                    LISTA_CONTATOS.Add(novo_contato);
                }
                ficheiro.Dispose();
            }
        }
    }
}
