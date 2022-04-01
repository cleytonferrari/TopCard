using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace prjSystem
{
    public partial class frmVipPaiConsulta : Form
    {
        string ch = "";

        /// <summary>
        /// Passa para o contrutor quem chamou
        /// se ele abriu sozinho para edição normal
        /// ou se esta sendo usado para pesquisar algum
        /// dado para outro formulario
        /// </summary>
        /// <param name="chamou">Iforme "" (vazio) para nenhuma chadama ou "form" para formulario de pesquisa</param>
        public frmVipPaiConsulta(string chamou)
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
            clsVipPai clsVipPai = new clsVipPai();
            switch (lbPesq.Text)
            {
                case "Código": strCampo = "vippai_id";
                    break;
                case "CPF": strCampo = "cpf";
                    break;
                case "Mãe": strCampo = "mae";
                    break;
                case "Nome": strCampo = "nome";
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
            dgdGrid.DataSource = clsVipPai.ListarComParametro(strCampo, txtDescricao.Text, strTipo).Tables[0];
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void frmVipPaiConsulta_Load(object sender, EventArgs e)
        {
            CarregarGrid();
            lbPesq.Text = lbPesq.Items[3].ToString();
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
