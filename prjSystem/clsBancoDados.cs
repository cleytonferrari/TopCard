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
using System.Data;
using System.Windows.Forms;
using System.Configuration;
using System.Collections.Generic;
using FirebirdSql.Data.FirebirdClient;
using System.IO;
using System.Text;

//Manipula arquivos INI
using Org.Mentalis.Files;

namespace prjSystem
{
    /// <summary>Class para criar uma conexão com o Bando de Dados, alem de manipula-lo, com insert, update e delete</summary>
    public class clsBancoDados
    {
        /// <summary>Cria uma conexão com o Banco de Dados. Lendos os parametros de um arquivo INI</summary>
        /// <returns>Retorna um Objeto do tipo FbConnection</returns>
        private FbConnection AbreBanco()
        {
            try
            {
                string file = "";
                string server = "";
                string bd = "";
                file = Application.StartupPath;
                file += "\\conf.ini";
                IniReader ini = new IniReader(file);
                server = ini.ReadString("ALSoftware","server");
                bd = ini.ReadString("ALSoftware", "banco");
                //passa a variavel StringConexao o valor do arquivo de configuracao
                string StringConexao =
                    "User=SYSDBA;" +
                    "Password=masterkey;" +
                    "Database=" + server + ":" + bd + ";" +
                    "DataSource=localhost;" +
                    "Dialect=3;" +
                    "Charset=WIN1252;";

                // Cria a conexão e ativa para uso
                FbConnection Conn = new FbConnection();
                Conn.ConnectionString = StringConexao;
                Conn.Open();
                return Conn;
            }
            catch
            {
                MessageBox.Show("Não foi Possivel se conectar ao banco de dados!\nVerifique se o arquivo de confirguração do Banco de dados bd.ini esta correto!\n\nO Aplicativo será fechado! Se o problema persistir contacte o suporte Técnico", "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
                return null;
            }
        }

        public FbConnection retornaConn()
        {
            return AbreBanco();
        }
        /// <summary>Fecha um conexão ativa com o banco de dados</summary>
        private void FechaBanco(FbConnection Conn)
        {
            //Verifica se a conexao com o banco esta aberta
            if (Conn.State == ConnectionState.Open)
            {
                Conn.Close();
            }
        }

        /// <summary>Executa um comando SQL no banco de dados</summary>
        /// <param name="strQuery">string SQL, comando SQL a ser executado</param>
        public void ExecutaComando(string strQuery)
        {
            FbConnection Conn = new FbConnection();
            //cria o objeto de conexao
            try
            {
                //abre o banco
                Conn = AbreBanco();
                //cria o objeto de comando
                FbCommand cmdComando = new FbCommand();
                //passa os valores da Query SQL, tipo do comando, conexao e executa
                cmdComando.CommandText = strQuery;
                cmdComando.CommandType = CommandType.Text;
                cmdComando.Connection = Conn;
                cmdComando.ExecuteNonQuery();
            }
            //tratamento de erro
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                //em caso de erro ou não, o finally é executado para fechar a conexao
                FechaBanco(Conn);
            }
        }

        /// <summary>Gera o autoincremento para banco de dados que não possui autoincremento</summary>
        /// <param name="tabela">Nome da entidade/tabela do banco de dados</param>
        /// <param name="campo">Nome do campo da entidade/tabela do banco de dados</param>
        /// <returns>Retorna o ID do autoincremento a ser utilizado</returns>
        public string GeraID(string tabela, string campo)
        {
            FbConnection Conn = new FbConnection();
            try
            {
                Conn = AbreBanco();
                FbCommand cmdComando = new FbCommand();
                cmdComando.CommandText = " SELECT max(" + campo + ") from " + tabela + " ";
                cmdComando.CommandType = CommandType.Text;
                cmdComando.Connection = Conn;
                //declara o dataAdapter
                FbDataAdapter daAdaptador = new FbDataAdapter();
                //declara o dataSet
                DataSet dsDataSet = new DataSet();
                //passa o comando a ser executado pelo DataAdapter
                daAdaptador.SelectCommand = cmdComando;
                //o dataAdapter faz a conexao com o banco, e carrega o dataSet
                daAdaptador.Fill(dsDataSet);
                //retorna o dataSet


                DataRow oDR = dsDataSet.Tables[0].Rows[0];
                int id = 0;
                try
                {
                    id = int.Parse(oDR["MAX"].ToString());
                }
                catch
                {
                    id = 0;
                }
                id = id + 1;//incrementa
                return id.ToString();
            }
            //tratamento de erro
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                FechaBanco(Conn);
            }
        }

        /// <summary>Metodo que retorna um dataset a partir de uma query sql</summary>
        /// <param name="strQuery">Query SQL a ser executada</param>
        /// <returns>Retorna um DataSet com o resultado da Query SQL</returns>
        public DataSet RetornaDataSet(string strQuery)
        {
            FbConnection Conn = new FbConnection();
            try
            {
                Conn = AbreBanco();
                FbCommand cmdComando = new FbCommand();
                cmdComando.CommandText = strQuery;
                cmdComando.CommandType = CommandType.Text;
                cmdComando.Connection = Conn;
                //declara o dataAdapter
                FbDataAdapter daAdaptador = new FbDataAdapter();
                //declara o dataSet
                DataSet dsDataSet = new DataSet();
                //passa o comando a ser executado pelo DataAdapter
                daAdaptador.SelectCommand = cmdComando;
                //o dataAdapter faz a conexao com o banco, e carrega o dataSet
                daAdaptador.Fill(dsDataSet);
                //retorna o dataSet
                return dsDataSet;
            }
            //tratamento de erro
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                FechaBanco(Conn);
            }
        }

        /// <summary>Metodo utilizado para retornar um dataReader a partir de uma query sql</summary>
        /// <param name="strQuery">Query SQL a ser executada</param>
        /// <returns>Retorna um FbDataReader com o resultado da Query SQL</returns>
        public FbDataReader RetornaDataReader(string strQuery)
        {
            FbConnection Conn = new FbConnection();
            try
            {
                Conn = AbreBanco();
                FbCommand cmdComando = new FbCommand();
                cmdComando.CommandText = strQuery;
                cmdComando.CommandType = CommandType.Text;
                cmdComando.Connection = Conn;
                return cmdComando.ExecuteReader();
            }
            //tratamento de erro
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                FechaBanco(Conn);
            }
        }

        /// <summary>
        /// Verifica se o registro do Banco de Dados pode ou não ser excluido
        /// se o mesmo possuir dependencias não sera excluido
        /// </summary>
        /// <param name="entidade">Nome da Entidade/Tabela do Banco de Dados</param>
        /// <param name="campo">Nome do Campo da Entidade do Banco de Dados</param>
        /// <param name="valor">Valor a ser pesquisado, geralmente o código da entidade</param>
        /// <returns>True, se encontrar, e False, para excluir!</returns>
        public bool VerificaExclusao(string entidade, string campo, string valor)
        {
            clsBairro clsBairro = new clsBairro();
            DataSet oDs = new DataSet();
            StringBuilder strQuery = new StringBuilder();
            strQuery.Append(" SELECT " + campo + " ");
            strQuery.Append(" FROM " + entidade + " ");
            strQuery.Append(" WHERE ");
            strQuery.Append("      " + campo + " = " + valor + " ");
            clsBancoDados clsBancoDados = new clsBancoDados();
            oDs = clsBancoDados.RetornaDataSet(strQuery.ToString());

            if (oDs.Tables[0].Rows.Count != 0)
                return true;
            else
                return false;
        }
    }
}
