namespace prjSystem
{
    partial class mnRelatorio
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
            this.toolStripButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.bairrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimentaçãoTesteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.toolStripButton1});
            this.barraFerramentas.Location = new System.Drawing.Point(0, 0);
            this.barraFerramentas.Name = "barraFerramentas";
            this.barraFerramentas.Size = new System.Drawing.Size(660, 75);
            this.barraFerramentas.TabIndex = 4;
            this.barraFerramentas.TabStop = true;
            this.barraFerramentas.Text = "toolStrip2";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bairrosToolStripMenuItem,
            this.movimentaçãoTesteToolStripMenuItem});
            this.toolStripButton1.Image = global::prjSystem.Properties.Resources.icone_relatorio;
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(80, 72);
            this.toolStripButton1.Text = "Relatórios";
            // 
            // bairrosToolStripMenuItem
            // 
            this.bairrosToolStripMenuItem.Name = "bairrosToolStripMenuItem";
            this.bairrosToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.bairrosToolStripMenuItem.Text = "Bairros";
            this.bairrosToolStripMenuItem.Click += new System.EventHandler(this.bairrosToolStripMenuItem_Click);
            // 
            // movimentaçãoTesteToolStripMenuItem
            // 
            this.movimentaçãoTesteToolStripMenuItem.Name = "movimentaçãoTesteToolStripMenuItem";
            this.movimentaçãoTesteToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.movimentaçãoTesteToolStripMenuItem.Text = "Listagem Hierárquica";
            this.movimentaçãoTesteToolStripMenuItem.Click += new System.EventHandler(this.movimentaçãoTesteToolStripMenuItem_Click);
            // 
            // mnRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.barraFerramentas);
            this.Name = "mnRelatorio";
            this.Size = new System.Drawing.Size(660, 75);
            this.barraFerramentas.ResumeLayout(false);
            this.barraFerramentas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip barraFerramentas;
        private System.Windows.Forms.ToolStripSplitButton toolStripButton1;
        private System.Windows.Forms.ToolStripMenuItem bairrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimentaçãoTesteToolStripMenuItem;
    }
}
