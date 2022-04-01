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
    /// <summary>Class para Selecionar o VIP PAI,e VIP AVO, todo o segredo</summary>
    class clsVipPai
    {
        /// <summary>Metodo que executa uma Query SQL que retorna um DataSet</summary>
        /// <param name="strDescricao">Query SQL a ser executada</param>
        /// <returns>Retorna um DataSet com o resultado da consulta da Query SQL</returns>
        public DataSet Listar(string strDescricao)
        {
            //Cria um stringBuilder para concatenar a Query
            StringBuilder strQuery = new StringBuilder();
            strQuery.Append(" SELECT vippai_id, nome, datanascimento, pai, mae, formadepagamento, ");
            strQuery.Append(" cc, ag, status, cpf, rg, datacadastro, telefones, email, obs, ");
            strQuery.Append(" estadocivil, profissao, nacionalidade, sexo, numero, enderecos_id, ");
            strQuery.Append(" banco_id, natural_id, vipavo_id, painome, paicpf ");
            strQuery.Append(" FROM vippai ");
            //adiciona o filtro de parametro caso esteja fazendo uma pesquisa
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
            strQuery.Append(" SELECT vippai_id, nome, datanascimento, pai, mae, formadepagamento, ");
            strQuery.Append(" cc, ag, status, cpf, rg, datacadastro, telefones, email, obs, ");
            strQuery.Append(" estadocivil, profissao, nacionalidade, sexo, numero, enderecos_id, ");
            strQuery.Append(" banco_id, natural_id, vipavo_id, painome, paicpf ");
            strQuery.Append(" FROM vippai ");

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
        public DataSet ListarVipPai(int intCodigo)
        {
            StringBuilder strQuery = new StringBuilder();
            strQuery.Append(" SELECT vippai_id, nome, datanascimento, pai, mae, formadepagamento, ");
            strQuery.Append(" cc, ag, status, cpf, rg, datacadastro, telefones, email, obs, ");
            strQuery.Append(" estadocivil, profissao, nacionalidade, sexo, numero, enderecos_id, ");
            strQuery.Append(" banco_id, natural_id, vipavo_id, painome, paicpf ");
            strQuery.Append(" FROM vippai ");
            strQuery.Append(" WHERE ");
            strQuery.Append("      vippai_id = " + intCodigo + " ");
            clsBancoDados clsBancoDados = new clsBancoDados();
            return clsBancoDados.RetornaDataSet(strQuery.ToString());
        }

    }
}
