using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace prjSystem
{
    public partial class frmEnderecoConsulta : Form
    {
        string ch = "";
        /// <summary>
        /// Passa para o contrutor quem chamou
        /// se ele abriu sozinho para edição normal
        /// ou se esta sendo usado para pesquisar algum
        /// dado para outro formulario
        /// </summary>
        /// <param name="chamou">Informe "" (vazio) para nenhuma chadama ou "form" para formulario de pesquisa</param>
        public frmEnderecoConsulta(string chamou)
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
            clsEndereco clsEndereco = new clsEndereco();
            switch (lbPesq.Text)
            {
                case "CEP": strCampo = "enderecos.cep";
                    break;
                case "Cidade": strCampo = "municipio.nome";
                    break;
                case "Logradouro": strCampo = "enderecos.logradouro";
                    break;
                case "Nome do Bairro": strCampo = "bairros.nome";
                    break;
                case "UF": strCampo = "municipio.uf";
                    break;
                case "Código": strCampo = "enderecos.enderecos_id";
                    break;
                default: strCampo = "enderecos.logradouro";
                    break;
            }
            if (rbQualquer.Checked)
                strTipo = "qualquer";
            if (rbComecar.Checked)
                strTipo = "comecar";
            if (rbExato.Checked)
                strTipo = "exato";
            dgdGrid.DataSource = clsEndereco.ListarComParametro(strCampo, txtDescricao.Text, strTipo).Tables[0];
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void frmEnderecoConsulta_Load(object sender, EventArgs e)
        {
            CarregarGrid();
            lbPesq.Text = lbPesq.Items[3].ToString();
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
                clsEndereco clsEndereco = new clsEndereco();
                clsEndereco.Excluir((int)(dgdGrid.CurrentRow.Cells[0].Value));
                CarregarGrid();
            }
            catch
            {
                return;
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            frmEnderecoCadastro frmEnderecoCadastro = new frmEnderecoCadastro();
            frmEnderecoCadastro.Operacao = frmEnderecoCadastro.Ope.Alteracao;
            try
            {
                frmEnderecoCadastro.Codigo = (int)dgdGrid.CurrentRow.Cells[0].Value;
            }
            catch
            {
                return;
            }
            frmEnderecoCadastro.ShowDialog();
            CarregarGrid();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            frmEnderecoCadastro frmEnderecoCadastro = new frmEnderecoCadastro();
            frmEnderecoCadastro.Operacao = frmEnderecoCadastro.Ope.Inclusao;
            frmEnderecoCadastro.ShowDialog();
            CarregarGrid();
        }

        private void dgdGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //se ninguem chamou o form
            if (ch == "")
            {
                frmEnderecoCadastro frmEnderecoCadastro = new frmEnderecoCadastro();
                frmEnderecoCadastro.Operacao = frmEnderecoCadastro.Ope.Alteracao;
                frmEnderecoCadastro.Codigo = (int)dgdGrid.CurrentRow.Cells[0].Value;
                frmEnderecoCadastro.ShowDialog();
                CarregarGrid();
            }
            //se esta sendo usado por outro form
            else
            {
                _codSelecionado = (int)(dgdGrid.CurrentRow.Cells[0].Value);
                this.Close();
            }
        }
    }
}