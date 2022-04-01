namespace prjSystem
{
    partial class frmUsuarioConsulta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.totToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.lbPesq = new System.Windows.Forms.ListBox();
            this.gb = new System.Windows.Forms.GroupBox();
            this.rbQualquer = new System.Windows.Forms.RadioButton();
            this.rbComecar = new System.Windows.Forms.RadioButton();
            this.rbExato = new System.Windows.Forms.RadioButton();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.btnNovo = new System.Windows.Forms.Button();
            this.errErro = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpGrupo = new System.Windows.Forms.GroupBox();
            this.dgdGrid = new System.Windows.Forms.DataGridView();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Loggin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Senha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errErro)).BeginInit();
            this.grpGrupo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAlterar
            // 
            this.btnAlterar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(147)))), ((int)(((byte)(215)))));
            this.btnAlterar.Image = global::prjSystem.Properties.Resources.alterar;
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterar.Location = new System.Drawing.Point(219, 372);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(115, 38);
            this.btnAlterar.TabIndex = 13;
            this.btnAlterar.Text = "   Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnSair
            // 
            this.btnSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSair.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(147)))), ((int)(((byte)(215)))));
            this.btnSair.Image = global::prjSystem.Properties.Resources.sair;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(461, 372);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(115, 38);
            this.btnSair.TabIndex = 15;
            this.btnSair.Text = "   Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(147)))), ((int)(((byte)(215)))));
            this.btnExcluir.Image = global::prjSystem.Properties.Resources.excluir;
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.Location = new System.Drawing.Point(340, 372);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(115, 38);
            this.btnExcluir.TabIndex = 14;
            this.btnExcluir.Text = "    Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // lbPesq
            // 
            this.lbPesq.BackColor = System.Drawing.Color.White;
            this.lbPesq.Items.AddRange(new object[] {
            "Código",
            "Login",
            "Nome"});
            this.lbPesq.Location = new System.Drawing.Point(227, 69);
            this.lbPesq.Name = "lbPesq";
            this.lbPesq.ScrollAlwaysVisible = true;
            this.lbPesq.Size = new System.Drawing.Size(336, 69);
            this.lbPesq.Sorted = true;
            this.lbPesq.TabIndex = 2;
            this.totToolTip.SetToolTip(this.lbPesq, "Escolha em qual campo deve ser feita a pesquisa");
            // 
            // gb
            // 
            this.gb.Controls.Add(this.rbQualquer);
            this.gb.Controls.Add(this.rbComecar);
            this.gb.Controls.Add(this.rbExato);
            this.gb.ForeColor = System.Drawing.Color.Black;
            this.gb.Location = new System.Drawing.Point(8, 51);
            this.gb.Name = "gb";
            this.gb.Size = new System.Drawing.Size(200, 87);
            this.gb.TabIndex = 1;
            this.gb.TabStop = false;
            this.gb.Text = "Como devo pesquisar?";
            this.totToolTip.SetToolTip(this.gb, "Escolha como deve ser feita a pesquisa");
            // 
            // rbQualquer
            // 
            this.rbQualquer.AutoSize = true;
            this.rbQualquer.Checked = true;
            this.rbQualquer.Location = new System.Drawing.Point(11, 22);
            this.rbQualquer.Name = "rbQualquer";
            this.rbQualquer.Size = new System.Drawing.Size(143, 17);
            this.rbQualquer.TabIndex = 0;
            this.rbQualquer.TabStop = true;
            this.rbQualquer.Text = "Em qualquer parte...";
            this.rbQualquer.UseVisualStyleBackColor = true;
            // 
            // rbComecar
            // 
            this.rbComecar.AutoSize = true;
            this.rbComecar.Location = new System.Drawing.Point(11, 43);
            this.rbComecar.Name = "rbComecar";
            this.rbComecar.Size = new System.Drawing.Size(112, 17);
            this.rbComecar.TabIndex = 1;
            this.rbComecar.Text = "Começar por...";
            this.rbComecar.UseVisualStyleBackColor = true;
            // 
            // rbExato
            // 
            this.rbExato.AutoSize = true;
            this.rbExato.Location = new System.Drawing.Point(11, 64);
            this.rbExato.Name = "rbExato";
            this.rbExato.Size = new System.Drawing.Size(115, 17);
            this.rbExato.TabIndex = 2;
            this.rbExato.Text = "O texto exato...";
            this.rbExato.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(147)))), ((int)(((byte)(215)))));
            this.btnPesquisar.Image = global::prjSystem.Properties.Resources.lupa;
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisar.Location = new System.Drawing.Point(448, 16);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(115, 38);
            this.btnPesquisar.TabIndex = 3;
            this.btnPesquisar.Text = "     Pesquisar";
            this.totToolTip.SetToolTip(this.btnPesquisar, "Clique para iniciar a pesquisa com os parametros selecionados");
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtDescricao
            // 
            this.txtDescricao.BackColor = System.Drawing.Color.White;
            this.txtDescricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescricao.Location = new System.Drawing.Point(107, 26);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(333, 21);
            this.txtDescricao.TabIndex = 0;
            this.totToolTip.SetToolTip(this.txtDescricao, "Informe o texto para pesquisa");
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(147)))), ((int)(((byte)(215)))));
            this.btnNovo.Image = global::prjSystem.Properties.Resources.novo;
            this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovo.Location = new System.Drawing.Point(98, 372);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(115, 38);
            this.btnNovo.TabIndex = 12;
            this.btnNovo.Text = "    Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // errErro
            // 
            this.errErro.ContainerControl = this;
            // 
            // grpGrupo
            // 
            this.grpGrupo.BackColor = System.Drawing.Color.Transparent;
            this.grpGrupo.Controls.Add(this.dgdGrid);
            this.grpGrupo.Controls.Add(this.label2);
            this.grpGrupo.Controls.Add(this.label1);
            this.grpGrupo.Controls.Add(this.lbPesq);
            this.grpGrupo.Controls.Add(this.gb);
            this.grpGrupo.Controls.Add(this.btnPesquisar);
            this.grpGrupo.Controls.Add(this.txtDescricao);
            this.grpGrupo.ForeColor = System.Drawing.Color.Black;
            this.grpGrupo.Location = new System.Drawing.Point(9, 46);
            this.grpGrupo.Name = "grpGrupo";
            this.grpGrupo.Size = new System.Drawing.Size(569, 319);
            this.grpGrupo.TabIndex = 16;
            this.grpGrupo.TabStop = false;
            // 
            // dgdGrid
            // 
            this.dgdGrid.AllowUserToAddRows = false;
            this.dgdGrid.AllowUserToDeleteRows = false;
            this.dgdGrid.AllowUserToResizeRows = false;
            this.dgdGrid.BackgroundColor = System.Drawing.Color.White;
            this.dgdGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgdGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Código,
            this.Nome,
            this.Loggin,
            this.Senha});
            this.dgdGrid.Location = new System.Drawing.Point(6, 144);
            this.dgdGrid.MultiSelect = false;
            this.dgdGrid.Name = "dgdGrid";
            this.dgdGrid.ReadOnly = true;
            this.dgdGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgdGrid.Size = new System.Drawing.Size(557, 169);
            this.dgdGrid.TabIndex = 12;
            this.dgdGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgdGrid_CellDoubleClick);
            // 
            // Código
            // 
            this.Código.DataPropertyName = "usuario_id";
            this.Código.HeaderText = "Código";
            this.Código.Name = "Código";
            this.Código.ReadOnly = true;
            this.Código.Width = 60;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 280;
            // 
            // Loggin
            // 
            this.Loggin.DataPropertyName = "login";
            this.Loggin.HeaderText = "Login";
            this.Loggin.Name = "Loggin";
            this.Loggin.ReadOnly = true;
            this.Loggin.Width = 155;
            // 
            // Senha
            // 
            this.Senha.DataPropertyName = "senha";
            this.Senha.HeaderText = "Senha";
            this.Senha.Name = "Senha";
            this.Senha.ReadOnly = true;
            this.Senha.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Procurar por:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Pesquisar por:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(453, 29);
            this.label3.TabIndex = 17;
            this.label3.Text = "Cadastro de Usuários do Sistema";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::prjSystem.Properties.Resources.icone_sistema;
            this.pictureBox1.Location = new System.Drawing.Point(539, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // frmUsuarioConsulta
            // 
            this.AcceptButton = this.btnPesquisar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(250)))));
            this.BackgroundImage = global::prjSystem.Properties.Resources.bg_formulario;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CancelButton = this.btnSair;
            this.ClientSize = new System.Drawing.Size(588, 417);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.grpGrupo);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnNovo);
            this.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUsuarioConsulta";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Usuários";
            this.Load += new System.EventHandler(this.frmUsuarioConsulta_Load);
            this.gb.ResumeLayout(false);
            this.gb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errErro)).EndInit();
            this.grpGrupo.ResumeLayout(false);
            this.grpGrupo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.ToolTip totToolTip;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.ErrorProvider errErro;
        private System.Windows.Forms.GroupBox grpGrupo;
        public System.Windows.Forms.DataGridView dgdGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Loggin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Senha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbPesq;
        private System.Windows.Forms.GroupBox gb;
        private System.Windows.Forms.RadioButton rbQualquer;
        private System.Windows.Forms.RadioButton rbComecar;
        private System.Windows.Forms.RadioButton rbExato;
        public System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}