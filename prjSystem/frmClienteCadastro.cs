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
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace prjSystem
{
    public partial class frmClienteCadastro : Form
    {
        /// <summary>
        /// Formulário de Cadastro de Proprietario de Imoveis
        /// </summary>
        public frmClienteCadastro()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Cria um numerador para saber se o formulário esta sendo aberto 
        /// por uma operaçào de Inclusão ou de Alteração
        /// </summary>
        public enum Ope
        {
            Inclusao,
            Alteracao
        }
        public Ope _Operacao;
        public Ope Operacao
        {
            get
            {
                return _Operacao;
            }
            set
            {
                _Operacao = value;
            }
        }
        /// <summary>
        /// Código passado ao formulário quando ele for do tipo Alteração 
        /// para que possa saber qual registro ele deve mostrar na tela
        /// para a alteração
        /// </summary>
        public int _Codigo;
        public int Codigo
        {
            get
            {
                return _Codigo;
            }
            set
            {
                _Codigo = value;
            }
        }
        /// <summary>
        /// Valida todos os campos, e depois grava no banco de dados os novos dados
        /// </summary>
        private void btnGravar_Click(object sender, EventArgs e)
        {
            //CodVipPai
            if (txt01.Text.Equals(string.Empty))
            {
                errErro.SetError(txt02, "Informe o Vip Pai do Cliente/Filiado");
                txt01.Focus();
                return;
            }
            else
            {
                errErro.SetError(txt02, "");
            }
            //CodVipPai
            if (txt02.Text.Equals(string.Empty))
            {
                errErro.SetError(txt02, "Informe o Vip Pai do Cliente/Filiado");
                txt01.Focus();
                return;
            }
            else
            {
                errErro.SetError(txt02, "");
            }
            //nome
            if (txt04.Text.Equals(string.Empty))
            {
                errErro.SetError(txt04, "Digite o nome do Cliente/Filiado");
                txt04.Focus();
                return;
            }
            else
            {
                errErro.SetError(txt04, "");
            }
            //status
            if (txt05.Text.Equals(string.Empty))
            {
                errErro.SetError(txt05, "Escolha o Status do Cliente/Filiado");
                txt05.Focus();
                return;
            }
            else
            {
                errErro.SetError(txt05, "");
            }
            //cpf
            if (txt07.Text.Length == 14)
            {
                errErro.SetError(txt07, "");
            }
            else
            {
                errErro.SetError(txt07, "Digite somente os números do CPF");
                txt07.Focus();
                return;
            }
            //rg
            if (txt08.Text.Equals(string.Empty))
            {
                errErro.SetError(txt08, "Informe o RG/SSP do cliente/filiado");
                txt08.Focus();
                return;
            }
            else
            {
                errErro.SetError(txt08, "");
            }
            //contrato
            if (txt09.Text.Equals(string.Empty))
            {
                errErro.SetError(txt09, "Informe o Número do Contrato");
                txt09.Focus();
                return;
            }
            else
            {
                errErro.SetError(txt09, "");
            }
            //estadocivil
            if (txt11.Text.Equals(string.Empty))
            {
                errErro.SetError(txt11, "Escolha o Estado Civil do Cliente/Filiado");
                txt11.Focus();
                return;
            }
            else
            {
                errErro.SetError(txt11, "");
            }
            //nacionalidade
            if (txt12.Text.Equals(string.Empty))
            {
                errErro.SetError(txt12, "Informe a Nacionalidade do Cliente/Filiado");
                txt12.Focus();
                return;
            }
            else
            {
                errErro.SetError(txt12, "");
            }
            //sexo
            if (txt13.Text.Equals(string.Empty))
            {
                errErro.SetError(txt13, "Escolha o Sexo do Cliente/Filiado");
                txt13.Focus();
                return;
            }
            else
            {
                errErro.SetError(txt13, "");
            }
            //Natural
            if (txt14.Text.Equals(string.Empty))
            {
                errErro.SetError(txt15, "Informe a cidade que o Cliente/Filiado é natural");
                txt14.Focus();
                return;
            }
            else
            {
                errErro.SetError(txt15, "");
            }
            //Natural
            if (txt15.Text.Equals(string.Empty))
            {
                errErro.SetError(txt15, "Informe a cidade que o Cliente/Filiado é natural");
                txt14.Focus();
                return;
            }
            else
            {
                errErro.SetError(txt15, "");
            }
            //mae
            if (txt16.Text.Equals(string.Empty))
            {
                errErro.SetError(txt16, "Informe o nome da mãe do Cliente/Filiado");
                txt16.Focus();
                return;
            }
            else
            {
                errErro.SetError(txt16, "");
            }
            //Codigo Endereço
            if (txt22.Text.Equals(string.Empty))
            {
                errErro.SetError(txt23, "Digite o Código do Endereço");
                txt22.Focus();
                return;
            }
            else
            {
                errErro.SetError(txt23, "");
            }
            //Codigo Endereço
            if (txt23.Text.Equals(string.Empty))
            {
                errErro.SetError(txt23, "Digite o Código do Endereço");
                txt22.Focus();
                return;
            }
            else
            {
                errErro.SetError(txt23, "");
            }
            //numero casa
            if (txt24.Text.Equals(string.Empty))
            {
                errErro.SetError(txt24, "Digite o Numero da Casa");
                txt24.Focus();
                return;
            }
            else
            {
                errErro.SetError(txt24, "");
            }
            //Codigo Banco
            if (txt28.Text.Equals(string.Empty))
            {
                errErro.SetError(txt29, "Informe o Banco para o deposito de seus creditos");
                txt28.Focus();
                return;
            }
            else
            {
                errErro.SetError(txt29, "");
            }
            //Codigo Banco
            if (txt29.Text.Equals(string.Empty))
            {
                errErro.SetError(txt29, "Informe o Banco para o deposito de seus creditos");
                txt28.Focus();
                return;
            }
            else
            {
                errErro.SetError(txt29, "");
            }
            //Agencia
            if (txt30.Text.Equals(string.Empty))
            {
                errErro.SetError(txt30, "Informe o Agência para o deposito de seus creditos");
                txt30.Focus();
                return;
            }
            else
            {
                errErro.SetError(txt30, "");
            }
            //Conta
            if (txt31.Text.Equals(string.Empty))
            {
                errErro.SetError(txt31, "Informe a Conta para o deposito de seus creditos");
                txt31.Focus();
                return;
            }
            else
            {
                errErro.SetError(txt31, "");
            }
            //Forma de Pagamento
            if (txt32.Text.Equals(string.Empty))
            {
                errErro.SetError(txt32, "Escolha a forma de pagamento da Mensalidade");
                txt32.Focus();
                return;
            }
            else
            {
                errErro.SetError(txt32, "");
            }

            //Seta os campos para o BD
            clsCliente clsCliente = new clsCliente();
            clsCliente.vippai_id = int.Parse(txt01.Text);
            clsCliente.nome = txt04.Text;
            clsCliente.status = txt05.Text;
            clsCliente.datacadastro = txt06.Text;
            clsCliente.cpf = txt07.Text;
            clsCliente.rg = txt08.Text;
            clsCliente.contrato = txt09.Text;
            clsCliente.datanascimento = txt10.Text;
            clsCliente.estadocivil = txt11.Text;
            clsCliente.nacionaldidade = txt12.Text;
            clsCliente.sexo = txt13.Text;
            clsCliente.natural_id = txt14.Text;
            clsCliente.mae = txt16.Text;
            clsCliente.pai = txt17.Text;
            clsCliente.profissao = txt18.Text;
            clsCliente.email = txt19.Text;
            clsCliente.telefones = txt20.Text;
            clsCliente.obs = txt21.Text;
            clsCliente.enderecos_id = int.Parse(txt22.Text);
            clsCliente.numero = txt24.Text;
            clsCliente.banco_id = int.Parse(txt28.Text);
            clsCliente.ag = txt30.Text;
            clsCliente.cc = txt31.Text;
            clsCliente.formadepagamento = txt32.Text;

            string id = "";

            if (Operacao == Ope.Inclusao)
            {

                id = clsCliente.Gravar();
                //Gera a movimentação financeira
                clsMovimentacao clsMov = new clsMovimentacao();
                string strData = txt06.Text;
                DateTime dt = DateTime.ParseExact(strData, "dd/MM/yyyy", null);
                switch (txt32.Text)
                {
                    case "MENSAL": clsMov.Gerar12Mensalidade(id, dt);
                        break;
                    case "ANUAL 2X": clsMov.GerarMensalidadeAnual2x(id, dt);
                        break;
                    case "ANUAL": clsMov.GerarMensalidadeAnual(id, dt);
                        break;
                }
            }
            else
                if (Operacao == Ope.Alteracao)
                {
                    clsCliente.cliente_id = Codigo;
                    clsCliente.Alterar();
                    id = Codigo.ToString();
                }
            this.Close();
        }

        /// <summary>
        /// No evento Load é verificado atraves do 
        /// objeto Ope, se o form deve ser aberto como Inclusão ou Alteração
        /// </summary>
        private void frmClienteCadastro_Load(object sender, EventArgs e)
        {
            if (Operacao == Ope.Alteracao)
            {
                clsCliente clsCliente = new clsCliente();
                DataSet oDs = new DataSet();
                oDs = clsCliente.ListarCliente(Codigo);
                DataRow oDR = oDs.Tables[0].Rows[0];
                txt01.Text = oDR["vippai_id"].ToString();
                txt04.Text = oDR["nome"].ToString();
                txt05.Text = oDR["status"].ToString();
                txt06.Text = oDR["datacadastro"].ToString();
                txt07.Text = oDR["cpf"].ToString();
                txt08.Text = oDR["rg"].ToString();
                txt09.Text = oDR["contrato"].ToString();
                txt10.Text = oDR["datanascimento"].ToString();
                txt11.Text = oDR["estadocivil"].ToString();
                txt12.Text = oDR["nacionalidade"].ToString();
                txt13.Text = oDR["sexo"].ToString();
                txt14.Text = oDR["natural_id"].ToString();
                txt16.Text = oDR["mae"].ToString();
                txt17.Text = oDR["pai"].ToString();
                txt18.Text = oDR["profissao"].ToString();
                txt19.Text = oDR["email"].ToString();
                txt20.Text = oDR["telefones"].ToString();
                txt21.Text = oDR["obs"].ToString();
                txt22.Text = oDR["enderecos_id"].ToString();
                txt24.Text = oDR["numero"].ToString();
                txt28.Text = oDR["banco_id"].ToString();
                txt30.Text = oDR["ag"].ToString();
                txt31.Text = oDR["cc"].ToString();
                txt32.Text = oDR["formadepagamento"].ToString();
            }
            else
            {
                txt12.Text = "BRASILEIRA";
                txt28.Text = "0";
                txt30.Text = "0000-0";
                txt31.Text = "0000-0";
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Verifica a cada mudança no campo txt, se o valor informado 
        /// é um código de pesquisa aceito, se for, ele pesquisa no banco de dados
        /// e mostra o valor do nome no txt
        /// </summary>
        private void txt14_TextChanged(object sender, EventArgs e)
        {
            string cod = "0";
            if (!txt14.Text.Equals(string.Empty))
            {

                cod = txt14.Text;

                clsMunicipio clsMunicipio = new clsMunicipio();
                DataSet oDs = new DataSet();
                oDs = clsMunicipio.ListarMunicipio(cod);
                if (oDs.Tables[0].Rows.Count != 0)
                {
                    DataRow oDR = oDs.Tables[0].Rows[0];
                    txt15.Text = oDR["nome"].ToString() + " - " + oDR["uf"].ToString();
                }
                else
                {
                    txt15.Text = "";
                }
            }
            else
            {
                txt15.Text = "";
            }
        }

        /// <summary>
        /// Verifica a cada mudança no campo txt, se o valor informado 
        /// é um código de pesquisa aceito, se for, ele pesquisa no banco de dados
        /// e mostra o valor do nome no txt
        /// </summary>
        private void txt22_TextChanged(object sender, EventArgs e)
        {
            int cod = 0;
            if (!txt22.Text.Equals(string.Empty))
            {

                cod = int.Parse(txt22.Text);

                clsEndereco clsEndereco = new clsEndereco();
                DataSet oDs = new DataSet();
                oDs = clsEndereco.ListarEndereco(cod);
                if (oDs.Tables[0].Rows.Count != 0)
                {
                    DataRow oDR = oDs.Tables[0].Rows[0];
                    txt23.Text = oDR["logradouro"].ToString();
                    txt25.Text = oDR["cep"].ToString();
                    txt26.Text = oDR["bairro"].ToString();
                    txt27.Text = oDR["municipio"].ToString() + " - " + oDR["uf"].ToString();
                }
                else
                {
                    txt23.Text = "";
                    txt25.Text = "";
                    txt26.Text = "";
                    txt27.Text = "";
                }
            }
            else
            {
                txt23.Text = "";
                txt25.Text = "";
                txt26.Text = "";
                txt27.Text = "";
            }
        }
        /// <summary>
        /// Exibe o formulario de pesquisa
        /// </summary>
        private void btnCodEndereco_Click(object sender, EventArgs e)
        {
            frmEnderecoConsulta frm = new frmEnderecoConsulta("form");
            frm.ShowDialog();
            txt22.Text = frm.codSelecionado.ToString();
        }
        /// <summary>
        /// Exibe o formulario de pesquisa
        /// </summary>
        private void btnCodCidade_Click(object sender, EventArgs e)
        {
            frmMunicipioConsulta frm = new frmMunicipioConsulta("form");
            frm.ShowDialog();
            txt14.Text = frm.codSelecionado.ToString();
        }

        private void txt28_TextChanged(object sender, EventArgs e)
        {
            int cod = 0;
            if (!txt28.Text.Equals(string.Empty))
            {

                cod = int.Parse(txt28.Text);

                clsBanco clsBanco = new clsBanco();
                DataSet oDs = new DataSet();
                oDs = clsBanco.ListarBanco(cod);
                if (oDs.Tables[0].Rows.Count != 0)
                {
                    DataRow oDR = oDs.Tables[0].Rows[0];
                    txt29.Text = oDR["banco"].ToString();
                }
                else
                {
                    txt29.Text = "";
                }
            }
            else
            {
                txt29.Text = "";
            }
        }

        private void btnCodBanco_Click(object sender, EventArgs e)
        {
            frmBancoConsulta frm = new frmBancoConsulta("form");
            frm.ShowDialog();
            txt28.Text = frm.codSelecionado.ToString();
        }

        private void btnVipPai_Click(object sender, EventArgs e)
        {
            frmVipPaiConsulta frm = new frmVipPaiConsulta("form");
            frm.ShowDialog();
            txt01.Text = frm.codSelecionado.ToString();
        }

        private void txt01_TextChanged(object sender, EventArgs e)
        {
            int cod = 0;
            if (!txt01.Text.Equals(string.Empty))
            {

                cod = int.Parse(txt01.Text);

                clsVipPai clsVipPai = new clsVipPai();
                DataSet oDs = new DataSet();
                oDs = clsVipPai.ListarVipPai(cod);
                if (oDs.Tables[0].Rows.Count != 0)
                {
                    DataRow oDR = oDs.Tables[0].Rows[0];
                    txt02.Text = oDR["nome"].ToString();
                    txt03.Text = oDR["painome"].ToString();
                }
                else
                {
                    txt02.Text = "";
                    txt03.Text = "";
                }
            }
            else
            {
                txt02.Text = "";
                txt03.Text = "";
            }
        }
    }
}
