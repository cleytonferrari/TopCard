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
    /// Formulário de Cadastro de usuários
    /// </summary>
    public partial class frmUsuarioCadastro : Form
    {
        public frmUsuarioCadastro()
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
            if (txtNome.Text.Equals(string.Empty))
            {
                errErro.SetError(txtNome, "Digite um nome para o Usuário");
                return;
            }
            else
            {
                errErro.SetError(txtNome, "");
            }
            if (txtLogin.Text.Equals(string.Empty))
            {
                errErro.SetError(txtLogin, "Digite o Loggin do Usuário");
                return;
            }
            else
            {
                errErro.SetError(txtLogin, "");
            }
            if (txtSenha.Text.Equals(string.Empty))
            {
                errErro.SetError(txtSenha, "Digite uma Senha");
                return;
            }
            else
            {
                errErro.SetError(txtSenha, "");
            }
            if (txtConfSenha.Text.Equals(string.Empty))
            {
                errErro.SetError(txtConfSenha, "Digite uma Senha");
                return;
            }
            else
            {
                errErro.SetError(txtConfSenha, "");
            }
            if (txtSenha.Text != txtConfSenha.Text)
            {
                errErro.SetError(txtConfSenha, "A senha não confere!");
                return;
            }
            else
            {
                errErro.SetError(txtConfSenha, "");
            }
            clsUsuario clsUsuario = new clsUsuario();
            clsUsuario.nome = txtNome.Text;
            clsUsuario.login = txtLogin.Text;
            clsUsuario.senha = txtSenha.Text;


            if (Operacao == Ope.Inclusao)
            {
                clsUsuario.Gravar();
            }
            else
                if (Operacao == Ope.Alteracao)
                {
                    clsUsuario.usuario_id = Codigo;
                    clsUsuario.Alterar();
                }
            this.Close();
        }

        /// <summary>
        /// No evento Load é verificado atraves do 
        /// objeto Ope, se o form deve ser aberto como Inclusão ou Alteração
        /// </summary>
        private void frmUsuarioCadastro_Load(object sender, EventArgs e)
        {
            if (Operacao == Ope.Alteracao)
            {
                clsUsuario clsUsuario = new clsUsuario();
                DataSet oDs = new DataSet();
                oDs = clsUsuario.ListarUsuario(Codigo);
                DataRow oDR = oDs.Tables[0].Rows[0];
                txtNome.Text = oDR["nome"].ToString();
                txtLogin.Text = oDR["login"].ToString();
                txtSenha.Text = oDR["senha"].ToString();
                txtConfSenha.Text = oDR["senha"].ToString();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}