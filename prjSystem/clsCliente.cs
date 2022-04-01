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
    /// Class para o cadastro de Clientes
    /// </summary>
    class clsCliente
    {
        #region campos banco de dados
        /// <summary>
        /// Cria todos os atributos baseado nos atributos do banco de dados 
        /// </summary>
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
        private int _banco_id;
        public int banco_id
        {
            get
            {
                return _banco_id;
            }
            set
            {
                _banco_id = value;
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
        private string _datanascimento;
        public string datanascimento
        {
            get
            {
                return _datanascimento;
            }
            set
            {
                _datanascimento = value;
            }
        }
        private string _pai;
        public string pai
        {
            get
            {
                return _pai;
            }
            set
            {
                _pai = value;
            }
        }
        private string _mae;
        public string mae
        {
            get
            {
                return _mae;
            }
            set
            {
                _mae = value;
            }
        }
        //armazena as opções de pagamento: mensal, semestral, anual
        private string _formadepagamento;
        public string formadepagamento
        {
            get
            {
                return _formadepagamento;
            }
            set
            {
                _formadepagamento = value;
            }
        }
        private string _cc;
        public string cc
        {
            get
            {
                return _cc;
            }
            set
            {
                _cc = value;
            }
        }
        private string _ag;
        public string ag
        {
            get
            {
                return _ag;
            }
            set
            {
                _ag = value;
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
        private string _cpf;
        public string cpf
        {
            get
            {
                return _cpf;
            }
            set
            {
                _cpf = value;
            }
        }
        private string _rg;
        public string rg
        {
            get
            {
                return _rg;
            }
            set
            {
                _rg = value;
            }
        }
        private string _datacadastro;
        public string datacadastro
        {
            get
            {
                return _datacadastro;
            }
            set
            {
                _datacadastro = value;
            }
        }
        private string _telefones;
        public string telefones
        {
            get
            {
                return _telefones;
            }
            set
            {
                _telefones = value;
            }
        }
        private string _email;
        public string email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
            }
        }
        private string _obs;
        public string obs
        {
            get
            {
                return _obs;
            }
            set
            {
                _obs = value;
            }
        }
        private string _natural_id;
        public string natural_id
        {
            get
            {
                return _natural_id;
            }
            set
            {
                _natural_id = value;
            }
        }
        private string _estadocivil;
        public string estadocivil
        {
            get
            {
                return _estadocivil;
            }
            set
            {
                _estadocivil = value;
            }
        }
        private string _profissao;
        public string profissao
        {
            get
            {
                return _profissao;
            }
            set
            {
                _profissao = value;
            }
        }
        private string _nacionalidade;
        public string nacionaldidade
        {
            get
            {
                return _nacionalidade;
            }
            set
            {
                _nacionalidade = value;
            }
        }
        private string _sexo;
        public string sexo
        {
            get
            {
                return _sexo;
            }
            set
            {
                _sexo = value;
            }
        }
        private int _vippai_id;
        public int vippai_id
        {
            get
            {
                return _vippai_id;
            }
            set
            {
                _vippai_id = value;
            }
        }
        private string _numero;
        public string numero
        {
            get
            {
                return _numero;
            }
            set
            {
                _numero = value;
            }
        }
        private string _contrato;
        public string contrato
        {
            get
            {
                return _contrato;
            }
            set
            {
                _contrato = value;
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
            //dados do cliente
            strQuery.Append(" SELECT cliente.cliente_id, cliente.nome, cliente.datanascimento, cliente.pai, cliente.mae, ");
            strQuery.Append(" cliente.formadepagamento, cliente.cc, cliente.ag, cliente.status, cliente.cpf, cliente.rg, ");
            strQuery.Append(" cliente.datacadastro, cliente.telefones, cliente.email, cliente.obs, cliente.estadocivil, ");
            strQuery.Append(" cliente.profissao, cliente.nacionalidade, cliente.sexo, cliente.numero, cliente.contrato, natural_id,");
            //dados do endereco
            strQuery.Append(" enderecos.enderecos_id, enderecos.logradouro, enderecos.cep, ");
            strQuery.Append(" enderecos.bairros_id, bairros.nome as bairro, enderecos.municipio_id, ");
            strQuery.Append(" municipio.nome as municipio, municipio.uf, ");
            //natural
            strQuery.Append(" vwmunicipio.nome as vwmunicipio, vwmunicipio.uf as v_uf, ");
            //banco
            strQuery.Append(" banco.banco_id, banco.banco, ");
            //vippai
            strQuery.Append(" vippai.vippai_id, vippai.nome as vippai, vippai.cpf as vippaicpf, vippai.vipavo_id,");
            strQuery.Append(" vippai.painome as vipavo, vippai.paicpf as vipavocpf ");
            //filtros/relacionamentos
            strQuery.Append(" FROM cliente, enderecos, bairros, municipio, vwmunicipio, vippai,banco ");
            strQuery.Append(" WHERE cliente.enderecos_id = enderecos.enderecos_id");
            strQuery.Append(" AND enderecos.bairros_id = bairros.bairros_id ");
            strQuery.Append(" AND enderecos.municipio_id = municipio.municipio_id ");
            strQuery.Append(" AND cliente.natural_id = vwmunicipio.municipio_id ");
            strQuery.Append(" AND cliente.vippai_id = vippai.vippai_id ");
            strQuery.Append(" AND cliente.banco_id = banco.banco_id ");
            //adiciona o filtro de parametro case esteja fazendo uma pesquisa
            if (!(strDescricao.Equals(string.Empty)))
            {
                strQuery.Append(" AND cliente.nome like '%" + strDescricao + "%' ");
            }
            //executa o metodo RetornaDataSet da classe banco de dados e retorna o DataSet
            clsBancoDados clsBancoDados = new clsBancoDados();
            return clsBancoDados.RetornaDataSet(strQuery.ToString());
        }

        public DataSet ListarExportar()
        {
            //Cria um stringBuilder para concatenar a Query
            StringBuilder strQuery = new StringBuilder();
            //dados do cliente
            strQuery.Append(" SELECT cliente_id, enderecos_id, banco_id, nome, datanascimento, pai, mae, ");
            strQuery.Append(" formadepagamento, cc, ag, status, cpf, rg, ");
            strQuery.Append(" datacadastro, telefones, email, obs, natural_id, estadocivil, ");
            strQuery.Append(" profissao, nacionalidade, sexo, vippai_id, numero, contrato ");
            
            //filtros/relacionamentos
            strQuery.Append(" FROM cliente ");
            
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
            //dados do cliente
            strQuery.Append(" SELECT cliente.cliente_id, cliente.nome, cliente.datanascimento, cliente.pai, cliente.mae, ");
            strQuery.Append(" cliente.formadepagamento, cliente.cc, cliente.ag, cliente.status, cliente.cpf, cliente.rg, ");
            strQuery.Append(" cliente.datacadastro, cliente.telefones, cliente.email, cliente.obs, cliente.estadocivil, ");
            strQuery.Append(" cliente.profissao, cliente.nacionalidade, cliente.sexo, cliente.numero, cliente.contrato, cliente.natural_id, ");
            //dados do endereco
            strQuery.Append(" enderecos.enderecos_id, enderecos.logradouro, enderecos.cep, ");
            strQuery.Append(" enderecos.bairros_id, bairros.nome as bairro, enderecos.municipio_id, ");
            strQuery.Append(" municipio.nome as municipio, municipio.uf, ");
            //natural
            strQuery.Append(" vwmunicipio.nome as vwmunicipio, vwmunicipio.uf as v_uf, ");
            //banco
            strQuery.Append(" banco.banco_id, banco.banco, ");
            //vippai
            strQuery.Append(" vippai.vippai_id, vippai.nome as vippai, vippai.cpf as vippaicpf, vippai.vipavo_id,");
            strQuery.Append(" vippai.painome as vipavo, vippai.paicpf as vipavocpf ");
            //filtros/relacionamentos
            strQuery.Append(" FROM cliente, enderecos, bairros, municipio, vwmunicipio, vippai,banco ");
            strQuery.Append(" WHERE cliente.enderecos_id = enderecos.enderecos_id");
            strQuery.Append(" AND enderecos.bairros_id = bairros.bairros_id ");
            strQuery.Append(" AND enderecos.municipio_id = municipio.municipio_id ");
            strQuery.Append(" AND cliente.natural_id = vwmunicipio.municipio_id ");
            strQuery.Append(" AND cliente.vippai_id = vippai.vippai_id ");
            strQuery.Append(" AND cliente.banco_id = banco.banco_id ");
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
        public DataSet ListarCliente(int intCodigo)
        {
            StringBuilder strQuery = new StringBuilder();
            //dados do cliente
            strQuery.Append(" SELECT cliente.cliente_id, cliente.nome, cliente.datanascimento, cliente.pai, cliente.mae, ");
            strQuery.Append(" cliente.formadepagamento, cliente.cc, cliente.ag, cliente.status, cliente.cpf, cliente.rg, ");
            strQuery.Append(" cliente.datacadastro, cliente.telefones, cliente.email, cliente.obs, cliente.estadocivil, ");
            strQuery.Append(" cliente.profissao, cliente.nacionalidade, cliente.sexo, cliente.numero, cliente.contrato, cliente.natural_id,");
            //dados do endereco
            strQuery.Append(" enderecos.enderecos_id, enderecos.logradouro, enderecos.cep, ");
            strQuery.Append(" enderecos.bairros_id, bairros.nome as bairro, enderecos.municipio_id, ");
            strQuery.Append(" municipio.nome as municipio, municipio.uf, ");
            //natural
            strQuery.Append(" vwmunicipio.nome as vwmunicipio, vwmunicipio.uf as v_uf, ");
            //banco
            strQuery.Append(" banco.banco_id, banco.banco, ");
            //vippai
            strQuery.Append(" vippai.vippai_id, vippai.nome as vippai, vippai.cpf as vippaicpf, vippai.vipavo_id,");
            strQuery.Append(" vippai.painome as vipavo, vippai.paicpf as vipavocpf ");
            //filtros/relacionamentos
            strQuery.Append(" FROM cliente, enderecos, bairros, municipio, vwmunicipio, vippai,banco ");
            strQuery.Append(" WHERE cliente.enderecos_id = enderecos.enderecos_id");
            strQuery.Append(" AND enderecos.bairros_id = bairros.bairros_id ");
            strQuery.Append(" AND enderecos.municipio_id = municipio.municipio_id ");
            strQuery.Append(" AND cliente.natural_id = vwmunicipio.municipio_id ");
            strQuery.Append(" AND cliente.vippai_id = vippai.vippai_id ");
            strQuery.Append(" AND cliente.banco_id = banco.banco_id ");
            strQuery.Append(" AND cliente.cliente_id = " + intCodigo + " ");
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
            strQuery.Append(" DELETE FROM cliente ");
            strQuery.Append(" WHERE cliente_id = " + intCodigo + " ");
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
        public string Gravar()
        {
            clsBancoDados clsBancoDados = new clsBancoDados();
            string id = clsBancoDados.GeraID("cliente", "cliente_id");
            StringBuilder strQuery = new StringBuilder();
            strQuery.Append(" INSERT INTO cliente ");
            strQuery.Append(" ( ");
            strQuery.Append("   cliente_id, ");
            strQuery.Append("   enderecos_id, ");
            strQuery.Append("   banco_id, ");
            strQuery.Append("   nome, ");
            strQuery.Append("   datanascimento, ");
            strQuery.Append("   pai, ");
            strQuery.Append("   mae, ");
            strQuery.Append("   formadepagamento, ");
            strQuery.Append("   cc, ");
            strQuery.Append("   ag, ");
            strQuery.Append("   status, ");
            strQuery.Append("   cpf, ");
            strQuery.Append("   rg, ");
            strQuery.Append("   datacadastro, ");
            strQuery.Append("   telefones, ");
            strQuery.Append("   email, ");
            strQuery.Append("   obs, ");
            strQuery.Append("   natural_id, ");
            strQuery.Append("   estadocivil, ");
            strQuery.Append("   profissao, ");
            strQuery.Append("   nacionalidade, ");
            strQuery.Append("   sexo, ");
            strQuery.Append("   vippai_id, ");
            strQuery.Append("   numero, ");
            strQuery.Append("   contrato ");
            strQuery.Append(" ) ");

            strQuery.Append(" VALUES ");
            strQuery.Append(" ( ");
            strQuery.Append("   '" + id + "', ");
            strQuery.Append("   '" + _enderecos_id + "', ");
            strQuery.Append("   '" + _banco_id + "', ");
            strQuery.Append("   '" + _nome + "', ");
            strQuery.Append("   '" + Convert.ToDateTime(_datanascimento).ToString("yyy/MM/dd") + "', ");
            strQuery.Append("   '" + _pai + "', ");
            strQuery.Append("   '" + _mae + "', ");
            strQuery.Append("   '" + _formadepagamento + "', ");
            strQuery.Append("   '" + _cc + "', ");
            strQuery.Append("   '" + _ag + "', ");
            strQuery.Append("   '" + _status + "', ");
            strQuery.Append("   '" + _cpf + "', ");
            strQuery.Append("   '" + _rg + "', ");
            strQuery.Append("   '" + Convert.ToDateTime(_datacadastro).ToString("yyy/MM/dd") + "', ");
            strQuery.Append("   '" + _telefones + "', ");
            strQuery.Append("   '" + _email + "', ");
            strQuery.Append("   '" + _obs + "', ");
            strQuery.Append("   '" + _natural_id + "', ");
            strQuery.Append("   '" + _estadocivil + "', ");
            strQuery.Append("   '" + _profissao + "', ");
            strQuery.Append("   '" + _nacionalidade + "', ");
            strQuery.Append("   '" + _sexo + "', ");
            strQuery.Append("   '" + _vippai_id + "', ");
            strQuery.Append("   '" + _numero + "', ");
            strQuery.Append("   '" + _contrato + "' ");
            strQuery.Append(" ) ");
            clsBancoDados.ExecutaComando(strQuery.ToString());
            clsConfig clsConfig = new clsConfig();
            MessageBox.Show(clsConfig.msgGravadoComSucesso, Application.ProductName,
            MessageBoxButtons.OK, MessageBoxIcon.Information);
            return id;
        }

        /// <summary>
        /// Altera um registro no banco de dados, utilizando o valor do codigo 
        /// de seu atributo, setado antes da alteraçao
        /// </summary>
        public void Alterar()
        {
            StringBuilder strQuery = new StringBuilder();
            strQuery.Append(" UPDATE cliente ");
            strQuery.Append(" SET ");
            strQuery.Append("     enderecos_id = '" + _enderecos_id + "', ");
            strQuery.Append("     banco_id = '" + _banco_id + "', ");
            strQuery.Append("     nome = '" + _nome + "', ");
            strQuery.Append("     datanascimento = '" + Convert.ToDateTime(_datanascimento).ToString("yyy/MM/dd") + "', ");
            strQuery.Append("     pai = '" + _pai + "', ");
            strQuery.Append("     mae = '" + _mae + "', ");
            strQuery.Append("     formadepagamento = '" + _formadepagamento + "', ");
            strQuery.Append("     cc = '" + _cc + "', ");
            strQuery.Append("     ag = '" + _ag + "', ");
            strQuery.Append("     status = '" + _status + "', ");
            strQuery.Append("     cpf = '" + _cpf + "', ");
            strQuery.Append("     rg = '" + _rg + "', ");
            strQuery.Append("     datacadastro = '" + Convert.ToDateTime(_datacadastro).ToString("yyy/MM/dd") + "', ");
            strQuery.Append("     telefones = '" + _telefones + "', ");
            strQuery.Append("     email = '" + _email + "', ");
            strQuery.Append("     obs = '" + _obs + "', ");
            strQuery.Append("     natural_id = '" + _natural_id + "', ");
            strQuery.Append("     estadocivil = '" + _estadocivil + "', ");
            strQuery.Append("     profissao = '" + _profissao + "', ");
            strQuery.Append("     nacionalidade = '" + _nacionalidade + "', ");
            strQuery.Append("     sexo = '" + _sexo + "', ");
            strQuery.Append("     vippai_id = '" + _vippai_id + "', ");
            strQuery.Append("     numero = '" + _numero + "', ");
            strQuery.Append("     contrato = '" + _contrato + "' ");
            strQuery.Append(" WHERE ");
            strQuery.Append("      cliente_id = " + _cliente_id + " ");
            clsBancoDados clsBancoDados = new clsBancoDados();
            clsBancoDados.ExecutaComando(strQuery.ToString());
            clsConfig clsConfig = new clsConfig();
            MessageBox.Show(clsConfig.msgGravadoComSucesso, Application.ProductName,
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
