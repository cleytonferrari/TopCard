using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace prjSystem
{
    public partial class frmBancoConsulta : Form
    {
        string ch = "";

        /// <summary>
        /// Passa para o contrutor quem chamou
        /// se ele abriu sozinho para edição normal
        /// ou se esta sendo usado para pesquisar algum
        /// dado para outro formulario
        /// </summary>
        /// <param name="chamou">Iforme "" (vazio) para nenhuma chadama ou "form" para formulario de pesquisa</param>
        public frmBancoConsulta(string chamou)
        {
            ch = chamou;
            InitializeComponent();
        }
        private string _codSelecionado;
        public string codSelecionado
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
            clsBanco clsBanco = new clsBanco();
            switch (lbPesq.Text)
            {
                case "Nome do Banco": strCampo = "banco";
                    break;
                case "Código": strCampo = "banco_id";
                    break;
                default: strCampo = "banco";
                    break;
            }
            if (rbQualquer.Checked)
                strTipo = "qualquer";
            if (rbComecar.Checked)
                strTipo = "comecar";
            if (rbExato.Checked)
                strTipo = "exato";
            dgdGrid.DataSource = clsBanco.ListarComParametro(strCampo, txtDescricao.Text, strTipo).Tables[0];
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void frmBancoConsulta_Load(object sender, EventArgs e)
        {
            CarregarGrid();
            lbPesq.Text = lbPesq.Items[1].ToString();
        }

        private void dgdGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Quando tiver formulario de cadastro de municipio abre ele aqui
            _codSelecionado = dgdGrid.CurrentRow.Cells[0].Value.ToString();
            this.Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (ch != "")
            {
                _codSelecionado = dgdGrid.CurrentRow.Cells[0].Value.ToString();
            }
            this.Close();
        }

    }
}
