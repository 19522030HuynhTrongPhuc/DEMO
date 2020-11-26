namespace Dictionary
{
	partial class MainForm
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
			this.dictionaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.databaseDictionaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.onlineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.fixDictionaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.titleVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.titleHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dictionaryToolStripMenuItem,
            this.viewToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(705, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// dictionaryToolStripMenuItem
			// 
			this.dictionaryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.databaseDictionaryToolStripMenuItem,
            this.onlineToolStripMenuItem,
            this.fixDictionaryToolStripMenuItem});
			this.dictionaryToolStripMenuItem.Name = "dictionaryToolStripMenuItem";
			this.dictionaryToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
			this.dictionaryToolStripMenuItem.Text = "Dictionary";
			// 
			// databaseDictionaryToolStripMenuItem
			// 
			this.databaseDictionaryToolStripMenuItem.Name = "databaseDictionaryToolStripMenuItem";
			this.databaseDictionaryToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.databaseDictionaryToolStripMenuItem.Text = "Database Dictionary";
			this.databaseDictionaryToolStripMenuItem.Click += new System.EventHandler(this.databaseDictionaryToolStripMenuItem_Click);
			// 
			// onlineToolStripMenuItem
			// 
			this.onlineToolStripMenuItem.Name = "onlineToolStripMenuItem";
			this.onlineToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.onlineToolStripMenuItem.Text = "Online";
			this.onlineToolStripMenuItem.Click += new System.EventHandler(this.onlineToolStripMenuItem_Click);
			// 
			// fixDictionaryToolStripMenuItem
			// 
			this.fixDictionaryToolStripMenuItem.Name = "fixDictionaryToolStripMenuItem";
			this.fixDictionaryToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.fixDictionaryToolStripMenuItem.Text = "FixDictionary";
			this.fixDictionaryToolStripMenuItem.Click += new System.EventHandler(this.fixDictionaryToolStripMenuItem_Click);
			// 
			// viewToolStripMenuItem
			// 
			this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.titleVerticalToolStripMenuItem,
            this.titleHorizontalToolStripMenuItem});
			this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
			this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.viewToolStripMenuItem.Text = "View";
			// 
			// titleVerticalToolStripMenuItem
			// 
			this.titleVerticalToolStripMenuItem.Name = "titleVerticalToolStripMenuItem";
			this.titleVerticalToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.titleVerticalToolStripMenuItem.Text = "Title Vertical";
			this.titleVerticalToolStripMenuItem.Click += new System.EventHandler(this.titleVerticalToolStripMenuItem_Click);
			// 
			// titleHorizontalToolStripMenuItem
			// 
			this.titleHorizontalToolStripMenuItem.Name = "titleHorizontalToolStripMenuItem";
			this.titleHorizontalToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.titleHorizontalToolStripMenuItem.Text = "Title Horizontal";
			this.titleHorizontalToolStripMenuItem.Click += new System.EventHandler(this.titleHorizontalToolStripMenuItem_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(705, 383);
			this.Controls.Add(this.menuStrip1);
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Text = "MainForm";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem dictionaryToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem databaseDictionaryToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem onlineToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fixDictionaryToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem titleVerticalToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem titleHorizontalToolStripMenuItem;
	}
}