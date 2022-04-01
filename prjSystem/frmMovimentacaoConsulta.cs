using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;

namespace prjSystem
{
    public partial class frmMovimentacaoConsulta : Form
    {
        public frmMovimentacaoConsulta()
        {
            InitializeComponent();
        }
        private int _codSelecionado;
        public int codSelecionado
        {
            get
            {
                return _codSelecionado;
            }
            set
            {
                _codSelecionado = value;
            }
        }
        private void CarregarGrid()
        {
            string strCampo = "";
            string strTipo = "";
            clsCliente clsProprietario = new clsCliente();
            switch (lbPesq.Text)
            {
                case "Cidade": strCampo = "municipio.nome";
                    break;
                case "Logradouro": strCampo = "enderecos.logradouro";
                    break;
                case "Mãe": strCampo = "cliente.mae";
                    break;
                case "Nome": strCampo = "cliente.nome";
                    break;
                case "RG": strCampo = "cliente.rg";
                    break;
                case "CPF": strCampo = "cliente.cpf";
                    break;
                case "Código": strCampo = "cliente.cliente_id";
                    break;
                default: strCampo = "cliente.nome";
                    break;
            }
            if (rbQualquer.Checked)
                strTipo = "qualquer";
            if (rbComecar.Checked)
                strTipo = "comecar";
            if (rbExato.Checked)
                strTipo = "exato";
            dgdGrid.DataSource = clsProprietario.ListarComParametro(strCampo, txtDescricao.Text, strTipo).Tables[0];
        }
        private void CarregarGridMov()
        {
            clsMovimentacao clsMovi = new clsMovimentacao();
            int id = 0;
            try
            {
                id = (int)dgdGrid.CurrentRow.Cells[0].Value;
            }
            catch
            {
                id = 0;
            }
            dgdGridMov.DataSource = clsMovi.ListarMovimentacaoCliente(id).Tables[0];
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            CarregarGrid();
            CarregarGridMov();
        }

        private void frmMovimentacaoConsulta_Load(object sender, EventArgs e)
        {
            CarregarGrid();
            CarregarGridMov();
            lbPesq.Text = lbPesq.Items[4].ToString();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Deseja excluir o registro?", this.Text,
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
                clsMovimentacao clsMovi = new clsMovimentacao();
                clsMovi.Excluir((int)(dgdGridMov.CurrentRow.Cells[0].Value));
                CarregarGridMov();
            }
            catch
            {
                return;
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            frmMovimentacao frmMovimentacao = new frmMovimentacao();
            frmMovimentacao.Operacao = frmMovimentacao.Ope.Alteracao;
            try
            {
                frmMovimentacao.Codigo = (int)dgdGridMov.CurrentRow.Cells[0].Value;
            }
            catch
            {
                return;
            }
            frmMovimentacao.ShowDialog();
            CarregarGridMov();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            frmMovimentacao frmMovimentacao = new frmMovimentacao();
            frmMovimentacao.Operacao = frmMovimentacao.Ope.Inclusao;
            try
            {
                frmMovimentacao.Codigo = (int)dgdGrid.CurrentRow.Cells[0].Value;
            }
            catch
            {
                return;
            }
            frmMovimentacao.ShowDialog();
            CarregarGridMov();
        }

        private void dgdGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CarregarGridMov();
        }

        private void dgdGridMov_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmMovimentacao frmMovimentacao = new frmMovimentacao();
            frmMovimentacao.Operacao = frmMovimentacao.Ope.Alteracao;
            frmMovimentacao.Codigo = (int)dgdGridMov.CurrentRow.Cells[0].Value;
            frmMovimentacao.ShowDialog();
            CarregarGridMov();
        }

        private void btnRecibo_Click(object sender, EventArgs e)
        {
            
            
            
            rel_form frm = new rel_form();
            string codigo = "";
            try
            {
                codigo = dgdGridMov.CurrentRow.Cells[0].Value.ToString();
            }
            catch
            {
                return;
            }
            
            rel_RPT_recibo rel = new rel_RPT_recibo();
            clsBancoDados clsBancoDados = new clsBancoDados();
            FbConnection conn = clsBancoDados.retornaConn();
            DataSet ds = new DataSet();
            FbDataAdapter da = new FbDataAdapter("SELECT * FROM VWRECIBO WHERE MOVIMENTACAO_ID = " + codigo, conn);
            da.Fill(ds, "VWRECIBO");
            frm.report = rel;
            frm.ds = ds;
            frm.ShowDialog();
        }
    }
}
