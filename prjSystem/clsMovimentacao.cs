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
//Manipula arquivos INI
using Org.Mentalis.Files;

namespace prjSystem
{
    /// <summary>
    /// Class para Manutenção da movimentação financeira do sistema
    /// </summary>
    class clsMovimentacao
    {
        #region campos banco de dados
        /// <summary>
        /// Cria todos os atributos baseado nos atributos do banco de dados 
        /// </summary>
        private int _movimentacao_id;
        public int movimentacao_id
        {
            get
            {
                return _movimentacao_id;
            }
            set
            {
                _movimentacao_id = value;
            }
        }
        private int _cliente_id;
        public int cliente_id
        {
            get
            {
                return _cliente_id;
            }
            set
            {
                _cliente_id = value;
            }
        }
        private string _datavencimento;
        public string datavencimento
        {
            get
            {
                return _datavencimento;
            }
            set
            {
                _datavencimento = value;
            }
        }
        private string _datapagamento;
        public string datapagamento
        {
            get
            {
                return _datapagamento;
            }
            set
            {
                _datapagamento = value;
            }
        }
        private string _valor;
        public string valor
        {
            get
            {
                return _valor;
            }
            set
            {
                _valor = value;
            }
        }
        private string _valorpago;
        public string valorpago
        {
            get
            {
                return _valorpago;
            }
            set
            {
                _valorpago = value;
            }
        }
        private string _referencia;
        public string referencia
        {
            get
            {
                return _referencia;
            }
            set
            {
                _referencia = value;
            }
        }
        private string _comissaopai;
        public string comissaopai
        {
            get
            {
                return _comissaopai;
            }
            set
            {
                _comissaopai = value;
            }
        }
        private string _comissaoavo;
        public string comissaoavo
        {
            get
            {
                return _comissaoavo;
            }
            set
            {
                _comissaoavo = value;
            }
        }
        private string _saldo;
        public string saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                _saldo = value;
            }
        }
        private string _pagoa;
        public string pagoa
        {
            get
            {
                return _pagoa;
            }
            set
            {
                _pagoa = value;
            }
        }
        private string _status;
        public string status
        {
            get
            {
                return _status;
            }
            set
            {
                _status = value;
            }
        }
        private string _datapagamentoavo;
        public string datapagamentoavo
        {
            get
            {
                return _datapagamentoavo;
            }
            set
            {
                _datapagamentoavo = value;
            }
        }
        private string _datapagamentopai;
        public string datapagamentopai
        {
            get
            {
                return _datapagamentopai;
            }
            set
            {
                _datapagamentopai = value;
            }
        }
        #endregion
        /// <summary>Metodo que executa uma Query SQL que retorna um DataSet</summary>
        /// <param name="strDescricao">Query SQL a ser executada</param>
        /// <returns>Retorna um DataSet com o resultado da consulta da Query SQL</returns>
        public DataSet Listar(string strDescricao)
        {
            //Cria um stringBuilder para concatenar a Query
            StringBuilder strQuery = new StringBuilder();
            strQuery.Append(" SELECT movimentacao.movimentacao_id, movimentacao.cliente_id, movimentacao.datavencimento, ");
            strQuery.Append(" movimentacao.datapagamento, movimentacao.valor, movimentacao.valorpago, movimentacao.referencia, ");
            strQuery.Append(" movimentacao.comissaopai, movimentacao.comissaoavo, movimentacao.saldo, movimentacao.pagoa, ");
            strQuery.Append(" movimentacao.status, movimentacao.datapagamentoavo, movimentacao.datapagamentopai, cliente.nome, cliente.cpf, cliente.vippai_id, vippai.nome as vippai,  ");
            strQuery.Append(" vippai.cpf as vippaicpf, vippai.vipavo_id, vippai.painome as vipavonome, vippai.paicpf as vipavocpf ");

            strQuery.Append(" FROM movimentacao, cliente, vippai ");
            strQuery.Append(" WHERE movimentacao.cliente_id = cliente.cliente_id ");
            strQuery.Append(" AND   cliente.vippai_id = vippai.vippai_id ");
            //adiciona o filtro de parametro case esteja fazendo uma pesquisa
            if (!(strDescricao.Equals(string.Empty)))
            {
                strQuery.Append(" AND nome like '%" + strDescricao + "%' ");
            }
            //executa o metodo RetornaDataSet da classe banco de dados e retorna o DataSet
            clsBancoDados clsBancoDados = new clsBancoDados();
            return clsBancoDados.RetornaDataSet(strQuery.ToString());
        }

        /// <summary> Metodo utilizado nas pesquisas </summary>
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
            strQuery.Append(" SELECT movimentacao.movimentacao_id, movimentacao.cliente_id, movimentacao.datavencimento, ");
            strQuery.Append(" movimentacao.datapagamento, movimentacao.valor, movimentacao.valorpago, movimentacao.referencia, ");
            strQuery.Append(" movimentacao.comissaopai, movimentacao.comissaoavo, movimentacao.saldo, movimentacao.pagoa, ");
            strQuery.Append(" movimentacao.status, movimentacao.datapagamentoavo, movimentacao.datapagamentopai, cliente.nome, cliente.cpf, cliente.vippai_id, vippai.nome as vippai,  ");
            strQuery.Append(" vippai.cpf as vippaicpf, vippai.painome as vipavonome, vippai.paicpf as vipavocpf ");

            strQuery.Append(" FROM movimentacao, cliente, vippai ");
            strQuery.Append(" WHERE movimentacao.cliente_id = cliente.cliente_id ");
            strQuery.Append(" AND   cliente.vippai_id = vippai.vippai_id ");
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

        /// <summary> Utilizado para localizar o registro que vai entrar em edição </summary>
        /// <param name="intCodigo">Informe o código do registro a ser editado</param>
        /// <returns>Retorna um DataSet com a tupla que sera colocada em edição</returns>
        public DataSet ListarMovimentacao(int intCodigo)
        {
            StringBuilder strQuery = new StringBuilder();
            strQuery.Append(" SELECT movimentacao.movimentacao_id, movimentacao.cliente_id, movimentacao.datavencimento, ");
            strQuery.Append(" movimentacao.datapagamento, movimentacao.valor, movimentacao.valorpago, movimentacao.referencia, ");
            strQuery.Append(" movimentacao.comissaopai, movimentacao.comissaoavo, movimentacao.saldo, movimentacao.pagoa, ");
            strQuery.Append(" movimentacao.status, movimentacao.datapagamentoavo, movimentacao.datapagamentopai, cliente.nome, cliente.cpf, cliente.vippai_id, vippai.nome as vippai,  ");
            strQuery.Append(" vippai.cpf as vippaicpf, vippai.vipavo_id, vippai.painome as vipavonome, vippai.paicpf as vipavocpf ");

            strQuery.Append(" FROM movimentacao, cliente, vippai ");
            strQuery.Append(" WHERE movimentacao.cliente_id = cliente.cliente_id ");
            strQuery.Append(" AND   cliente.vippai_id = vippai.vippai_id ");
            strQuery.Append(" AND   movimentacao.movimentacao_id = " + intCodigo + " ");
            clsBancoDados clsBancoDados = new clsBancoDados();
            return clsBancoDados.RetornaDataSet(strQuery.ToString());
        }
        /// <summary> Utilizado para localizar o registro por Cliente</summary>
        /// <param name="intCodigo">Informe o código do cliente</param>
        /// <returns>Retorna um DataSet com as tuplas</returns>
        public DataSet ListarMovimentacaoCliente(int intCodigo)
        {
            StringBuilder strQuery = new StringBuilder();
            strQuery.Append(" SELECT movimentacao.movimentacao_id, movimentacao.cliente_id, movimentacao.datavencimento, ");
            strQuery.Append(" movimentacao.datapagamento, movimentacao.valor, movimentacao.valorpago, movimentacao.referencia, ");
            strQuery.Append(" movimentacao.comissaopai, movimentacao.comissaoavo, movimentacao.saldo, movimentacao.pagoa, ");
            strQuery.Append(" movimentacao.status, movimentacao.datapagamentoavo, movimentacao.datapagamentopai, cliente.nome, cliente.cpf, cliente.vippai_id, vippai.nome as vippai,  ");
            strQuery.Append(" vippai.cpf as vippaicpf, vippai.painome as vipavonome, vippai.paicpf as vipavocpf ");

            strQuery.Append(" FROM movimentacao, cliente, vippai ");
            strQuery.Append(" WHERE movimentacao.cliente_id = cliente.cliente_id ");
            strQuery.Append(" AND   cliente.vippai_id = vippai.vippai_id ");
            strQuery.Append(" AND   movimentacao.cliente_id = " + intCodigo + " ");
            clsBancoDados clsBancoDados = new clsBancoDados();
            return clsBancoDados.RetornaDataSet(strQuery.ToString());
        }
        /// <summary> Exclui um registro do banco de dados </summary>
        /// <param name="intCodigo">Informe o código do registro a ser excluido</param>
        public void Excluir(int intCodigo)
        {
            StringBuilder strQuery = new StringBuilder();
            strQuery.Append(" DELETE FROM movimentacao ");
            strQuery.Append(" WHERE movimentacao_id = " + intCodigo + " ");
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
            strQuery.Append(" INSERT INTO movimentacao ");
            strQuery.Append(" ( ");
            strQuery.Append("   movimentacao_id, ");
            strQuery.Append("   cliente_id, ");
            strQuery.Append("   datavencimento, ");
            if (_datapagamento != "")
                strQuery.Append("   datapagamento, ");
            strQuery.Append("   valor, ");
            strQuery.Append("   valorpago, ");
            strQuery.Append("   referencia, ");
            strQuery.Append("   comissaopai, ");
            strQuery.Append("   comissaoavo, ");
            strQuery.Append("   saldo, ");
            strQuery.Append("   pagoa, ");
            if (_datapagamentoavo != "")
                strQuery.Append("   datapagamentoavo, ");
            if (_datapagamentopai != "")
                strQuery.Append("   datapagamentopai, ");
            strQuery.Append("   status ");
            strQuery.Append(" ) ");
            strQuery.Append(" VALUES ");
            strQuery.Append(" ( ");
            strQuery.Append("   '" + clsBancoDados.GeraID("movimentacao", "movimentacao_id") + "', ");
            strQuery.Append("   '" + _cliente_id + "', ");
            strQuery.Append("   '" + _datavencimento + "', ");
            if (_datapagamento != "")
                strQuery.Append("   '" + _datapagamento + "', ");
            strQuery.Append("   '" + _valor + "', ");
            strQuery.Append("   '" + _valorpago + "', ");
            strQuery.Append("   '" + _referencia + "', ");
            strQuery.Append("   '" + _comissaopai + "', ");
            strQuery.Append("   '" + _comissaoavo + "', ");
            strQuery.Append("   '" + _saldo + "', ");
            strQuery.Append("   '" + _pagoa + "', ");
            if (_datapagamentoavo != "")
                strQuery.Append("   '" + _datapagamentoavo + "', ");
            if (_datapagamentopai != "")
                strQuery.Append("   '" + _datapagamentopai + "', ");
            strQuery.Append("   '" + _status + "' ");
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
            strQuery.Append(" UPDATE movimentacao ");
            strQuery.Append(" SET ");
            strQuery.Append("     movimentacao_id = '" + _movimentacao_id + "', ");
            strQuery.Append("     cliente_id = '" + _cliente_id + "', ");
            strQuery.Append("     datavencimento = '" + _datavencimento + "', ");
            if (_datapagamento != string.Empty)
                strQuery.Append("     datapagamento = '" + _datapagamento + "', ");
            strQuery.Append("     valor = '" + _valor + "', ");
            strQuery.Append("     valorpago = '" + _valorpago + "', ");
            strQuery.Append("     referencia = '" + _referencia + "', ");
            strQuery.Append("     comissaopai = '" + _comissaopai + "', ");
            strQuery.Append("     comissaoavo = '" + _comissaoavo + "', ");
            strQuery.Append("     saldo = '" + _saldo + "', ");
            strQuery.Append("     pagoa = '" + _pagoa + "', ");
            if (_datapagamentoavo != string.Empty)
                strQuery.Append("     datapagamentoavo = '" + _datapagamentoavo + "', ");
            if (_datapagamentopai != string.Empty)
                strQuery.Append("     datapagamentopai = '" + _datapagamentopai + "', ");
            strQuery.Append("     status = '" + _status + "' ");
            strQuery.Append(" WHERE ");
            strQuery.Append("      movimentacao_id = " + _movimentacao_id + " ");
            clsBancoDados clsBancoDados = new clsBancoDados();
            clsBancoDados.ExecutaComando(strQuery.ToString());
            clsConfig clsConfig = new clsConfig();
            MessageBox.Show(clsConfig.msgGravadoComSucesso, Application.ProductName,
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        /// <summary>
        /// Gera a movimentação da Taxa de Filiação 
        /// </summary>
        public void GerarTaxaAdesao(string id, double VlrAdesao, double VlrPai, double VlrAvo, DateTime data, string pagoa)
        {
            clsBancoDados clsBancoDados = new clsBancoDados();

            _cliente_id = int.Parse(id);
            _datavencimento = data.ToString("MM/dd/yyy");
            _datapagamento = data.ToString("MM/dd/yyy");
            _valor = VlrAdesao.ToString().Replace(",", ".");
            _valorpago = VlrAdesao.ToString().Replace(",", ".");
            _referencia = "ADESÃO";
            _comissaopai = VlrPai.ToString().Replace(",", ".");
            _comissaoavo = VlrAvo.ToString().Replace(",", ".");
            _saldo = (VlrAdesao - VlrPai - VlrAvo).ToString().Replace(",", ".");
            _pagoa = pagoa;
            _status = "RECEBIDO";

            //grava no banco de dados
            StringBuilder strQuery = new StringBuilder();
            strQuery.Append(" INSERT INTO movimentacao ");
            strQuery.Append(" ( ");
            strQuery.Append("   movimentacao_id, ");
            strQuery.Append("   cliente_id, ");
            strQuery.Append("   datavencimento, ");
            strQuery.Append("   datapagamento, ");
            strQuery.Append("   valor, ");
            strQuery.Append("   valorpago, ");
            strQuery.Append("   referencia, ");
            strQuery.Append("   comissaopai, ");
            strQuery.Append("   comissaoavo, ");
            strQuery.Append("   saldo, ");
            strQuery.Append("   pagoa, ");
            strQuery.Append("   status ");
            strQuery.Append(" ) ");
            strQuery.Append(" VALUES ");
            strQuery.Append(" ( ");
            strQuery.Append("   '" + clsBancoDados.GeraID("movimentacao", "movimentacao_id") + "', ");
            strQuery.Append("   '" + _cliente_id + "', ");
            strQuery.Append("   '" + _datavencimento + "', ");
            strQuery.Append("   '" + _datapagamento + "', ");
            strQuery.Append("   '" + _valor + "', ");
            strQuery.Append("   '" + _valorpago + "', ");
            strQuery.Append("   '" + _referencia + "', ");
            strQuery.Append("   '" + _comissaopai + "', ");
            strQuery.Append("   '" + _comissaoavo + "', ");
            strQuery.Append("   '" + _saldo + "', ");
            strQuery.Append("   '" + _pagoa + "', ");
            strQuery.Append("   '" + _status + "' ");
            strQuery.Append(" ) ");
            clsBancoDados.ExecutaComando(strQuery.ToString());
        }

        /// <summary>
        /// Gera a movimentação da Taxa de Filiação 
        /// </summary>
        public void Gerar12Mensalidade(string id, DateTime dataInicial)
        {
            //[mensal]
            //taxaAdesao=25,00
            //taxaPai=15,00
            //taxaAvo=10,00
            //taxaMensal=13,80
            //Busca no ini os valores de taxa e porcentagem
            string str_taxaAdesao = "";
            string str_taxaPai = "";
            string str_taxaAvo = "";
            string str_taxaMensal = "";
            string file = "";

            clsBancoDados clsBancoDados = new clsBancoDados();

            file = Application.StartupPath;
            file += "\\conf.ini";
            IniReader ini = new IniReader(file);
            str_taxaAdesao = ini.ReadString("mensal", "taxaAdesao");
            str_taxaPai = ini.ReadString("mensal", "taxaPai");
            str_taxaAvo = ini.ReadString("mensal", "taxaAvo");
            str_taxaMensal = ini.ReadString("mensal", "taxaMensal");
            //gera a taxa de adesao
            GerarTaxaAdesao(id, double.Parse(str_taxaAdesao), double.Parse(str_taxaPai), double.Parse(str_taxaAvo), dataInicial, "A PAGAR AMBOS");

            //gera mensalidade
            for (int i = 1; i <= 12; i++)
            {
                _cliente_id = int.Parse(id);
                dataInicial = dataInicial.AddMonths(1);
                _datavencimento = dataInicial.ToString("MM/dd/yyy");
                //_datapagamento = "";
                _valor = str_taxaMensal.ToString().Replace(",", ".");
                _valorpago = "0";
                _referencia = "MENSALIDADE";
                _comissaopai = "0";
                _comissaoavo = "0";
                _saldo = (double.Parse(str_taxaAdesao) - double.Parse(str_taxaPai) - double.Parse(str_taxaAvo)).ToString().Replace(",", ".");
                _pagoa = "NÃO SE PAGA";
                _status = "A RECEBER";

                //grava no banco de dados
                StringBuilder strQuery = new StringBuilder();
                strQuery.Append(" INSERT INTO movimentacao ");
                strQuery.Append(" ( ");
                strQuery.Append("   movimentacao_id, ");
                strQuery.Append("   cliente_id, ");
                strQuery.Append("   datavencimento, ");
                strQuery.Append("   valor, ");
                strQuery.Append("   valorpago, ");
                strQuery.Append("   referencia, ");
                strQuery.Append("   comissaopai, ");
                strQuery.Append("   comissaoavo, ");
                strQuery.Append("   saldo, ");
                strQuery.Append("   pagoa, ");
                strQuery.Append("   status ");
                strQuery.Append(" ) ");
                strQuery.Append(" VALUES ");
                strQuery.Append(" ( ");
                strQuery.Append("   '" + clsBancoDados.GeraID("movimentacao", "movimentacao_id") + "', ");
                strQuery.Append("   '" + _cliente_id + "', ");
                strQuery.Append("   '" + _datavencimento + "', ");
                strQuery.Append("   '" + _valor + "', ");
                strQuery.Append("   '" + _valorpago + "', ");
                strQuery.Append("   '" + _referencia + "', ");
                strQuery.Append("   '" + _comissaopai + "', ");
                strQuery.Append("   '" + _comissaoavo + "', ");
                strQuery.Append("   '" + _saldo + "', ");
                strQuery.Append("   '" + _pagoa + "', ");
                strQuery.Append("   '" + _status + "' ");
                strQuery.Append(" ) ");
                clsBancoDados.ExecutaComando(strQuery.ToString());
            }
        }
        /// <summary>
        /// Gera a movimentação da Taxa de Filiação 
        /// </summary>
        public void GerarMensalidadeAnual2x(string id, DateTime dataInicial)
        {
            //[anual2x]
            //taxaAdesao=25,00
            //taxaPai=15,00
            //taxaAvo=10,00
            //taxaMensal=60,00
            //taxaPaiMensal=10,00

            //Busca no ini os valores de taxa e porcentagem
            string str_taxaAdesao = "";
            string str_taxaPai = "";
            string str_taxaAvo = "";
            string str_taxaMensal = "";
            string str_taxaPaiMensal = "";
            string file = "";

            clsBancoDados clsBancoDados = new clsBancoDados();

            file = Application.StartupPath;
            file += "\\conf.ini";
            IniReader ini = new IniReader(file);
            str_taxaAdesao = ini.ReadString("anual2x", "taxaAdesao");
            str_taxaPai = ini.ReadString("anual2x", "taxaPai");
            str_taxaAvo = ini.ReadString("anual2x", "taxaAvo");
            str_taxaMensal = ini.ReadString("anual2x", "taxaMensal");
            str_taxaPaiMensal = ini.ReadString("anual2x", "taxaPaiMensal");
            //gera a taxa de adesao
            GerarTaxaAdesao(id, double.Parse(str_taxaAdesao), double.Parse(str_taxaPai), double.Parse(str_taxaAvo), dataInicial, "A PAGAR AMBOS");
            //gera mensalidade
            for (int i = 1; i <= 2; i++)
            {
                _cliente_id = int.Parse(id);
                dataInicial = dataInicial.AddMonths(1);
                _datavencimento = dataInicial.ToString("MM/dd/yyy");
                //str_taxaPai.Replace(",", ".");
                _valor = str_taxaMensal.Replace(",", ".");
                _valorpago = "0";
                _referencia = "ANUAL 2X";
                _comissaopai = str_taxaPaiMensal.Replace(",", ".");
                _comissaoavo = "0";
                _saldo = (double.Parse(str_taxaMensal) - double.Parse(str_taxaPaiMensal)).ToString().Replace(",", ".");
                _pagoa = "A PAGAR PAI";
                _status = "A RECEBER";

                //grava no banco de dados
                StringBuilder strQuery = new StringBuilder();
                strQuery.Append(" INSERT INTO movimentacao ");
                strQuery.Append(" ( ");
                strQuery.Append("   movimentacao_id, ");
                strQuery.Append("   cliente_id, ");
                strQuery.Append("   datavencimento, ");
                strQuery.Append("   valor, ");
                strQuery.Append("   valorpago, ");
                strQuery.Append("   referencia, ");
                strQuery.Append("   comissaopai, ");
                strQuery.Append("   comissaoavo, ");
                strQuery.Append("   saldo, ");
                strQuery.Append("   pagoa, ");
                strQuery.Append("   status ");
                strQuery.Append(" ) ");
                strQuery.Append(" VALUES ");
                strQuery.Append(" ( ");
                strQuery.Append("   '" + clsBancoDados.GeraID("movimentacao", "movimentacao_id") + "', ");
                strQuery.Append("   '" + _cliente_id + "', ");
                strQuery.Append("   '" + _datavencimento + "', ");
                strQuery.Append("   '" + _valor + "', ");
                strQuery.Append("   '" + _valorpago + "', ");
                strQuery.Append("   '" + _referencia + "', ");
                strQuery.Append("   '" + _comissaopai + "', ");
                strQuery.Append("   '" + _comissaoavo + "', ");
                strQuery.Append("   '" + _saldo + "', ");
                strQuery.Append("   '" + _pagoa + "', ");
                strQuery.Append("   '" + _status + "' ");
                strQuery.Append(" ) ");
                clsBancoDados.ExecutaComando(strQuery.ToString());
            }
        }
        /// <summary>
        /// Gera a movimentação da Taxa de Filiação 
        /// </summary>
        public void GerarMensalidadeAnual(string id, DateTime dataInicial)
        {
            //taxaAdesao=20,00
            //taxaPai=20,00
            //taxaAvo=0,00
            //taxaMensal=100,00

            //Busca no ini os valores de taxa e porcentagem
            string str_taxaAdesao = "";
            string str_taxaPai = "";
            string str_taxaAvo = "";
            string str_taxaMensal = "";
            string str_taxaPaiMensal = "";
            string file = "";

            clsBancoDados clsBancoDados = new clsBancoDados();

            file = Application.StartupPath;
            file += "\\conf.ini";
            IniReader ini = new IniReader(file);
            str_taxaAdesao = ini.ReadString("anual", "taxaAdesao");
            str_taxaPai = ini.ReadString("anual", "taxaPai");
            str_taxaAvo = ini.ReadString("anual", "taxaAvo");
            str_taxaMensal = ini.ReadString("anual", "taxaMensal");
            str_taxaPaiMensal = ini.ReadString("anual", "taxaPaiMensal");
            //gera a taxa de adesao
            GerarTaxaAdesao(id, double.Parse(str_taxaAdesao), double.Parse(str_taxaPai), double.Parse(str_taxaAvo), dataInicial, "A PAGAR AMBOS");
            //gera mensalidade
            for (int i = 1; i <= 1; i++)
            {
                _cliente_id = int.Parse(id);
                //dataInicial = dataInicial.AddMonths(1);
                _datavencimento = dataInicial.ToString("MM/dd/yyy");
                _datapagamento = dataInicial.ToString("MM/dd/yyy");
                _valor = str_taxaMensal.Replace(",", ".");
                _valorpago = _valor;
                _referencia = "ANUAL";
                _comissaopai = str_taxaPaiMensal.Replace(",", ".");
                _comissaoavo = "0";
                _saldo = (double.Parse(str_taxaMensal) - double.Parse(str_taxaPaiMensal)).ToString().Replace(",", ".");
                _pagoa = "A PAGAR PAI";
                _status = "RECEBIDO";

                //grava no banco de dados
                StringBuilder strQuery = new StringBuilder();
                strQuery.Append(" INSERT INTO movimentacao ");
                strQuery.Append(" ( ");
                strQuery.Append("   movimentacao_id, ");
                strQuery.Append("   cliente_id, ");
                strQuery.Append("   datavencimento, ");
                strQuery.Append("   datapagamento, ");
                strQuery.Append("   valor, ");
                strQuery.Append("   valorpago, ");
                strQuery.Append("   referencia, ");
                strQuery.Append("   comissaopai, ");
                strQuery.Append("   comissaoavo, ");
                strQuery.Append("   saldo, ");
                strQuery.Append("   pagoa, ");
                strQuery.Append("   status ");
                strQuery.Append(" ) ");
                strQuery.Append(" VALUES ");
                strQuery.Append(" ( ");
                strQuery.Append("   '" + clsBancoDados.GeraID("movimentacao", "movimentacao_id") + "', ");
                strQuery.Append("   '" + _cliente_id + "', ");
                strQuery.Append("   '" + _datavencimento + "', ");
                strQuery.Append("   '" + _datapagamento + "', ");
                strQuery.Append("   '" + _valor + "', ");
                strQuery.Append("   '" + _valorpago + "', ");
                strQuery.Append("   '" + _referencia + "', ");
                strQuery.Append("   '" + _comissaopai + "', ");
                strQuery.Append("   '" + _comissaoavo + "', ");
                strQuery.Append("   '" + _saldo + "', ");
                strQuery.Append("   '" + _pagoa + "', ");
                strQuery.Append("   '" + _status + "' ");
                strQuery.Append(" ) ");
                clsBancoDados.ExecutaComando(strQuery.ToString());
            }
        }
    }
}
