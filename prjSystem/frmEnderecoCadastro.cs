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
    /// <summary>
    /// Formulário de Cadastro de Endereços
    /// </summary>
    public partial class frmEnderecoCadastro : Form
    {
        public frmEnderecoCadastro()
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
            if (txtLogradouro.Text.Equals(string.Empty))
            {
                errErro.SetError(txtLogradouro, "Digite o Logradouro do Endereço");
                return;
            }
            else
            {
                errErro.SetError(txtLogradouro, "");
            }

            if (txtCEP.Text.Length != 9)
            {
                errErro.SetError(txtCEP, "O CEP deve ter 8 Digitos");
                return;
            }
            else
            {
                errErro.SetError(txtCEP, "");
            }

            if (txtCodBairro.Text.Equals(string.Empty))
            {
                errErro.SetError(txtCodBairro, "Digite o Código do Bairro");
                return;
            }
            else
            {
                errErro.SetError(txtCodBairro, "");
            }

            //verifica se o bairro existe
            if (txtBairro.Text.Equals(string.Empty))
            {
                errErro.SetError(txtBairro, "Bairro inexistente");
                return;
            }
            else
            {
                errErro.SetError(txtCodBairro, "");
            }
            //verifica se a cidade existe
            if (txtCidade.Text.Equals(string.Empty))
            {
                errErro.SetError(txtCidade, "Cidade inexistente");
                return;
            }
            else
            {
                errErro.SetError(txtCodCidade, "");
            }
            clsEndereco clsEndereco = new clsEndereco();
            clsEndereco.logradouro = txtLogradouro.Text;
            clsEndereco.cep = txtCEP.Text;
            clsEndereco.bairros_id = int.Parse(txtCodBairro.Text);
            clsEndereco.municipio_id = txtCodCidade.Text;

            if (Operacao == Ope.Inclusao)
            {
                clsEndereco.Gravar();
            }
            else
                if (Operacao == Ope.Alteracao)
                {
                    clsEndereco.enderecos_id = Codigo;
                    clsEndereco.Alterar();
                }
            this.Close();
        }

        /// <summary>
        /// No evento Load é verificado atraves do 
        /// objeto Ope, se o form deve ser aberto como Inclusão ou Alteração
        /// </summary>
        private void frmEnderecoCadastro_Load(object sender, EventArgs e)
        {
            if (Operacao == Ope.Alteracao)
            {
                clsEndereco clsEndereco = new clsEndereco();
                DataSet oDs = new DataSet();
                oDs = clsEndereco.ListarEndereco(Codigo);
                DataRow oDR = oDs.Tables[0].Rows[0];
                txtLogradouro.Text = oDR["logradouro"].ToString();
                txtCEP.Text = oDR["cep"].ToString();
                txtCodBairro.Text = oDR["bairros_id"].ToString();
                txtBairro.Text = oDR["bairro"].ToString();
                txtCodCidade.Text = oDR["municipio_id"].ToString();
                txtCidade.Text = oDR["municipio"].ToString() + " - " + oDR["uf"].ToString();
                
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Verifica a cada mudança no campo txtCodBairro, se o valor informado 
        /// é um código de bairro aceito, se for, ele pesquisa no banco de dados
        /// e mostra o valor do nome do bairro no txtBairro
        /// </summary>
        private void txtCodBairro_TextChanged(object sender, EventArgs e)
        {
            int cod = 0;
            if (!txtCodBairro.Text.Equals(string.Empty))
            {

                cod = int.Parse(txtCodBairro.Text);

                clsBairro clsBairro = new clsBairro();
                DataSet oDs = new DataSet();
                oDs = clsBairro.ListarBairro(cod);
                if (oDs.Tables[0].Rows.Count != 0)
                {
                    DataRow oDR = oDs.Tables[0].Rows[0];
                    txtBairro.Text = oDR["nome"].ToString();
                }
                else
                {
                    txtBairro.Text = "";
                }
            }
            else
            {
                txtBairro.Text = "";
            }
        }

        /// <summary>
        /// Limita os caracteres aceitos pelo campo txtCodBairro, para, 
        /// backspace e números
        /// </summary>
        private void txtCodBairro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Exibe o formulário de pesquisa de Pesquisa de Bairro
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            /*string codRetorno = "";
            frmEnderecoPesqBairro frmEnderecoPesqBairro = new frmEnderecoPesqBairro();
            codRetorno = frmEnderecoPesqBairro.RetornaCodigo(frmEnderecoPesqBairro).ToString();
            if (codRetorno != "")
            {
                txtCodBairro.Text = codRetorno;
            }**/
            frmBairroConsulta frm = new frmBairroConsulta("form");
            frm.ShowDialog();
            txtCodBairro.Text = frm.codSelecionado.ToString();
        }

        /// <summary>
        /// Verifica a cada mudança no campo txtCodCidade, se o valor informado 
        /// é um código de cidade aceito, se for, ele pesquisa no banco de dados
        /// e mostra o valor do nome da cidade no txtCidade
        /// </summary>
        private void txtCodCidade_TextChanged(object sender, EventArgs e)
        {
            string cod = "0";
            if (!txtCodCidade.Text.Equals(string.Empty))
            {

                cod = txtCodCidade.Text;

                clsMunicipio clsMunicipio = new clsMunicipio();
                DataSet oDs = new DataSet();
                oDs = clsMunicipio.ListarMunicipio(cod);
                if (oDs.Tables[0].Rows.Count != 0)
                {
                    DataRow oDR = oDs.Tables[0].Rows[0];
                    txtCidade.Text = oDR["nome"].ToString()+" - "+ oDR["uf"].ToString();
                }
                else
                {
                    txtCidade.Text = "";
                }
            }
            else
            {
                txtCidade.Text = "";
            }
        }

        /// <summary>
        /// Exibe o formulário de pesquisa de Cidade
        /// </summary>
        private void button2_Click(object sender, EventArgs e)
        {
            frmMunicipioConsulta frm = new frmMunicipioConsulta("form");
            frm.ShowDialog();
            txtCodCidade.Text = frm.codSelecionado.ToString();
        }
    }
}