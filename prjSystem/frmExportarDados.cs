using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace prjSystem
{
    public partial class frmExportarDados : Form
    {
        public frmExportarDados()
        {
            InitializeComponent();
        }

        private void btnCaminho_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Arquivo XML|*.xml";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                lblCaminho.Text = sfd.FileName;
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            clsCliente clsCliente = new clsCliente();
            DataSet ds = new DataSet();
            ds = clsCliente.ListarExportar();

            XmlTextWriter xmltw = new XmlTextWriter("dados.xml", System.Text.Encoding.UTF8);
            string strQuery = "";
            string strQuery2 = "";

            if (lblCaminho.Text != "")
            {
                xmltw.WriteStartDocument();
                xmltw.WriteStartElement("SQL");
                xmltw.WriteStartElement("inserts", null);
                pbar.Value = 0;
                pbar.Minimum = 0;
                pbar.Maximum = ds.Tables[0].Rows.Count - 1;
                for (int i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
                {
                    strQuery = (" INSERT INTO cliente ");
                    strQuery += (" ( ");
                    strQuery += ("   cliente_id, ");
                    strQuery += ("   enderecos_id, ");
                    strQuery += ("   banco_id, ");
                    strQuery += ("   nome, ");
                    strQuery += ("   datanascimento, ");
                    strQuery += ("   pai, ");
                    strQuery += ("   mae, ");
                    strQuery += ("   formadepagamento, ");
                    strQuery += ("   cc, ");
                    strQuery += ("   ag, ");
                    strQuery += ("   status, ");
                    strQuery += ("   cpf, ");
                    strQuery += ("   rg, ");
                    strQuery += ("   datacadastro, ");
                    strQuery += ("   telefones, ");
                    strQuery += ("   email, ");
                    strQuery += ("   obs, ");
                    strQuery += ("   natural_id, ");
                    strQuery += ("   estadocivil, ");
                    strQuery += ("   profissao, ");
                    strQuery += ("   nacionalidade, ");
                    strQuery += ("   sexo, ");
                    strQuery += ("   vippai_id, ");
                    strQuery += ("   numero, ");
                    strQuery += ("   contrato ");
                    strQuery += (" ) ");

                    strQuery += (" VALUES ");
                    strQuery += (" ( ");
                    strQuery += ("   '" + ds.Tables[0].Rows[i]["cliente_id"].ToString() + "', ");
                    strQuery += ("   '" + ds.Tables[0].Rows[i]["enderecos_id"].ToString() + "', ");
                    strQuery += ("   '" + ds.Tables[0].Rows[i]["banco_id"].ToString() + "', ");
                    strQuery += ("   '" + ds.Tables[0].Rows[i]["nome"].ToString() + "', ");

                    strQuery += ("   '" + Convert.ToDateTime(ds.Tables[0].Rows[i]["datanascimento"].ToString()).ToString("yyy/MM/dd") + "', ");
                    strQuery += ("   '" + ds.Tables[0].Rows[i]["pai"].ToString() + "', ");
                    strQuery += ("   '" + ds.Tables[0].Rows[i]["mae"].ToString() + "', ");
                    strQuery += ("   '" + ds.Tables[0].Rows[i]["formadepagamento"].ToString() + "', ");
                    strQuery += ("   '" + ds.Tables[0].Rows[i]["cc"].ToString() + "', ");
                    strQuery += ("   '" + ds.Tables[0].Rows[i]["ag"].ToString() + "', ");
                    strQuery += ("   '" + ds.Tables[0].Rows[i]["status"].ToString() + "', ");
                    strQuery += ("   '" + ds.Tables[0].Rows[i]["cpf"].ToString() + "', ");
                    strQuery += ("   '" + ds.Tables[0].Rows[i]["rg"].ToString() + "', ");
                    strQuery += ("   '" + Convert.ToDateTime(ds.Tables[0].Rows[i]["datacadastro"].ToString()).ToString("yyy/MM/dd") + "', ");
                    strQuery += ("   '" + ds.Tables[0].Rows[i]["telefones"].ToString() + "', ");
                    strQuery += ("   '" + ds.Tables[0].Rows[i]["email"].ToString() + "', ");
                    strQuery += ("   '" + ds.Tables[0].Rows[i]["obs"].ToString() + "', ");
                    strQuery += ("   '" + ds.Tables[0].Rows[i]["natural_id"].ToString() + "', ");
                    strQuery += ("   '" + ds.Tables[0].Rows[i]["estadocivil"].ToString() + "', ");
                    strQuery += ("   '" + ds.Tables[0].Rows[i]["profissao"].ToString() + "', ");
                    strQuery += ("   '" + ds.Tables[0].Rows[i]["nacionalidade"].ToString() + "', ");
                    strQuery += ("   '" + ds.Tables[0].Rows[i]["sexo"].ToString() + "', ");
                    strQuery += ("   '" + ds.Tables[0].Rows[i]["vippai_id"].ToString() + "', ");
                    strQuery += ("   '" + ds.Tables[0].Rows[i]["numero"].ToString() + "', ");
                    strQuery += ("   '" + ds.Tables[0].Rows[i]["contrato"].ToString() + "' ");
                    strQuery += (" ) ");
                    //update
                    strQuery2 = (" UPDATE cliente ");
                    strQuery2 += (" SET ");
                    strQuery2 += ("     enderecos_id = '" + ds.Tables[0].Rows[i]["enderecos_id"].ToString() + "', ");
                    strQuery2 += ("     banco_id = '" + ds.Tables[0].Rows[i]["banco_id"].ToString() + "', ");
                    strQuery2 += ("     nome = '" + ds.Tables[0].Rows[i]["nome"].ToString() + "', ");
                    strQuery2 += ("     datanascimento = '" + Convert.ToDateTime(ds.Tables[0].Rows[i]["datanascimento"].ToString()).ToString("yyy/MM/dd") + "', ");
                    strQuery2 += ("     pai = '" + ds.Tables[0].Rows[i]["pai"].ToString() + "', ");
                    strQuery2 += ("     mae = '" + ds.Tables[0].Rows[i]["mae"].ToString() + "', ");
                    strQuery2 += ("     formadepagamento = '" + ds.Tables[0].Rows[i]["formadepagamento"].ToString() + "', ");
                    strQuery2 += ("     cc = '" + ds.Tables[0].Rows[i]["cc"].ToString() + "', ");
                    strQuery2 += ("     ag = '" + ds.Tables[0].Rows[i]["ag"].ToString() + "', ");
                    strQuery2 += ("     status = '" + ds.Tables[0].Rows[i]["status"].ToString() + "', ");
                    strQuery2 += ("     cpf = '" + ds.Tables[0].Rows[i]["cpf"].ToString() + "', ");
                    strQuery2 += ("     rg = '" + ds.Tables[0].Rows[i]["rg"].ToString() + "', ");
                    strQuery2 += ("     datacadastro = '" + Convert.ToDateTime(ds.Tables[0].Rows[i]["datacadastro"].ToString()).ToString("yyy/MM/dd") + "', ");
                    strQuery2 += ("     telefones = '" + ds.Tables[0].Rows[i]["telefones"].ToString() + "', ");
                    strQuery2 += ("     email = '" + ds.Tables[0].Rows[i]["email"].ToString() + "', ");
                    strQuery2 += ("     obs = '" + ds.Tables[0].Rows[i]["obs"].ToString() + "', ");
                    strQuery2 += ("     natural_id = '" + ds.Tables[0].Rows[i]["natural_id"].ToString() + "', ");
                    strQuery2 += ("     estadocivil = '" + ds.Tables[0].Rows[i]["estadocivil"].ToString() + "', ");
                    strQuery2 += ("     profissao = '" + ds.Tables[0].Rows[i]["profissao"].ToString() + "', ");
                    strQuery2 += ("     nacionalidade = '" + ds.Tables[0].Rows[i]["nacionalidade"].ToString() + "', ");
                    strQuery2 += ("     sexo = '" + ds.Tables[0].Rows[i]["sexo"].ToString() + "', ");
                    strQuery2 += ("     vippai_id = '" + ds.Tables[0].Rows[i]["vippai_id"].ToString() + "', ");
                    strQuery2 += ("     numero = '" + ds.Tables[0].Rows[i]["numero"].ToString() + "', ");
                    strQuery2 += ("     contrato = '" + ds.Tables[0].Rows[i]["contrato"].ToString() + "' ");
                    strQuery2 += (" WHERE ");
                    strQuery2 += ("      cliente_id = " + ds.Tables[0].Rows[i]["cliente_id"].ToString() + " ");

                    xmltw.WriteElementString("query", ds.Tables[0].Rows[i]["cliente_id"].ToString()+"#"+strQuery+"#"+strQuery2);
                    pbar.Increment(1);
                }    
                
                xmltw.WriteEndElement();
                xmltw.WriteEndElement();
                xmltw.Close();
                MessageBox.Show("Dados Exportados com Sucesso!\nLocal: "+lblCaminho.Text, Application.ProductName,
            MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void frmExportarDados_Load(object sender, EventArgs e)
        {
            lblCaminho.Text = Application.StartupPath + "\\dados.xml";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
