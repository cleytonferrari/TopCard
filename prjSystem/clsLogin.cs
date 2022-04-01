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

namespace prjSystem
{
    /// <summary>Class para verificar os dados informados na tela de Login do sistema.</summary>
    class clsLogin
    {
        /// <summary>
        /// Recupera o nome Completo do Usuario que esta Logando no sistema
        /// </summary>
        private string _userFull;
        public string userFull
        {
            get
            {
                return _userFull;
            }
            set
            {
                _userFull = value;
            }
        }

        /// <summary>
        /// Metodo para verificar se o usuário informado existe no banco de dados
        /// </summary>
        /// <param name="strLoggin">Informe o login para ser pesquisado sua existencia no banco de dados</param>
        /// <param name="strSenha">Informe a senha para ser pesquisada se esta correta no banco de dados</param>
        /// <returns></returns>
        public string VerificaUsuario(string strLoggin, string strSenha)
        {
            //Cria um stringBuilder para concatenar a Query
            StringBuilder strQuery = new StringBuilder();
            strQuery.Append(" SELECT login, senha, nome ");
            strQuery.Append(" FROM usuarios ");
            strQuery.Append(" WHERE (login = '" + strLoggin + "') ");
            strQuery.Append(" AND   (senha  = '" + strSenha + "') ");

            //executa o metodo RetornaDataSet da classe banco de dados e retorna o DataSet
            clsBancoDados clsBancoDados = new clsBancoDados();
            DataSet ds = new DataSet();
            ds = clsBancoDados.RetornaDataSet(strQuery.ToString());
            if (ds.Tables[0].Rows.Count > 0)
            {
                DataRow oDR = ds.Tables[0].Rows[0];
                _userFull = oDR["nome"].ToString();
                return _userFull;
            }
            else
            {
                return "";
            }
        }
    }
}
