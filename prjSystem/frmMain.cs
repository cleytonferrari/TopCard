using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
//manimupula Ini
//le ini
using Org.Mentalis.Files;
using System.IO;

namespace prjSystem
{
    public partial class frmMain : Form
    {
        string strUser = "Cleyton Ferrari";
        mnCadastros mnCadastro = new mnCadastros();
        mnAjuda mnAjuda = new mnAjuda();
        mnRelatorio mnRelatorio = new mnRelatorio();

        public frmMain()
        {
            InitializeComponent();
            //chama o form splash
            frmSplash frmSplash = new frmSplash();
            frmSplash.ShowDialog();
            //chama o formulario de login
            frmLogin frmLogin = new frmLogin();
            frmLogin.ShowDialog();
            strUser = frmLogin.user;
            
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            string file = "";
            string server = "";
            string bd = "";
            file = Application.StartupPath;
            file += "\\conf.ini";
            IniReader ini = new IniReader(file);
            server = ini.ReadString("ALSoftware", "server");
            bd = ini.ReadString("ALSoftware", "banco");

            //Coloca a versão do programa na Barra
            sbLabel001.Text = "Versão " + Application.ProductVersion;
            sbLabel002.Text = "Servidor [" + server + "] - Banco [" + bd + "]";
            sbLabel003.Text = "Usuário Logado [" + strUser + "]";
            sbLabel004.Text = DateTime.Now.ToLongDateString();
            this.Text = "TopCard System - Controle de Cartão Desconto - Versão: " + Application.ProductVersion;
            menuPrincipal("cadastro");
        }
        public void menuPrincipal(string menu)
        {
            //estica para a area toda
            mnAjuda.Dock = DockStyle.Fill;
            mnCadastro.Dock = DockStyle.Fill;
            mnRelatorio.Dock = DockStyle.Fill;
            //remove o painel que estiver aberto para adicionar o novo
            BarraFerramentasPainel.Panel2.Controls.Remove(mnAjuda);
            BarraFerramentasPainel.Panel2.Controls.Remove(mnCadastro);
            BarraFerramentasPainel.Panel2.Controls.Remove(mnRelatorio);
            //limpa os botão selecionado
            btnCadastros.Checked = false;
            btnAjuda.Checked = false;
            btnRelatorio.Checked = false;


            switch (menu)
            {
                case "cadastro":
                    {
                        BarraFerramentasPainel.Panel2.Controls.Add(mnCadastro);
                        btnCadastros.Checked = true;
                        break;
                    }
                case "ajuda":
                    {
                        BarraFerramentasPainel.Panel2.Controls.Add(mnAjuda);
                        btnAjuda.Checked = true;
                        break;
                    }
                case "relatorio":
                    {
                        BarraFerramentasPainel.Panel2.Controls.Add(mnRelatorio);
                        btnRelatorio.Checked = true;
                        break;
                    }
            }
        }

        private void btnCadastros_Click(object sender, EventArgs e)
        {
            menuPrincipal("cadastro");
        }

        private void btnAjuda_Click(object sender, EventArgs e)
        {
            menuPrincipal("ajuda");
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            menuPrincipal("relatorio");
        }
    }
}