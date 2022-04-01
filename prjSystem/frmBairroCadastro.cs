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
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace prjSystem
{
    /// <summary>
    /// Formulário de Cadastro de Bairros
    /// </summary>
    public partial class frmBairroCadastro : Form
    {
        public frmBairroCadastro()
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
                errErro.SetError(txtNome, "Digite um nome para o Bairro");
                return;
            }
            else
            {
                errErro.SetError(txtNome, "");
            }
            
            clsBairro clsBairro = new clsBairro();
            clsBairro.nome = txtNome.Text;
            

            if (Operacao == Ope.Inclusao)
            {
                clsBairro.Gravar();
            }
            else
                if (Operacao == Ope.Alteracao)
                {
                    clsBairro.bairros_id = Codigo;
                    clsBairro.Alterar();
                }
            this.Close();
        }

        /// <summary>
        /// No evento Load é verificado atraves do 
        /// objeto Ope, se o form deve ser aberto como Inclusão ou Alteração
        /// </summary>
        private void frmBairroCadastro_Load(object sender, EventArgs e)
        {
            if (Operacao == Ope.Alteracao)
            {
                clsBairro clsBairro = new clsBairro();
                DataSet oDs = new DataSet();
                oDs = clsBairro.ListarBairro(Codigo);
                DataRow oDR = oDs.Tables[0].Rows[0];
                txtNome.Text = oDR["nome"].ToString();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}