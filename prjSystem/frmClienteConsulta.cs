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
    public partial class frmMovimentacaoClienteConsulta : Form
    {
        string ch = "";
        /// <summary>
        /// Passa para o contrutor quem chamou
        /// se ele abriu sozinho para edição normal
        /// ou se esta sendo usado para pesquisar algum
        /// dado para outro formulario
        /// </summary>
        /// <param name="chamou">Informe "" (vazio) para nenhuma chadama ou "form" para formulario de pesquisa</param>
        public frmMovimentacaoClienteConsulta(string chamou)
        {
            ch = chamou;
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

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void frmClienteConsulta_Load(object sender, EventArgs e)
        {
            CarregarGrid();
            lbPesq.Text = lbPesq.Items[4].ToString();
            if (ch != "")
            {
                btnSair.Text = "      Selecionar";
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (ch != "")
            {
                _codSelecionado = (int)(dgdGrid.CurrentRow.Cells[0].Value);
            }
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
                clsCliente clsCliente = new clsCliente();
                clsCliente.Excluir((int)(dgdGrid.CurrentRow.Cells[0].Value));
                CarregarGrid();
            }
            catch
            {
                return;
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            frmClienteCadastro frmClienteCadastro = new frmClienteCadastro();
            frmClienteCadastro.Operacao = frmClienteCadastro.Ope.Alteracao;
            try
            {
                frmClienteCadastro.Codigo = (int)dgdGrid.CurrentRow.Cells[0].Value;
            }
            catch
            {
                return;
            }
            frmClienteCadastro.ShowDialog();
            CarregarGrid();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            frmClienteCadastro frmClienteCadastro = new frmClienteCadastro();
            frmClienteCadastro.Operacao = frmClienteCadastro.Ope.Inclusao;
            frmClienteCadastro.ShowDialog();
            CarregarGrid();
        }

        private void dgdGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //se ninguem chamou o form
            if (ch == "")
            {
                frmClienteCadastro frmClienteCadastro = new frmClienteCadastro();
                frmClienteCadastro.Operacao = frmClienteCadastro.Ope.Alteracao;
                frmClienteCadastro.Codigo = (int)dgdGrid.CurrentRow.Cells[0].Value;
                frmClienteCadastro.ShowDialog();
                CarregarGrid();
            }
            //se esta sendo usado por outro form
            else
            {
                _codSelecionado = (int)(dgdGrid.CurrentRow.Cells[0].Value);
                this.Close();
            }
        }

        private void btnRecibo_Click(object sender, EventArgs e)
        {
            string codigo = "";
            try
            {
                codigo = dgdGrid.CurrentRow.Cells[0].Value.ToString();
            }
            catch
            {
                return;
            }

            rel_form frm = new rel_form();
            rel_RPT_hierarquica rel = new rel_RPT_hierarquica();
            clsBancoDados clsBancoDados = new clsBancoDados();
            FbConnection conn = clsBancoDados.retornaConn();

            rel_DS_movimentacao ds = new rel_DS_movimentacao();

            FbDataAdapter mp = new FbDataAdapter("SELECT * FROM MOVPAI WHERE PAI_ID = "+codigo, conn);
            FbDataAdapter mf = new FbDataAdapter("SELECT * FROM MOVFILHO", conn);
            FbDataAdapter mn = new FbDataAdapter("SELECT * FROM MOVNETO", conn);

            mp.Fill(ds, "MOVPAI");
            mf.Fill(ds, "MOVFILHO");
            mn.Fill(ds, "MOVNETO");

            frm.report = rel;
            frm.ds = ds;
            frm.ShowDialog();
        }

        private void dgdGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
