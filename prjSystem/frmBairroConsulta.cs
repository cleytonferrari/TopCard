using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace prjSystem
{
    public partial class frmBairroConsulta : Form
    {
        string ch = "";

        /// <summary>
        /// Passa para o contrutor quem chamou
        /// se ele abriu sozinho para edição normal
        /// ou se esta sendo usado para pesquisar algum
        /// dado para outro formulario
        /// </summary>
        /// <param name="chamou">Iforme "" (vazio) para nenhuma chadama ou "form" para formulario de pesquisa</param>
        public frmBairroConsulta(string chamou)
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
            clsBairro clsBairro = new clsBairro();
            switch (lbPesq.Text)
            {
                case "Nome do Bairro": strCampo = "nome";
                    break;
                case "Código": strCampo = "bairros_id";
                    break;
                default: strCampo = "nome";
                    break;
            }
            if (rbQualquer.Checked)
                strTipo = "qualquer";
            if (rbComecar.Checked)
                strTipo = "comecar";
            if (rbExato.Checked)
                strTipo = "exato";
            dgdGrid.DataSource = clsBairro.ListarComParametro(strCampo, txtDescricao.Text, strTipo).Tables[0];
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            frmBairroCadastro frmBairroCadastro = new frmBairroCadastro();
            frmBairroCadastro.Operacao = frmBairroCadastro.Ope.Inclusao;
            frmBairroCadastro.ShowDialog();
            CarregarGrid();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            frmBairroCadastro frmBairroCadastro = new frmBairroCadastro();
            frmBairroCadastro.Operacao = frmBairroCadastro.Ope.Alteracao;
            try
            {
                frmBairroCadastro.Codigo = (int)dgdGrid.CurrentRow.Cells[0].Value;
            }
            catch
            {
                return;
            }
            frmBairroCadastro.ShowDialog();
            CarregarGrid();
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
                clsBairro clsBairro = new clsBairro();
                clsBairro.Excluir((int)(dgdGrid.CurrentRow.Cells[0].Value));
                CarregarGrid();
            }
            catch
            {
                return;
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

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void frmBairroConsulta_Load(object sender, EventArgs e)
        {
            CarregarGrid();
            lbPesq.Text = lbPesq.Items[1].ToString();
            if (ch != "")
            {
                btnSair.Text = "      Selecionar";
            }
        }

        private void dgdGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //se ninguem chamou o form
            if (ch == "")
            {
                frmBairroCadastro frmBairroCadastro = new frmBairroCadastro();
                frmBairroCadastro.Operacao = frmBairroCadastro.Ope.Alteracao;
                frmBairroCadastro.Codigo = (int)dgdGrid.CurrentRow.Cells[0].Value;
                frmBairroCadastro.ShowDialog();
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