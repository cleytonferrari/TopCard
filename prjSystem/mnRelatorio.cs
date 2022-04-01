using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;

namespace prjSystem
{
    public partial class mnRelatorio : UserControl
    {
        public mnRelatorio()
        {
            InitializeComponent();
        }

        private void bairrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rel_form frm = new rel_form();
            rel_RPT_bairro rel = new rel_RPT_bairro();
            clsBancoDados clsBancoDados = new clsBancoDados();
            FbConnection conn = clsBancoDados.retornaConn();
            DataSet ds = new DataSet();
            FbDataAdapter da = new FbDataAdapter("SELECT * FROM BAIRROS", conn);
            da.Fill(ds, "BAIRROS");
            frm.report = rel;
            frm.ds = ds;
            frm.ShowDialog();
        }

        private void movimentaçãoTesteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rel_form frm = new rel_form();
            rel_RPT_hierarquica rel = new rel_RPT_hierarquica();
            clsBancoDados clsBancoDados = new clsBancoDados();
            FbConnection conn = clsBancoDados.retornaConn();

            rel_DS_movimentacao ds = new rel_DS_movimentacao();

            FbDataAdapter mp = new FbDataAdapter("SELECT * FROM MOVPAI", conn);
            FbDataAdapter mf = new FbDataAdapter("SELECT * FROM MOVFILHO", conn);
            FbDataAdapter mn = new FbDataAdapter("SELECT * FROM MOVNETO", conn);

            mp.Fill(ds, "MOVPAI");
            mf.Fill(ds, "MOVFILHO");
            mn.Fill(ds, "MOVNETO");

            frm.report = rel;
            frm.ds = ds;
            frm.ShowDialog();
        }
    }
}
