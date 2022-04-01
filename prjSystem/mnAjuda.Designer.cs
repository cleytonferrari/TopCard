namespace prjSystem
{
    partial class mnAjuda
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
            this.btnAjuda = new System.Windows.Forms.ToolStripButton();
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
            this.btnAjuda});
            this.barraFerramentas.Location = new System.Drawing.Point(0, 0);
            this.barraFerramentas.Name = "barraFerramentas";
            this.barraFerramentas.Size = new System.Drawing.Size(660, 75);
            this.barraFerramentas.TabIndex = 3;
            this.barraFerramentas.TabStop = true;
            this.barraFerramentas.Text = "toolStrip2";
            // 
            // btnAjuda
            // 
            this.btnAjuda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAjuda.Image = global::prjSystem.Properties.Resources.icone_ajuda;
            this.btnAjuda.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAjuda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAjuda.Name = "btnAjuda";
            this.btnAjuda.Size = new System.Drawing.Size(68, 72);
            this.btnAjuda.Text = "Ajuda do Sistema";
            this.btnAjuda.Click += new System.EventHandler(this.btnAjuda_Click);
            // 
            // mnAjuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.barraFerramentas);
            this.Name = "mnAjuda";
            this.Size = new System.Drawing.Size(660, 75);
            this.barraFerramentas.ResumeLayout(false);
            this.barraFerramentas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip barraFerramentas;
        private System.Windows.Forms.ToolStripButton btnAjuda;
    }
}
