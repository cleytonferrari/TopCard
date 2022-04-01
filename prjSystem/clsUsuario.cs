/*
 
    AL Software
    Rua Rondônia 3716, Alto Paraíso-RO
    CEP: 78956-000
    BRASIL
 
    Contatos:
        Cleyton Ferrari - cleytonferrari@hotmail.com - fone: 69 9975-0504
        Anderson Lopes de Oliveira - andersonlopes14@msn.com - fone: 69 99884966
 
    Copyright © 2008, AL Software / AL Informática
    Todos os direitos reservados.
    
*/
using System;
using System.Data.OleDb;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace prjSystem
{
    /// <summary>Class para o cadastro de usuários no banco de dados.</summary>
    class clsUsuario
    {
        /// <summary>
        /// Cria todos os atributos baseado nos atributos do banco de dados 
        /// </summary>
        private int _usuario_id;
        public int usuario_id
        {
            get
            {
                return _usuario_id;
            }
            set
            {
                _usuario_id = value;
            }
        }

        private string _nome;
        public string nome
        {
            get
            {
                return _nome;
            }
            set
            {
                _nome = value;
            }
        }

        private string _login;
        public string login
        {
            get
            {
                return _login;
            }
            set
            {
                _login = value;
            }
        }

        private string _senha;
        public string senha
        {
            get
            {
                return _senha;
            }
            set
            {
                _senha = value;
            }
        }

        /// <summary>Metodo que executa uma Query SQL que retorna um DataSet</summary>
        /// <param name="strDescricao">Query SQL a ser executada</param>
        /// <returns>Retorna um DataSet com o resultado da consulta da Query SQL</returns>
        public DataSet Listar(string strNome)
        {
            //Cria um stringBuilder para concatenar a Query
            StringBuilder strQuery = new StringBuilder();
            strQuery.Append(" SELECT usuario_id, nome, login, senha ");
            strQuery.Append(" FROM usuarios ");
            //adiciona o filtro de parametro case esteja fazendo uma pesquisa
            if (!(strNome.Equals(string.Empty)))
            {
                strQuery.Append(" WHERE nome like '%" + strNome + "%' ");
            }
            //executa o metodo RetornaDataSet da classe banco de dados e retorna o DataSet
            clsBancoDados clsBancoDados = new clsBancoDados();
            return clsBancoDados.RetornaDataSet(strQuery.ToString());
        }

        /// <summary>
        /// Metodo utilizado nas pesquisas
        /// </summary>
        /// <param name="strCampo">Informe qual campo vai ser utilizado para se pesquisar</param>
        /// <param name="strDescricao">Informe a string a ser pesquisada no strCampo</param>
        /// <param name="tipoPesq">
        /// Informe o tipo da pesquisa:
        /// qualquer : procura em qualquer parte do texto o valor pesquisado; 
        /// comecar : procura texto que comecem com o valor pesquisado;
        /// exato : procura texto que tenha o valor identico ao valor pesquisado.
        /// </param>
        /// <returns>Retorna um DataSet com o resultado da Pesquisa realizada</returns>
        public DataSet ListarComParametro(string strCampo, string strDescricao, string tipoPesq)
        {
            //Cria um stringBuilder para concatenar a Query
            StringBuilder strQuery = new StringBuilder();
            strQuery.Append(" SELECT usuario_id, nome, login, senha ");
            strQuery.Append(" FROM usuarios ");
            //adiciona o filtro de parametro case esteja fazendo uma pesquisa
            if (!(strDescricao.Equals(string.Empty)))
            {
                //Adiciona o tipo de pesquisa
                switch (tipoPesq)
                {
                    case "qualquer": strQuery.Append(" WHERE " + strCampo + " like '%" + strDescricao + "%' ");
                        break;
                    case "comecar": strQuery.Append(" WHERE " + strCampo + " like '" + strDescricao + "%' ");
                        break;
                    case "exato": strQuery.Append(" WHERE " + strCampo + " = '" + strDescricao + "' ");
                        break;
                }

            }
            //executa o metodo RetornaDataSet da classe banco de dados e retorna o DataSet
            clsBancoDados clsBancoDados = new clsBancoDados();
            return clsBancoDados.RetornaDataSet(strQuery.ToString());
        }

        /// <summary>
        /// Utilizado para localizar o registro que vai entrar em edição
        /// </summary>
        /// <param name="intCodigo">Informe o código do registro a ser editado</param>
        /// <returns>Retorna um DataSet com a tupla que sera colocada em edição</returns>
        public DataSet ListarUsuario(int intCodigo)
        {
            StringBuilder strQuery = new StringBuilder();
            strQuery.Append(" SELECT usuario_id, nome, login, senha ");
            strQuery.Append(" FROM usuarios ");
            strQuery.Append(" WHERE ");
            strQuery.Append("      usuario_id = " + intCodigo + " ");
            clsBancoDados clsBancoDados = new clsBancoDados();
            return clsBancoDados.RetornaDataSet(strQuery.ToString());
        }

        /// <summary>
        /// Exclui um registro do banco de dados
        /// </summary>
        /// <param name="intCodigo">Informe o código do registro a ser excluido</param>
        public void Excluir(int intCodigo)
        {
            StringBuilder strQuery = new StringBuilder();
            strQuery.Append(" DELETE FROM usuarios ");
            strQuery.Append(" WHERE usuario_id = " + intCodigo + " ");
            //executa o comando utilizando a classe banco de dados
            clsBancoDados clsBancoDados = new clsBancoDados();
            clsBancoDados.ExecutaComando(strQuery.ToString());
            clsConfig clsConfig = new clsConfig();
            MessageBox.Show(clsConfig.msgExcluidoComSucesso, Application.ProductName,
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Grava um registro no banco de dados, utilizando os valores de 
        /// seus atributos, setados antes da gravação
        /// </summary>
        public void Gravar()
        {
            clsBancoDados clsBancoDados = new clsBancoDados();

            StringBuilder strQuery = new StringBuilder();
            strQuery.Append(" INSERT INTO usuarios ");
            strQuery.Append(" ( ");
            strQuery.Append("   usuario_id, ");
            strQuery.Append("   nome, ");
            strQuery.Append("   login, ");
            strQuery.Append("   senha ");
            strQuery.Append(" ) ");
            strQuery.Append(" VALUES ");
            strQuery.Append(" ( ");
            strQuery.Append("   '" + clsBancoDados.GeraID("usuarios", "usuario_id") + "', ");
            strQuery.Append("   '" + _nome + "', ");
            strQuery.Append("   '" + _login + "', ");
            strQuery.Append("   '" + _senha + "' ");
            strQuery.Append(" ) ");
            clsBancoDados.ExecutaComando(strQuery.ToString());
            clsConfig clsConfig = new clsConfig();
            MessageBox.Show(clsConfig.msgGravadoComSucesso, Application.ProductName,
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Altera um registro no banco de dados, utilizando o valor do codigo 
        /// de seu atributo, setado antes da alteraçao
        /// </summary>
        public void Alterar()
        {
            StringBuilder strQuery = new StringBuilder();
            strQuery.Append(" UPDATE usuarios ");
            strQuery.Append(" SET ");
            strQuery.Append("     nome = '" + _nome + "', ");
            strQuery.Append("     login = '" + _login + "', ");
            strQuery.Append("     senha = '" + _senha + "' ");
            strQuery.Append(" WHERE ");
            strQuery.Append("      usuario_id = " + _usuario_id + " ");
            clsBancoDados clsBancoDados = new clsBancoDados();
            clsBancoDados.ExecutaComando(strQuery.ToString());
            clsConfig clsConfig = new clsConfig();
            MessageBox.Show(clsConfig.msgGravadoComSucesso, Application.ProductName,
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
