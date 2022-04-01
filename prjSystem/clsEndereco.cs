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
    /// <summary>
    /// Class para o cadastro de enderecos no banco de dados
    /// </summary>
    class clsEndereco
    {
        /// <summary>
        /// Cria todos os atributos baseado nos atributos do banco de dados 
        /// </summary>
        private int _enderecos_id;
        public int enderecos_id
        {
            get
            {
                return _enderecos_id;
            }
            set
            {
                _enderecos_id = value;
            }
        }

        private int _bairros_id;
        public int bairros_id
        {
            get
            {
                return _bairros_id;
            }
            set
            {
                _bairros_id = value;
            }
        }

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

        private string _logradouro;
        public string logradouro
        {
            get
            {
                return _logradouro;
            }
            set
            {
                _logradouro = value;
            }
        }

        private string _cep;
        public string cep
        {
            get
            {
                return _cep;
            }
            set
            {
                _cep = value;
            }
        }


        /// <summary>Metodo que executa uma Query SQL que retorna um DataSet</summary>
        /// <param name="strDescricao">Query SQL a ser executada</param>
        /// <returns>Retorna um DataSet com o resultado da consulta da Query SQL</returns>
        public DataSet Listar(string strDescricao)
        {
            //Cria um stringBuilder para concatenar a Query
            StringBuilder strQuery = new StringBuilder();
            strQuery.Append(" SELECT enderecos.enderecos_id, enderecos.logradouro, enderecos.cep, enderecos.bairros_id, bairros.nome as bairro, enderecos.municipio_id, municipio.nome as municipio, municipio.uf ");
            strQuery.Append(" FROM enderecos, bairros, municipio ");
            strQuery.Append(" WHERE enderecos.bairros_id = bairros.bairros_id ");
            strQuery.Append(" AND   enderecos.municipio_id = municipio.municipio_id ");
            //adiciona o filtro de parametro case esteja fazendo uma pesquisa
            if (!(strDescricao.Equals(string.Empty)))
            {
                strQuery.Append(" AND logradouro like '%" + strDescricao + "%' ");
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
            strQuery.Append(" SELECT enderecos.enderecos_id, enderecos.logradouro, enderecos.cep, enderecos.bairros_id, bairros.nome as bairro, enderecos.municipio_id, municipio.nome as municipio, municipio.uf ");
            strQuery.Append(" FROM enderecos, bairros, municipio ");
            strQuery.Append(" WHERE enderecos.bairros_id = bairros.bairros_id ");
            strQuery.Append(" AND   enderecos.municipio_id = municipio.municipio_id ");
            //adiciona o filtro de parametro case esteja fazendo uma pesquisa
            if (!(strDescricao.Equals(string.Empty)))
            {
                //Adiciona o tipo de pesquisa
                switch (tipoPesq)
                {
                    case "qualquer": strQuery.Append(" AND " + strCampo + " like '%" + strDescricao + "%' ");
                        break;
                    case "comecar": strQuery.Append(" AND " + strCampo + " like '" + strDescricao + "%' ");
                        break;
                    case "exato": strQuery.Append(" AND " + strCampo + " = '" + strDescricao + "' ");
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
        public DataSet ListarEndereco(int intCodigo)
        {
            StringBuilder strQuery = new StringBuilder();
            strQuery.Append(" SELECT enderecos.enderecos_id, enderecos.logradouro, enderecos.cep, enderecos.bairros_id, bairros.nome as bairro, enderecos.municipio_id, municipio.nome as municipio, municipio.uf ");
            strQuery.Append(" FROM enderecos, bairros, municipio ");
            strQuery.Append(" WHERE enderecos.bairros_id = bairros.bairros_id ");
            strQuery.Append(" AND   enderecos.municipio_id = municipio.municipio_id ");
            strQuery.Append(" AND   enderecos.enderecos_id = " + intCodigo + " ");
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
            strQuery.Append(" DELETE FROM enderecos ");
            strQuery.Append(" WHERE enderecos_id = " + intCodigo + " ");
            //executa o comando utilizando a classe banco de dados
            clsBancoDados clsBancoDados = new clsBancoDados();
            if (clsBancoDados.VerificaExclusao("cliente", "enderecos_id", intCodigo.ToString()))
            {
                clsConfig clsConfig = new clsConfig();
                MessageBox.Show(clsConfig.msgProibidoExclusao, Application.ProductName,
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                clsBancoDados.ExecutaComando(strQuery.ToString());
                clsConfig clsConfig = new clsConfig();
                MessageBox.Show(clsConfig.msgExcluidoComSucesso, Application.ProductName,
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Grava um registro no banco de dados, utilizando os valores de 
        /// seus atributos, setados antes da gravação
        /// </summary>
        public void Gravar()
        {
            clsBancoDados clsBancoDados = new clsBancoDados();

            StringBuilder strQuery = new StringBuilder();
            strQuery.Append(" INSERT INTO enderecos ");
            strQuery.Append(" ( ");
            strQuery.Append("   enderecos_id, ");
            strQuery.Append("   bairros_id, ");
            strQuery.Append("   municipio_id, ");
            strQuery.Append("   logradouro, ");
            strQuery.Append("   cep ");
            strQuery.Append(" ) ");
            strQuery.Append(" VALUES ");
            strQuery.Append(" ( ");
            strQuery.Append("   '" + clsBancoDados.GeraID("enderecos", "enderecos_id") + "', ");
            strQuery.Append("   '" + _bairros_id + "', ");
            strQuery.Append("   '" + _municipio_id + "', ");
            strQuery.Append("   '" + _logradouro + "', ");
            strQuery.Append("   '" + _cep + "' ");
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
            strQuery.Append(" UPDATE enderecos ");
            strQuery.Append(" SET ");
            strQuery.Append("     logradouro = '" + _logradouro + "', ");
            strQuery.Append("     cep = '" + _cep + "', ");
            strQuery.Append("     bairros_id = '" + _bairros_id + "', ");
            strQuery.Append("     municipio_id = '" + _municipio_id + "' ");
            strQuery.Append(" WHERE ");
            strQuery.Append("      enderecos_id = " + _enderecos_id + " ");
            clsBancoDados clsBancoDados = new clsBancoDados();
            clsBancoDados.ExecutaComando(strQuery.ToString());
            clsConfig clsConfig = new clsConfig();
            MessageBox.Show(clsConfig.msgGravadoComSucesso, Application.ProductName,
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
