namespace hospital_management2018
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
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.اضافةبياناتالاوليةToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.اضافةبياناتاليوميةToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(188)))), ((int)(((byte)(156)))));
            this.button1.Location = new System.Drawing.Point(1044, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(308, 64);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.اضافةبياناتالاوليةToolStripMenuItem,
            this.اضافةبياناتاليوميةToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1354, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // اضافةبياناتالاوليةToolStripMenuItem
            // 
            this.اضافةبياناتالاوليةToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.اضافةبياناتالاوليةToolStripMenuItem.Name = "اضافةبياناتالاوليةToolStripMenuItem";
            this.اضافةبياناتالاوليةToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.اضافةبياناتالاوليةToolStripMenuItem.Text = "اضافة بيانات الاولية";
            // 
            // اضافةبياناتاليوميةToolStripMenuItem
            // 
            this.اضافةبياناتاليوميةToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.اضافةبياناتاليوميةToolStripMenuItem.Name = "اضافةبياناتاليوميةToolStripMenuItem";
            this.اضافةبياناتاليوميةToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.اضافةبياناتاليوميةToolStripMenuItem.Text = "اضافة بيانات اليومية";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(201)))));
            this.ClientSize = new System.Drawing.Size(1354, 692);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem اضافةبياناتالاوليةToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem اضافةبياناتاليوميةToolStripMenuItem;
    }
}