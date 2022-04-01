namespace prjSystem
{
    partial class mnCadastros
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.barraFerramentas = new System.Windows.Forms.ToolStrip();
            this.btnEndereco = new System.Windows.Forms.ToolStripSplitButton();
            this.bairrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logradourosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSistema = new System.Windows.Forms.ToolStripSplitButton();
            this.usuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarDadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnProprietario = new System.Windows.Forms.ToolStripButton();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripButton();
            this.barraFerramentas.SuspendLayout();
            this.SuspendLayout();
            // 
            // barraFerramentas
            // 
            this.barraFerramentas.BackColor = System.Drawing.Color.White;
            this.barraFerramentas.BackgroundImage = global::prjSystem.Properties.Resources.bgOffice2;
            this.barraFerramentas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.barraFerramentas.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.barraFerramentas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnEndereco,
            this.btnProprietario,
            this.toolStripSplitButton1,
            this.btnSistema});
            this.barraFerramentas.Location = new System.Drawing.Point(0, 0);
            this.barraFerramentas.Name = "barraFerramentas";
            this.barraFerramentas.Size = new System.Drawing.Size(660, 75);
            this.barraFerramentas.TabIndex = 2;
            this.barraFerramentas.TabStop = true;
            this.barraFerramentas.Text = "Menu";
            // 
            // btnEndereco
            // 
            this.btnEndereco.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEndereco.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bairrosToolStripMenuItem,
            this.logradourosToolStripMenuItem});
            this.btnEndereco.Image = global::prjSystem.Properties.Resources.icone_endereco;
            this.btnEndereco.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnEndereco.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEndereco.Name = "btnEndereco";
            this.btnEndereco.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnEndereco.Size = new System.Drawing.Size(90, 72);
            this.btnEndereco.Text = "Cadastro de Endereços e Logradouros";
            this.btnEndereco.ButtonClick += new System.EventHandler(this.btnEndereco_ButtonClick);
            // 
            // bairrosToolStripMenuItem
            // 
            this.bairrosToolStripMenuItem.Name = "bairrosToolStripMenuItem";
            this.bairrosToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.bairrosToolStripMenuItem.Text = "Bairros";
            this.bairrosToolStripMenuItem.Click += new System.EventHandler(this.bairrosToolStripMenuItem_Click);
            // 
            // logradourosToolStripMenuItem
            // 
            this.logradourosToolStripMenuItem.Name = "logradourosToolStripMenuItem";
            this.logradourosToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.logradourosToolStripMenuItem.Text = "Logradouros";
            this.logradourosToolStripMenuItem.Click += new System.EventHandler(this.logradourosToolStripMenuItem_Click);
            // 
            // btnSistema
            // 
            this.btnSistema.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSistema.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuáriosToolStripMenuItem,
            this.exportarDadosToolStripMenuItem});
            this.btnSistema.Image = global::prjSystem.Properties.Resources.icone_sistema1;
            this.btnSistema.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSistema.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSistema.Name = "btnSistema";
            this.btnSistema.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnSistema.Size = new System.Drawing.Size(90, 72);
            this.btnSistema.Text = "Configurações/Cadastros do Sistema";
            // 
            // usuáriosToolStripMenuItem
            // 
            this.usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            this.usuáriosToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.usuáriosToolStripMenuItem.Text = "Usuários";
            this.usuáriosToolStripMenuItem.Click += new System.EventHandler(this.usuáriosToolStripMenuItem_Click);
            // 
            // exportarDadosToolStripMenuItem
            // 
            this.exportarDadosToolStripMenuItem.Name = "exportarDadosToolStripMenuItem";
            this.exportarDadosToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.exportarDadosToolStripMenuItem.Text = "Exportar Dados";
            this.exportarDadosToolStripMenuItem.Click += new System.EventHandler(this.exportarDadosToolStripMenuItem_Click);
            // 
            // btnProprietario
            // 
            this.btnProprietario.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnProprietario.Image = global::prjSystem.Properties.Resources.icone_pessoa;
            this.btnProprietario.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnProprietario.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnProprietario.Margin = new System.Windows.Forms.Padding(0);
            this.btnProprietario.Name = "btnProprietario";
            this.btnProprietario.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnProprietario.Size = new System.Drawing.Size(78, 75);
            this.btnProprietario.Text = "Cadastro de Cliente";
            this.btnProprietario.Click += new System.EventHandler(this.btnProprietario_Click);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButton1.Image = global::prjSystem.Properties.Resources.icone_movimentacao;
            this.toolStripSplitButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(68, 72);
            this.toolStripSplitButton1.Text = "Movimentação Financeira";
            this.toolStripSplitButton1.Click += new System.EventHandler(this.toolStripSplitButton1_Click);
            // 
            // mnCadastros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.barraFerramentas);
            this.Name = "mnCadastros";
            this.Size = new System.Drawing.Size(660, 75);
            this.barraFerramentas.ResumeLayout(false);
            this.barraFerramentas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip barraFerramentas;
        private System.Windows.Forms.ToolStripSplitButton btnEndereco;
        private System.Windows.Forms.ToolStripMenuItem bairrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logradourosToolStripMenuItem;
        private System.Windows.Forms.ToolStripSplitButton btnSistema;
        private System.Windows.Forms.ToolStripMenuItem usuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportarDadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton btnProprietario;
        private System.Windows.Forms.ToolStripButton toolStripSplitButton1;
    }
}
