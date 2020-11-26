namespace GetPic
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
			this.txtURL = new System.Windows.Forms.TextBox();
			this.butGet = new System.Windows.Forms.Button();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.richTextBox2 = new System.Windows.Forms.RichTextBox();
			this.butGetPic = new System.Windows.Forms.Button();
			this.butDownLoad = new System.Windows.Forms.Button();
			this.txtKeyword = new System.Windows.Forms.TextBox();
			this.butRender = new System.Windows.Forms.Button();
			this.butClear = new System.Windows.Forms.Button();
			this.pgbGetSource = new System.Windows.Forms.ProgressBar();
			this.lbGetSource = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.lbDown = new System.Windows.Forms.Label();
			this.pgbDownload = new System.Windows.Forms.ProgressBar();
			this.SuspendLayout();
			// 
			// txtURL
			// 
			this.txtURL.Location = new System.Drawing.Point(12, 44);
			this.txtURL.Name = "txtURL";
			this.txtURL.Size = new System.Drawing.Size(607, 20);
			this.txtURL.TabIndex = 0;
			// 
			// butGet
			// 
			this.butGet.Location = new System.Drawing.Point(12, 374);
			this.butGet.Name = "butGet";
			this.butGet.Size = new System.Drawing.Size(105, 26);
			this.butGet.TabIndex = 1;
			this.butGet.Text = "GetSource";
			this.butGet.UseVisualStyleBackColor = true;
			this.butGet.Click += new System.EventHandler(this.butGet_Click);
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(12, 70);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(607, 203);
			this.richTextBox1.TabIndex = 3;
			this.richTextBox1.Text = "";
			// 
			// richTextBox2
			// 
			this.richTextBox2.Location = new System.Drawing.Point(12, 281);
			this.richTextBox2.Name = "richTextBox2";
			this.richTextBox2.Size = new System.Drawing.Size(609, 80);
			this.richTextBox2.TabIndex = 5;
			this.richTextBox2.Text = "";
			// 
			// butGetPic
			// 
			this.butGetPic.Location = new System.Drawing.Point(289, 374);
			this.butGetPic.Name = "butGetPic";
			this.butGetPic.Size = new System.Drawing.Size(141, 26);
			this.butGetPic.TabIndex = 6;
			this.butGetPic.Text = "Get 10 links";
			this.butGetPic.UseVisualStyleBackColor = true;
			this.butGetPic.Click += new System.EventHandler(this.butGetPic_Click);
			// 
			// butDownLoad
			// 
			this.butDownLoad.Location = new System.Drawing.Point(159, 374);
			this.butDownLoad.Name = "butDownLoad";
			this.butDownLoad.Size = new System.Drawing.Size(106, 26);
			this.butDownLoad.TabIndex = 7;
			this.butDownLoad.Text = "DownLoad";
			this.butDownLoad.UseVisualStyleBackColor = true;
			this.butDownLoad.Click += new System.EventHandler(this.butDownLoad_Click);
			// 
			// txtKeyword
			// 
			this.txtKeyword.Location = new System.Drawing.Point(12, 15);
			this.txtKeyword.Name = "txtKeyword";
			this.txtKeyword.Size = new System.Drawing.Size(406, 20);
			this.txtKeyword.TabIndex = 8;
			// 
			// butRender
			// 
			this.butRender.Location = new System.Drawing.Point(443, 10);
			this.butRender.Name = "butRender";
			this.butRender.Size = new System.Drawing.Size(175, 28);
			this.butRender.TabIndex = 9;
			this.butRender.Text = "Render Link";
			this.butRender.UseVisualStyleBackColor = true;
			this.butRender.Click += new System.EventHandler(this.butRender_Click);
			// 
			// butClear
			// 
			this.butClear.Location = new System.Drawing.Point(455, 374);
			this.butClear.Name = "butClear";
			this.butClear.Size = new System.Drawing.Size(147, 26);
			this.butClear.TabIndex = 10;
			this.butClear.Text = "Clear";
			this.butClear.UseVisualStyleBackColor = true;
			this.butClear.Click += new System.EventHandler(this.butClear_Click);
			// 
			// pgbGetSource
			// 
			this.pgbGetSource.Location = new System.Drawing.Point(82, 406);
			this.pgbGetSource.Name = "pgbGetSource";
			this.pgbGetSource.Size = new System.Drawing.Size(520, 18);
			this.pgbGetSource.Step = 5;
			this.pgbGetSource.TabIndex = 11;
			// 
			// lbGetSource
			// 
			this.lbGetSource.AutoSize = true;
			this.lbGetSource.Location = new System.Drawing.Point(15, 406);
			this.lbGetSource.Name = "lbGetSource";
			this.lbGetSource.Size = new System.Drawing.Size(61, 13);
			this.lbGetSource.TabIndex = 12;
			this.lbGetSource.Text = "Get Source";
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// lbDown
			// 
			this.lbDown.AutoSize = true;
			this.lbDown.Location = new System.Drawing.Point(15, 439);
			this.lbDown.Name = "lbDown";
			this.lbDown.Size = new System.Drawing.Size(55, 13);
			this.lbDown.TabIndex = 13;
			this.lbDown.Text = "Download";
			// 
			// pgbDownload
			// 
			this.pgbDownload.Location = new System.Drawing.Point(82, 439);
			this.pgbDownload.Name = "pgbDownload";
			this.pgbDownload.Size = new System.Drawing.Size(517, 21);
			this.pgbDownload.TabIndex = 14;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(627, 472);
			this.Controls.Add(this.pgbDownload);
			this.Controls.Add(this.lbDown);
			this.Controls.Add(this.lbGetSource);
			this.Controls.Add(this.pgbGetSource);
			this.Controls.Add(this.butClear);
			this.Controls.Add(this.butRender);
			this.Controls.Add(this.txtKeyword);
			this.Controls.Add(this.butDownLoad);
			this.Controls.Add(this.butGetPic);
			this.Controls.Add(this.richTextBox2);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.butGet);
			this.Controls.Add(this.txtURL);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtURL;
		private System.Windows.Forms.Button butGet;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.RichTextBox richTextBox2;
		private System.Windows.Forms.Button butGetPic;
		private System.Windows.Forms.Button butDownLoad;
		private System.Windows.Forms.TextBox txtKeyword;
		private System.Windows.Forms.Button butRender;
		private System.Windows.Forms.Button butClear;
		private System.Windows.Forms.ProgressBar pgbGetSource;
		private System.Windows.Forms.Label lbGetSource;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label lbDown;
		private System.Windows.Forms.ProgressBar pgbDownload;
	}
}

