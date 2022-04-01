namespace prjSystem
{
    partial class frmMunicipioConsulta
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
            this.totToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.lbPesq = new System.Windows.Forms.ListBox();
            this.gb = new System.Windows.Forms.GroupBox();
            this.rbQualquer = new System.Windows.Forms.RadioButton();
            this.rbComecar = new System.Windows.Forms.RadioButton();
            this.rbExato = new System.Windows.Forms.RadioButton();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.errErro = new System.Windows.Forms.ErrorProvider(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.grpGrupo = new System.Windows.Forms.GroupBox();
            this.dgdGrid = new System.Windows.Forms.DataGridView();
            this.C�digo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descri��o = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errErro)).BeginInit();
            this.grpGrupo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "       Selecionar";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lbPesq
            // 
            this.lbPesq.BackColor = System.Drawing.Color.White;
            this.lbPesq.Items.AddRange(new object[] {
            "C�digo",
            "Munic�pio",
            "UF"});
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
            this.rbComecar.Text = "Come�ar por...";
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
            // errErro
            // 
            this.errErro.ContainerControl = this;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(493, 29);
            this.label3.TabIndex = 12;
            this.label3.Text = "Localizar Munic�pio para o Endere�o";
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
            this.grpGrupo.TabIndex = 0;
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
            this.C�digo,
            this.Descri��o,
            this.uf});
            this.dgdGrid.Location = new System.Drawing.Point(6, 144);
            this.dgdGrid.MultiSelect = false;
            this.dgdGrid.Name = "dgdGrid";
            this.dgdGrid.ReadOnly = true;
            this.dgdGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgdGrid.Size = new System.Drawing.Size(557, 169);
            this.dgdGrid.TabIndex = 4;
            this.dgdGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgdGrid_CellDoubleClick);
            // 
            // C�digo
            // 
            this.C�digo.DataPropertyName = "municipio_id";
            this.C�digo.HeaderText = "C�digo";
            this.C�digo.Name = "C�digo";
            this.C�digo.ReadOnly = true;
            this.C�digo.Width = 85;
            // 
            // Descri��o
            // 
            this.Descri��o.DataPropertyName = "nome";
            this.Descri��o.HeaderText = "Munic�pio";
            this.Descri��o.Name = "Descri��o";
            this.Descri��o.ReadOnly = true;
            this.Descri��o.Width = 360;
            // 
            // uf
            // 
            this.uf.DataPropertyName = "uf";
            this.uf.HeaderText = "UF";
            this.uf.Name = "uf";
            this.uf.ReadOnly = true;
            this.uf.Width = 50;
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
            this.pictureBox1.Location = new System.Drawing.Point(539, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // frmMunicipioConsulta
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
            this.Controls.Add(this.grpGrupo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSair);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMunicipioConsulta";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Localizar Munic�pio para o Endere�o";
            this.Load += new System.EventHandler(this.frmEnderecoPesqMunicipio_Load);
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

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.ToolTip totToolTip;
        private System.Windows.Forms.ErrorProvider errErro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpGrupo;
        public System.Windows.Forms.DataGridView dgdGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn C�digo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descri��o;
        private System.Windows.Forms.DataGridViewTextBoxColumn uf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbPesq;
        private System.Windows.Forms.GroupBox gb;
        private System.Windows.Forms.RadioButton rbQualquer;
        private System.Windows.Forms.RadioButton rbComecar;
        private System.Windows.Forms.RadioButton rbExato;
        public System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}