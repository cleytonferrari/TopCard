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
    public partial class frmMovimentacao : Form
    {
        public frmMovimentacao()
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

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (txt06.Text.Equals(string.Empty))
            {
                errErro.SetError(txt06, "Escolha a Movimentação da Referencia");
                return;
            }
            else
            {
                errErro.SetError(txt06, "");
            }

            if (txt09.Text.Equals(string.Empty))
            {
                errErro.SetError(txt09, "Escolha o Status da Movimentação");
                return;
            }
            else
            {
                errErro.SetError(txt09, "");
            }

            if (txt20.Text.Equals(string.Empty))
            {
                errErro.SetError(txt20, "Escolha o Status da Comissão");
                return;
            }
            else
            {
                errErro.SetError(txt20, "");
            }


            clsMovimentacao clsMov = new clsMovimentacao();
            clsMov.cliente_id = int.Parse(txt01.Text);
            clsMov.valor = txt04.Text.Replace(",",".");
            clsMov.valorpago = txt05.Text.Replace(",", ".");
            clsMov.referencia = txt06.Text;
            clsMov.datavencimento = DateTime.Parse(txt07.Text).ToString("MM/dd/yyy");

            if (txt08.Checked)
                clsMov.datapagamento = DateTime.Parse(txt08.Text).ToString("MM/dd/yyy");
            else
                clsMov.datapagamento = "";            

            clsMov.status = txt09.Text;
            clsMov.comissaopai = txt13.Text.Replace(",", ".");

            if (txt14.Checked)
                clsMov.datapagamentopai = DateTime.Parse(txt14.Text).ToString("MM/dd/yyy");
            else
                clsMov.datapagamentopai = "";

            clsMov.comissaoavo = txt18.Text.Replace(",", ".");

            if (txt19.Checked)
                clsMov.datapagamentoavo = DateTime.Parse(txt19.Text).ToString("MM/dd/yyy");
            else
                clsMov.datapagamentoavo = "";

            clsMov.pagoa = txt20.Text;
            clsMov.saldo = (decimal.Parse(txt04.Text) - decimal.Parse(txt13.Text) - decimal.Parse(txt18.Text)).ToString();
            clsMov.saldo = clsMov.saldo.ToString().Replace(",", ".");

            if (Operacao == Ope.Inclusao)
            {
                clsMov.Gravar();
            }
            else
                if (Operacao == Ope.Alteracao)
                {
                    clsMov.movimentacao_id = Codigo;
                    clsMov.Alterar();
                }
            this.Close();
        }

        private void frmMovimentacao_Load(object sender, EventArgs e)
        {
            if (Operacao == Ope.Alteracao)
            {
                clsMovimentacao clsMovi = new clsMovimentacao();
                DataSet oDs = new DataSet();
                oDs = clsMovi.ListarMovimentacao(Codigo);
                DataRow oDR = oDs.Tables[0].Rows[0];
                txt01.Text = oDR["cliente_id"].ToString();
                txt02.Text = oDR["nome"].ToString();
                txt03.Text = oDR["cpf"].ToString();
                txt04.Text = string.Format("{0:0.00}", decimal.Parse(oDR["valor"].ToString()));
                txt05.Text = string.Format("{0:0.00}", decimal.Parse(oDR["valorpago"].ToString()));
                txt06.Text = oDR["referencia"].ToString();
                txt07.Text = oDR["datavencimento"].ToString();
                txt08.Text = oDR["datapagamento"].ToString();
                txt09.Text = oDR["status"].ToString();
                txt10.Text = oDR["vippai_id"].ToString();
                txt11.Text = oDR["vippai"].ToString();
                txt12.Text = oDR["vippaicpf"].ToString();
                txt13.Text = string.Format("{0:0.00}", decimal.Parse(oDR["comissaopai"].ToString()));
                txt14.Text = oDR["datapagamentopai"].ToString();
                txt15.Text = oDR["vipavo_id"].ToString();
                txt16.Text = oDR["vipavonome"].ToString();
                txt17.Text = oDR["vipavocpf"].ToString();
                txt18.Text = string.Format("{0:0.00}", decimal.Parse(oDR["comissaoavo"].ToString()));
                txt19.Text = oDR["datapagamentoavo"].ToString();
                txt20.Text = oDR["pagoa"].ToString();
            }
            else //novo
            {
                clsCliente clsCliente = new clsCliente();
                DataSet oDs = new DataSet();
                oDs = clsCliente.ListarCliente(Codigo);
                DataRow oDR = oDs.Tables[0].Rows[0];
                txt01.Text = oDR["cliente_id"].ToString();
                txt02.Text = oDR["nome"].ToString();
                txt03.Text = oDR["cpf"].ToString();
                txt04.Text = "0,00";
                txt05.Text = "0,00";
                txt10.Text = oDR["vippai_id"].ToString();
                txt11.Text = oDR["vippai"].ToString();
                txt12.Text = oDR["vippaicpf"].ToString();
                txt13.Text = "0,00";
                txt15.Text = oDR["vipavo_id"].ToString();
                txt16.Text = oDR["vipavo"].ToString();
                txt17.Text = oDR["vipavocpf"].ToString();
                txt18.Text = "0,00";
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt04_Leave(object sender, EventArgs e)
        {
            try
            {
                txt04.Text = String.Format("{0:N}", Convert.ToDecimal(txt04.Text));
            }
            catch
            {
                txt04.Text = "0,00";
            }
        }

        private void txt05_Leave(object sender, EventArgs e)
        {
            try
            {
                txt05.Text = String.Format("{0:N}", Convert.ToDecimal(txt05.Text));
            }
            catch
            {
                txt05.Text = "0,00";
            }
        }

        private void txt13_Leave(object sender, EventArgs e)
        {
            try
            {
                txt13.Text = String.Format("{0:N}", Convert.ToDecimal(txt13.Text));
            }
            catch
            {
                txt13.Text = "0,00";
            }
        }

        private void txt18_Leave(object sender, EventArgs e)
        {
            try
            {
                txt18.Text = String.Format("{0:N}", Convert.ToDecimal(txt18.Text));
            }
            catch
            {
                txt18.Text = "0,00";
            }
        }

        private void txt04_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8) && (e.KeyChar != ',') && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txt05_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8) && (e.KeyChar != ',') && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txt13_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8) && (e.KeyChar != ',') && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txt18_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8) && (e.KeyChar != ',') && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
