namespace Abonaţi_telefonici
{
    partial class Grafic
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
            this.incarcareDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.previzualizareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.incarcareDateToolStripMenuItem,
            this.previzualizareToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(882, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // incarcareDateToolStripMenuItem
            // 
            this.incarcareDateToolStripMenuItem.Name = "incarcareDateToolStripMenuItem";
            this.incarcareDateToolStripMenuItem.Size = new System.Drawing.Size(138, 29);
            this.incarcareDateToolStripMenuItem.Text = "Incarcare date";
            this.incarcareDateToolStripMenuItem.Click += new System.EventHandler(this.incarcareDateToolStripMenuItem_Click);
            // 
            // previzualizareToolStripMenuItem
            // 
            this.previzualizareToolStripMenuItem.Name = "previzualizareToolStripMenuItem";
            this.previzualizareToolStripMenuItem.Size = new System.Drawing.Size(133, 29);
            this.previzualizareToolStripMenuItem.Text = "Previzualizare";
            this.previzualizareToolStripMenuItem.Click += new System.EventHandler(this.previzualizareToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 33);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(882, 560);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Grafic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 593);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Grafic";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Grafic_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem incarcareDateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem previzualizareToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
    }
}