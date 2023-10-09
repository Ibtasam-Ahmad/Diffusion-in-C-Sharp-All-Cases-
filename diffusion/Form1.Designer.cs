namespace diffusion
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.diffusionsimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dclassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dthroughrandomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dwithclassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ddirecclassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cube = new System.Windows.Forms.TextBox();
            this.entropyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entropywithclassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.diffusionsimToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(893, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // diffusionsimToolStripMenuItem
            // 
            this.diffusionsimToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dToolStripMenuItem,
            this.dclassToolStripMenuItem,
            this.dthroughrandomToolStripMenuItem,
            this.dwithclassToolStripMenuItem,
            this.ddirecclassToolStripMenuItem,
            this.entropyToolStripMenuItem,
            this.entropywithclassToolStripMenuItem});
            this.diffusionsimToolStripMenuItem.Name = "diffusionsimToolStripMenuItem";
            this.diffusionsimToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.diffusionsimToolStripMenuItem.Text = "diffusion_sim";
            // 
            // dToolStripMenuItem
            // 
            this.dToolStripMenuItem.Name = "dToolStripMenuItem";
            this.dToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.dToolStripMenuItem.Text = "1d";
            this.dToolStripMenuItem.Click += new System.EventHandler(this.dToolStripMenuItem_Click);
            // 
            // dclassToolStripMenuItem
            // 
            this.dclassToolStripMenuItem.Name = "dclassToolStripMenuItem";
            this.dclassToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.dclassToolStripMenuItem.Text = "1d_class";
            this.dclassToolStripMenuItem.Click += new System.EventHandler(this.dclassToolStripMenuItem_Click);
            // 
            // dthroughrandomToolStripMenuItem
            // 
            this.dthroughrandomToolStripMenuItem.Name = "dthroughrandomToolStripMenuItem";
            this.dthroughrandomToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.dthroughrandomToolStripMenuItem.Text = "2d_through_random";
            this.dthroughrandomToolStripMenuItem.Click += new System.EventHandler(this.dthroughrandomToolStripMenuItem_Click);
            // 
            // dwithclassToolStripMenuItem
            // 
            this.dwithclassToolStripMenuItem.Name = "dwithclassToolStripMenuItem";
            this.dwithclassToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.dwithclassToolStripMenuItem.Text = "2d-withclass";
            this.dwithclassToolStripMenuItem.Click += new System.EventHandler(this.dwithclassToolStripMenuItem_Click);
            // 
            // ddirecclassToolStripMenuItem
            // 
            this.ddirecclassToolStripMenuItem.Name = "ddirecclassToolStripMenuItem";
            this.ddirecclassToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.ddirecclassToolStripMenuItem.Text = "2d_direc_class";
            this.ddirecclassToolStripMenuItem.Click += new System.EventHandler(this.ddirecclassToolStripMenuItem_Click);
            // 
            // cube
            // 
            this.cube.BackColor = System.Drawing.SystemColors.MenuText;
            this.cube.Location = new System.Drawing.Point(673, 27);
            this.cube.Multiline = true;
            this.cube.Name = "cube";
            this.cube.Size = new System.Drawing.Size(195, 187);
            this.cube.TabIndex = 1;
            // 
            // entropyToolStripMenuItem
            // 
            this.entropyToolStripMenuItem.Name = "entropyToolStripMenuItem";
            this.entropyToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.entropyToolStripMenuItem.Text = "Entropy";
            this.entropyToolStripMenuItem.Click += new System.EventHandler(this.entropyToolStripMenuItem_Click);
            // 
            // entropywithclassToolStripMenuItem
            // 
            this.entropywithclassToolStripMenuItem.Name = "entropywithclassToolStripMenuItem";
            this.entropywithclassToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.entropywithclassToolStripMenuItem.Text = "Entropy_withclass";
            this.entropywithclassToolStripMenuItem.Click += new System.EventHandler(this.entropywithclassToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 541);
            this.Controls.Add(this.cube);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem diffusionsimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dclassToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dthroughrandomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dwithclassToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ddirecclassToolStripMenuItem;
        public System.Windows.Forms.TextBox cube;
        private System.Windows.Forms.ToolStripMenuItem entropyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entropywithclassToolStripMenuItem;
    }
}

