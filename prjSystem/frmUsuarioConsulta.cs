using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace prjSystem
{
    public partial class frmUsuarioConsulta : Form
    {
        public frmUsuarioConsulta()
        {
            InitializeComponent();
        }
        private void CarregarGrid()
        {
            string strCampo = "";
            string strTipo = "";
            clsUsuario clsUsuario = new clsUsuario();
            switch (lbPesq.Text)
            {
                case "Nome": strCampo = "nome";
                    break;
                case "Login": strCampo = "login";
                    break;
                case "Código": strCampo = "usuario_id";
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
            dgdGrid.DataSource = clsUsuario.ListarComParametro(strCampo, txtDescricao.Text, strTipo).Tables[0];
        }

        private void frmUsuarioConsulta_Load(object sender, EventArgs e)
        {
            CarregarGrid();
            lbPesq.Text = lbPesq.Items[2].ToString();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            CarregarGrid();
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
                clsUsuario clsUsuario = new clsUsuario();
                clsUsuario.Excluir((int)(dgdGrid.CurrentRow.Cells[0].Value));
                CarregarGrid();
            }
            catch
            {
                return;
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            frmUsuarioCadastro frmUsuarioCadastro = new frmUsuarioCadastro();
            frmUsuarioCadastro.Operacao = frmUsuarioCadastro.Ope.Alteracao;
            try
            {
                frmUsuarioCadastro.Codigo = (int)dgdGrid.CurrentRow.Cells[0].Value;
            }
            catch
            {
                return;
            }
            frmUsuarioCadastro.ShowDialog();
            CarregarGrid();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            frmUsuarioCadastro frmUsuarioCadastro = new frmUsuarioCadastro();
            frmUsuarioCadastro.Operacao = frmUsuarioCadastro.Ope.Inclusao;
            frmUsuarioCadastro.ShowDialog();
            CarregarGrid();
        }

        private void dgdGrid_DoubleClick(object sender, EventArgs e)
        {
            frmUsuarioCadastro frmUsuarioCadastro = new frmUsuarioCadastro();
            frmUsuarioCadastro.Operacao = frmUsuarioCadastro.Ope.Alteracao;
            frmUsuarioCadastro.Codigo = (int)dgdGrid.CurrentRow.Cells[0].Value;
            frmUsuarioCadastro.ShowDialog();
            CarregarGrid();
        }

        private void dgdGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmUsuarioCadastro frmUsuarioCadastro = new frmUsuarioCadastro();
            frmUsuarioCadastro.Operacao = frmUsuarioCadastro.Ope.Alteracao;
            frmUsuarioCadastro.Codigo = (int)dgdGrid.CurrentRow.Cells[0].Value;
            frmUsuarioCadastro.ShowDialog();
            CarregarGrid();
        }
    }
}