namespace Obshepit
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dishesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ResipeStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToDStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.PrepStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductsStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.CoDStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(144)))), ((int)(((byte)(99)))));
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(642, 202);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(91)))), ((int)(((byte)(86)))));
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dishesToolStripMenuItem,
            this.ResipeStripMenuItem5,
            this.ToDStripMenuItem6,
            this.PrepStripMenuItem7,
            this.ProductsStripMenuItem8,
            this.CoDStripMenuItem9});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(169, 66);
            this.toolStripMenuItem1.Text = "Tables";
            // 
            // dishesToolStripMenuItem
            // 
            this.dishesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(151)))), ((int)(((byte)(142)))));
            this.dishesToolStripMenuItem.Name = "dishesToolStripMenuItem";
            this.dishesToolStripMenuItem.Size = new System.Drawing.Size(549, 66);
            this.dishesToolStripMenuItem.Text = "Dishes";
            this.dishesToolStripMenuItem.Click += new System.EventHandler(this.dishesToolStripMenuItem_Click);
            // 
            // ResipeStripMenuItem5
            // 
            this.ResipeStripMenuItem5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(144)))), ((int)(((byte)(99)))));
            this.ResipeStripMenuItem5.Name = "ResipeStripMenuItem5";
            this.ResipeStripMenuItem5.Size = new System.Drawing.Size(549, 66);
            this.ResipeStripMenuItem5.Text = "Recipe";
            this.ResipeStripMenuItem5.Click += new System.EventHandler(this.ResipeStripMenuItem5_Click);
            // 
            // ToDStripMenuItem6
            // 
            this.ToDStripMenuItem6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(151)))), ((int)(((byte)(142)))));
            this.ToDStripMenuItem6.Name = "ToDStripMenuItem6";
            this.ToDStripMenuItem6.Size = new System.Drawing.Size(549, 66);
            this.ToDStripMenuItem6.Text = "Types of dishes";
            this.ToDStripMenuItem6.Click += new System.EventHandler(this.ToDStripMenuItem6_Click);
            // 
            // PrepStripMenuItem7
            // 
            this.PrepStripMenuItem7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(144)))), ((int)(((byte)(99)))));
            this.PrepStripMenuItem7.Name = "PrepStripMenuItem7";
            this.PrepStripMenuItem7.Size = new System.Drawing.Size(549, 66);
            this.PrepStripMenuItem7.Text = "Preparation";
            this.PrepStripMenuItem7.Click += new System.EventHandler(this.PrepStripMenuItem7_Click);
            // 
            // ProductsStripMenuItem8
            // 
            this.ProductsStripMenuItem8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(151)))), ((int)(((byte)(142)))));
            this.ProductsStripMenuItem8.Name = "ProductsStripMenuItem8";
            this.ProductsStripMenuItem8.Size = new System.Drawing.Size(549, 66);
            this.ProductsStripMenuItem8.Text = "Products";
            this.ProductsStripMenuItem8.Click += new System.EventHandler(this.ProductsStripMenuItem8_Click);
            // 
            // CoDStripMenuItem9
            // 
            this.CoDStripMenuItem9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(144)))), ((int)(((byte)(99)))));
            this.CoDStripMenuItem9.Name = "CoDStripMenuItem9";
            this.CoDStripMenuItem9.Size = new System.Drawing.Size(549, 66);
            this.CoDStripMenuItem9.Text = "Composition of dish";
            this.CoDStripMenuItem9.Click += new System.EventHandler(this.CoDStripMenuItem9_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(91)))), ((int)(((byte)(86)))));
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(210, 66);
            this.toolStripMenuItem2.Text = "Log Out";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(91)))), ((int)(((byte)(86)))));
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(114, 66);
            this.toolStripMenuItem3.Text = "Exit";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(221, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Добро пожаловать в \"Бистро\"!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(336, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 117);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(151)))), ((int)(((byte)(142)))));
            this.ClientSize = new System.Drawing.Size(642, 217);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dishesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ResipeStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem ToDStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem PrepStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem ProductsStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem CoDStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}