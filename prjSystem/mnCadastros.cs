using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace prjSystem
{
    public partial class mnCadastros : UserControl
    {
        public mnCadastros()
        {
            InitializeComponent();
        }

        private void logradourosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEnderecoConsulta frmEnderecoConsulta = new frmEnderecoConsulta("");
            frmEnderecoConsulta.ShowDialog();
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuarioConsulta frmUsuarioConsulta = new frmUsuarioConsulta();
            frmUsuarioConsulta.ShowDialog();
        }

        private void btnEndereco_ButtonClick(object sender, EventArgs e)
        {
            frmEnderecoConsulta frmEnderecoConsulta = new frmEnderecoConsulta("");
            frmEnderecoConsulta.ShowDialog();
        }

        private void bairrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBairroConsulta frmBairroConsulta = new frmBairroConsulta("");
            frmBairroConsulta.ShowDialog();
        }

        private void clientesFiliadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void btnProprietario_ButtonClick(object sender, EventArgs e)
        {
            frmMovimentacaoClienteConsulta frmClienteConsulta = new frmMovimentacaoClienteConsulta("");
            frmClienteConsulta.ShowDialog();
        }

        private void lançarMovimentaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void exportarDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExportarDados frm = new frmExportarDados();
            frm.ShowDialog();
        }

        private void btnProprietario_Click(object sender, EventArgs e)
        {
            frmMovimentacaoClienteConsulta frmClienteConsulta = new frmMovimentacaoClienteConsulta("");
            frmClienteConsulta.ShowDialog();
        }

        private void toolStripSplitButton1_Click(object sender, EventArgs e)
        {
            frmMovimentacaoConsulta frmMovimentacaoConsulta = new frmMovimentacaoConsulta();
            frmMovimentacaoConsulta.ShowDialog();
            //frmMovimentacao frmMovimentacao = new frmMovimentacao();
            //frmMovimentacao.Codigo = frmClienteConsulta.codSelecionado;
            //frmMovimentacao.ShowDialog();
        }
    }
}
