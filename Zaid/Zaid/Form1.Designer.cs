namespace Zaid
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.walkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.slowerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideShowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importLocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.actionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(724, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Zaid.Properties.Resources._11;
            this.pictureBox1.Location = new System.Drawing.Point(12, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 168);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importLocationToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "file";
            // 
            // actionToolStripMenuItem
            // 
            this.actionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.walkToolStripMenuItem,
            this.hideShowToolStripMenuItem});
            this.actionToolStripMenuItem.Name = "actionToolStripMenuItem";
            this.actionToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.actionToolStripMenuItem.Text = "action";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // walkToolStripMenuItem
            // 
            this.walkToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fasterToolStripMenuItem,
            this.slowerToolStripMenuItem,
            this.stopToolStripMenuItem});
            this.walkToolStripMenuItem.Name = "walkToolStripMenuItem";
            this.walkToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.walkToolStripMenuItem.Text = "Walk";
            // 
            // fasterToolStripMenuItem
            // 
            this.fasterToolStripMenuItem.Name = "fasterToolStripMenuItem";
            this.fasterToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.fasterToolStripMenuItem.Text = "faster";
            this.fasterToolStripMenuItem.Click += new System.EventHandler(this.fasterToolStripMenuItem_Click);
            // 
            // slowerToolStripMenuItem
            // 
            this.slowerToolStripMenuItem.Name = "slowerToolStripMenuItem";
            this.slowerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.slowerToolStripMenuItem.Text = "slower";
            this.slowerToolStripMenuItem.Click += new System.EventHandler(this.slowerToolStripMenuItem_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.stopToolStripMenuItem.Text = "stop";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // hideShowToolStripMenuItem
            // 
            this.hideShowToolStripMenuItem.Name = "hideShowToolStripMenuItem";
            this.hideShowToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.hideShowToolStripMenuItem.Text = "hide/ show";
            this.hideShowToolStripMenuItem.Click += new System.EventHandler(this.hideShowToolStripMenuItem_Click);
            // 
            // importLocationToolStripMenuItem
            // 
            this.importLocationToolStripMenuItem.Name = "importLocationToolStripMenuItem";
            this.importLocationToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.importLocationToolStripMenuItem.Text = "import location";
            this.importLocationToolStripMenuItem.Click += new System.EventHandler(this.importLocationToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 545);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importLocationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem walkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem slowerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hideShowToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
    }
}

