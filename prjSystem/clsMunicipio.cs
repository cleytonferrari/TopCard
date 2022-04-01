//Namespaces necessarios nesta class
using System;
using System.Data.OleDb;
using System.Data;
using System.Text;

namespace prjSystem
{
    /// <summary>Class para o cadastro de municipios no banco de dados.</summary>
    public class clsMunicipio
    {
        /// <summary>
        /// Cria todos os atributos baseado nos atributos do banco de dados 
        /// </summary>
        private string _municipio_id;
        public string municipio_id
        {
            get
            {
                return _municipio_id;
            }
            set
            {
                _municipio_id = value;
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

        private string _uf;
        public string uf
        {
            get
            {
                return _uf;
            }
            set
            {
                _uf = value;
            }
        }

        /// <summary>Metodo que executa uma Query SQL que retorna um DataSet</summary>
        /// <param name="strDescricao">Query SQL a ser executada</param>
        /// <returns>Retorna um DataSet com o resultado da consulta da Query SQL</returns>
        public DataSet Listar(string strDescricao)
        {
            //Cria um stringBuilder para concatenar a Query
            StringBuilder strQuery = new StringBuilder();
            strQuery.Append(" SELECT municipio_id, nome, uf ");
            strQuery.Append(" FROM municipio ");
            //adiciona o filtro de parametro case esteja fazendo uma pesquisa
            if (!(strDescricao.Equals(string.Empty)))
            {
                strQuery.Append(" WHERE nome like '%" + strDescricao + "%' ");
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
            strQuery.Append(" SELECT municipio_id, nome, uf ");
            strQuery.Append(" FROM municipio ");
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
        public DataSet ListarMunicipio(string intCodigo)
        {
            StringBuilder strQuery = new StringBuilder();
            strQuery.Append(" SELECT municipio_id, nome, uf ");
            strQuery.Append(" FROM municipio ");
            strQuery.Append(" WHERE ");
            strQuery.Append("      municipio_id = " + intCodigo + " ");
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
            strQuery.Append(" DELETE FROM municipio ");
            strQuery.Append(" WHERE municipio_id = " + intCodigo + " ");
            //executa o comando utilizando a classe banco de dados
            clsBancoDados clsBancoDados = new clsBancoDados();
            clsBancoDados.ExecutaComando(strQuery.ToString());
        }

        /// <summary>
        /// Grava um registro no banco de dados, utilizando os valores de 
        /// seus atributos, setados antes da gravação
        /// </summary>
        public void Gravar()
        {
            clsBancoDados clsBancoDados = new clsBancoDados();

            StringBuilder strQuery = new StringBuilder();
            strQuery.Append(" INSERT INTO municipio ");
            strQuery.Append(" ( ");
            strQuery.Append("   municipio_id, ");
            strQuery.Append("   nome, ");
            strQuery.Append("   uf ");
            strQuery.Append(" ) ");
            strQuery.Append(" VALUES ");
            strQuery.Append(" ( ");
            strQuery.Append("   '" + clsBancoDados.GeraID("municipio", "municipio_id") + "', ");
            strQuery.Append("   '" + _nome + "', ");
            strQuery.Append("   '" + _uf + "' ");
            strQuery.Append(" ) ");

            clsBancoDados.ExecutaComando(strQuery.ToString());
        }

        /// <summary>
        /// Altera um registro no banco de dados, utilizando o valor do codigo 
        /// de seu atributo, setado antes da alteraçao
        /// </summary>
        public void Alterar()
        {
            StringBuilder strQuery = new StringBuilder();
            strQuery.Append(" UPDATE municipio ");
            strQuery.Append(" SET ");
            strQuery.Append("     nome = '" + _nome + "', ");
            strQuery.Append("     nome = '" + _uf + "' ");
            strQuery.Append(" WHERE ");
            strQuery.Append("      municipio_id = " + _municipio_id + " ");
            clsBancoDados clsBancoDados = new clsBancoDados();
            clsBancoDados.ExecutaComando(strQuery.ToString());
        }
    }
}
