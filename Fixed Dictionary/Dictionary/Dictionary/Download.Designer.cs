namespace Dictionary
{
	partial class Download
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
			this.tbLink = new System.Windows.Forms.TextBox();
			this.btDownload = new System.Windows.Forms.Button();
			this.pgbDownload = new System.Windows.Forms.ProgressBar();
			this.SuspendLayout();
			// 
			// tbLink
			// 
			this.tbLink.Location = new System.Drawing.Point(93, 28);
			this.tbLink.Name = "tbLink";
			this.tbLink.Size = new System.Drawing.Size(547, 20);
			this.tbLink.TabIndex = 0;
			// 
			// btDownload
			// 
			this.btDownload.Location = new System.Drawing.Point(12, 28);
			this.btDownload.Name = "btDownload";
			this.btDownload.Size = new System.Drawing.Size(75, 23);
			this.btDownload.TabIndex = 1;
			this.btDownload.Text = "Download";
			this.btDownload.UseVisualStyleBackColor = true;
			this.btDownload.Click += new System.EventHandler(this.btDownload_Click);
			// 
			// pgbDownload
			// 
			this.pgbDownload.Location = new System.Drawing.Point(12, 57);
			this.pgbDownload.Name = "pgbDownload";
			this.pgbDownload.Size = new System.Drawing.Size(628, 23);
			this.pgbDownload.TabIndex = 2;
			// 
			// Download
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(650, 286);
			this.Controls.Add(this.pgbDownload);
			this.Controls.Add(this.btDownload);
			this.Controls.Add(this.tbLink);
			this.Name = "Download";
			this.Text = "Download";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tbLink;
		private System.Windows.Forms.Button btDownload;
		private System.Windows.Forms.ProgressBar pgbDownload;
	}
}