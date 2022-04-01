namespace prjSystem
{
    partial class frmVipPaiConsulta
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
            this.btnSair = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.totToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.lbPesq = new System.Windows.Forms.ListBox();
            this.gb = new System.Windows.Forms.GroupBox();
            this.rbQualquer = new System.Windows.Forms.RadioButton();
            this.rbComecar = new System.Windows.Forms.RadioButton();
            this.rbExato = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.errErro = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpGrupo = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgdGrid = new System.Windows.Forms.DataGridView();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datanascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mae = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formadepagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datacadastro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadocivil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profissao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nacionalidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enderecos_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.banco_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.natural_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vipavo_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vippai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vippaicpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errErro)).BeginInit();
            this.grpGrupo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgdGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSair.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(147)))), ((int)(((byte)(215)))));
            this.btnSair.Image = global::prjSystem.Properties.Resources.sair;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(463, 375);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(115, 38);
            this.btnSair.TabIndex = 19;
            this.btnSair.Text = "       Selecionar";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
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
            // lbPesq
            // 
            this.lbPesq.BackColor = System.Drawing.Color.White;
            this.lbPesq.Items.AddRange(new object[] {
            "Código",
            "CPF",
            "Mãe",
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(8, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(509, 29);
            this.label3.TabIndex = 20;
            this.label3.Text = "Localizar Vip Pai para Cliente/Filiado";
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
            this.grpGrupo.Location = new System.Drawing.Point(11, 49);
            this.grpGrupo.Name = "grpGrupo";
            this.grpGrupo.Size = new System.Drawing.Size(569, 319);
            this.grpGrupo.TabIndex = 18;
            this.grpGrupo.TabStop = false;
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
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::prjSystem.Properties.Resources.icone_endereco;
            this.pictureBox1.Location = new System.Drawing.Point(541, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
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
            this.nome,
            this.datanascimento,
            this.pai,
            this.mae,
            this.formadepagamento,
            this.cc,
            this.ag,
            this.status,
            this.cpf,
            this.rg,
            this.datacadastro,
            this.telefones,
            this.email,
            this.obs,
            this.estadocivil,
            this.profissao,
            this.nacionalidade,
            this.sexo,
            this.numero,
            this.enderecos_id,
            this.banco_id,
            this.natural_id,
            this.vipavo_id,
            this.vippai,
            this.vippaicpf});
            this.dgdGrid.Location = new System.Drawing.Point(6, 144);
            this.dgdGrid.MultiSelect = false;
            this.dgdGrid.Name = "dgdGrid";
            this.dgdGrid.ReadOnly = true;
            this.dgdGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgdGrid.Size = new System.Drawing.Size(557, 169);
            this.dgdGrid.TabIndex = 7;
            this.dgdGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgdGrid_CellDoubleClick);
            // 
            // Código
            // 
            this.Código.DataPropertyName = "vippai_id";
            this.Código.HeaderText = "Código";
            this.Código.Name = "Código";
            this.Código.ReadOnly = true;
            this.Código.Width = 50;
            // 
            // nome
            // 
            this.nome.DataPropertyName = "nome";
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            this.nome.Width = 200;
            // 
            // datanascimento
            // 
            this.datanascimento.DataPropertyName = "datanascimento";
            this.datanascimento.HeaderText = "Data Nascimento";
            this.datanascimento.Name = "datanascimento";
            this.datanascimento.ReadOnly = true;
            this.datanascimento.Visible = false;
            this.datanascimento.Width = 150;
            // 
            // pai
            // 
            this.pai.DataPropertyName = "pai";
            this.pai.HeaderText = "Pai";
            this.pai.Name = "pai";
            this.pai.ReadOnly = true;
            this.pai.Visible = false;
            // 
            // mae
            // 
            this.mae.DataPropertyName = "mae";
            this.mae.HeaderText = "Mãe";
            this.mae.Name = "mae";
            this.mae.ReadOnly = true;
            // 
            // formadepagamento
            // 
            this.formadepagamento.DataPropertyName = "formadepagamento";
            this.formadepagamento.HeaderText = "Forma Pgto";
            this.formadepagamento.Name = "formadepagamento";
            this.formadepagamento.ReadOnly = true;
            this.formadepagamento.Visible = false;
            // 
            // cc
            // 
            this.cc.DataPropertyName = "cc";
            this.cc.HeaderText = "Conta Corrente";
            this.cc.Name = "cc";
            this.cc.ReadOnly = true;
            this.cc.Visible = false;
            // 
            // ag
            // 
            this.ag.DataPropertyName = "ag";
            this.ag.HeaderText = "Agência";
            this.ag.Name = "ag";
            this.ag.ReadOnly = true;
            this.ag.Visible = false;
            // 
            // status
            // 
            this.status.DataPropertyName = "status";
            this.status.HeaderText = "Situação";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // cpf
            // 
            this.cpf.DataPropertyName = "cpf";
            this.cpf.HeaderText = "CPF";
            this.cpf.Name = "cpf";
            this.cpf.ReadOnly = true;
            // 
            // rg
            // 
            this.rg.DataPropertyName = "rg";
            this.rg.HeaderText = "RG";
            this.rg.Name = "rg";
            this.rg.ReadOnly = true;
            // 
            // datacadastro
            // 
            this.datacadastro.DataPropertyName = "datacadastro";
            this.datacadastro.HeaderText = "Cadastrado em";
            this.datacadastro.Name = "datacadastro";
            this.datacadastro.ReadOnly = true;
            this.datacadastro.Visible = false;
            // 
            // telefones
            // 
            this.telefones.DataPropertyName = "telefones";
            this.telefones.HeaderText = "Telefone";
            this.telefones.Name = "telefones";
            this.telefones.ReadOnly = true;
            this.telefones.Visible = false;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Visible = false;
            // 
            // obs
            // 
            this.obs.DataPropertyName = "obs";
            this.obs.HeaderText = "Obs.";
            this.obs.Name = "obs";
            this.obs.ReadOnly = true;
            this.obs.Visible = false;
            // 
            // estadocivil
            // 
            this.estadocivil.DataPropertyName = "estadocivil";
            this.estadocivil.HeaderText = "Estado Civil";
            this.estadocivil.Name = "estadocivil";
            this.estadocivil.ReadOnly = true;
            this.estadocivil.Visible = false;
            // 
            // profissao
            // 
            this.profissao.DataPropertyName = "profissao";
            this.profissao.HeaderText = "Profissão";
            this.profissao.Name = "profissao";
            this.profissao.ReadOnly = true;
            this.profissao.Visible = false;
            // 
            // nacionalidade
            // 
            this.nacionalidade.DataPropertyName = "nacionalidade";
            this.nacionalidade.HeaderText = "Nascionalidade";
            this.nacionalidade.Name = "nacionalidade";
            this.nacionalidade.ReadOnly = true;
            this.nacionalidade.Visible = false;
            // 
            // sexo
            // 
            this.sexo.DataPropertyName = "sexo";
            this.sexo.HeaderText = "Sexo";
            this.sexo.Name = "sexo";
            this.sexo.ReadOnly = true;
            this.sexo.Visible = false;
            this.sexo.Width = 70;
            // 
            // numero
            // 
            this.numero.DataPropertyName = "numero";
            this.numero.HeaderText = "N.º";
            this.numero.Name = "numero";
            this.numero.ReadOnly = true;
            this.numero.Visible = false;
            this.numero.Width = 40;
            // 
            // enderecos_id
            // 
            this.enderecos_id.DataPropertyName = "enderecos_id";
            this.enderecos_id.HeaderText = "Cód.Endereço";
            this.enderecos_id.Name = "enderecos_id";
            this.enderecos_id.ReadOnly = true;
            this.enderecos_id.Visible = false;
            // 
            // banco_id
            // 
            this.banco_id.DataPropertyName = "banco_id";
            this.banco_id.HeaderText = "Cód. Banco";
            this.banco_id.Name = "banco_id";
            this.banco_id.ReadOnly = true;
            this.banco_id.Visible = false;
            // 
            // natural_id
            // 
            this.natural_id.DataPropertyName = "natural_id";
            this.natural_id.HeaderText = "Cód.Natural";
            this.natural_id.Name = "natural_id";
            this.natural_id.ReadOnly = true;
            this.natural_id.Visible = false;
            // 
            // vipavo_id
            // 
            this.vipavo_id.DataPropertyName = "vipavo_id";
            this.vipavo_id.HeaderText = "Cód. Vip Pai";
            this.vipavo_id.Name = "vipavo_id";
            this.vipavo_id.ReadOnly = true;
            this.vipavo_id.Visible = false;
            // 
            // vippai
            // 
            this.vippai.DataPropertyName = "painome";
            this.vippai.HeaderText = "Vip Pai";
            this.vippai.Name = "vippai";
            this.vippai.ReadOnly = true;
            // 
            // vippaicpf
            // 
            this.vippaicpf.DataPropertyName = "paicpf";
            this.vippaicpf.HeaderText = "Vip Pai CPF";
            this.vippaicpf.Name = "vippaicpf";
            this.vippaicpf.ReadOnly = true;
            // 
            // frmVipPaiConsulta
            // 
            this.AcceptButton = this.btnPesquisar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(236)))), ((int)(((byte)(250)))));
            this.BackgroundImage = global::prjSystem.Properties.Resources.bg_formulario;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CancelButton = this.btnSair;
            this.ClientSize = new System.Drawing.Size(588, 417);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.grpGrupo);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmVipPaiConsulta";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Localizar Vip Pai";
            this.Load += new System.EventHandler(this.frmVipPaiConsulta_Load);
            this.gb.ResumeLayout(false);
            this.gb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errErro)).EndInit();
            this.grpGrupo.ResumeLayout(false);
            this.grpGrupo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgdGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        public System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.ToolTip totToolTip;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.ListBox lbPesq;
        private System.Windows.Forms.GroupBox gb;
        private System.Windows.Forms.RadioButton rbQualquer;
        private System.Windows.Forms.RadioButton rbComecar;
        private System.Windows.Forms.RadioButton rbExato;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider errErro;
        private System.Windows.Forms.GroupBox grpGrupo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.DataGridView dgdGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn datanascimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn pai;
        private System.Windows.Forms.DataGridViewTextBoxColumn mae;
        private System.Windows.Forms.DataGridViewTextBoxColumn formadepagamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn cc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ag;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn rg;
        private System.Windows.Forms.DataGridViewTextBoxColumn datacadastro;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefones;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn obs;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadocivil;
        private System.Windows.Forms.DataGridViewTextBoxColumn profissao;
        private System.Windows.Forms.DataGridViewTextBoxColumn nacionalidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn enderecos_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn banco_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn natural_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn vipavo_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn vippai;
        private System.Windows.Forms.DataGridViewTextBoxColumn vippaicpf;
    }
}