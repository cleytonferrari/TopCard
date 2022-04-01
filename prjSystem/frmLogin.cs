using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace prjSystem
{
    public partial class frmLogin : Form
    {
        
        public frmLogin()
        {
            InitializeComponent();
        }
        public static bool fechar = true;
        private string _user;
        public string user
        {
            get
            {
                return _user;
            }
            set
            {
                _user = value;
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            clsLogin clsLoggin = new clsLogin();
            if (clsLoggin.VerificaUsuario(txtLoggin.Text, txtSenha.Text) != "")
            {
                fechar = false;
                _user = clsLoggin.userFull;
                this.Close();
            }
            else
            {
                errErro.SetError(txtLoggin, "Usuário/Senha não conferem!");
                txtLoggin.Focus();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //Termina a aplicação
            Application.Exit();
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (fechar == true)
                Application.Exit();
        }

        private void btnSegredo_DoubleClick(object sender, EventArgs e)
        {
            fechar = false;
            this.Close();
        }
    }
}