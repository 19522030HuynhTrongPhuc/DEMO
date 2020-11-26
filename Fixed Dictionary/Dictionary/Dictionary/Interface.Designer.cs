namespace Dictionary
{
	partial class Interface
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
			this.lbWord = new System.Windows.Forms.Label();
			this.tbWord = new System.Windows.Forms.TextBox();
			this.tbLink = new System.Windows.Forms.TextBox();
			this.btFind = new System.Windows.Forms.Button();
			this.lbLink = new System.Windows.Forms.Label();
			this.rtbSource = new System.Windows.Forms.RichTextBox();
			this.btGetLink = new System.Windows.Forms.Button();
			this.btGetAudio = new System.Windows.Forms.Button();
			this.btAudioPlay = new System.Windows.Forms.Button();
			this.tbAudioLink = new System.Windows.Forms.TextBox();
			this.pgbGetAudio = new System.Windows.Forms.ProgressBar();
			this.btStop = new System.Windows.Forms.Button();
			this.rtbMeaning = new System.Windows.Forms.RichTextBox();
			this.btGetMeaning = new System.Windows.Forms.Button();
			this.lbPronuciation = new System.Windows.Forms.Label();
			this.tbPronunciation = new System.Windows.Forms.TextBox();
			this.getAllMean = new System.Windows.Forms.Button();
			this.btClear = new System.Windows.Forms.Button();
			this.lbDefaultWordFormat = new System.Windows.Forms.Label();
			this.tbdfformat = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// lbWord
			// 
			this.lbWord.AutoSize = true;
			this.lbWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
			this.lbWord.Location = new System.Drawing.Point(6, 9);
			this.lbWord.Name = "lbWord";
			this.lbWord.Size = new System.Drawing.Size(45, 18);
			this.lbWord.TabIndex = 0;
			this.lbWord.Text = "Word";
			// 
			// tbWord
			// 
			this.tbWord.Location = new System.Drawing.Point(63, 9);
			this.tbWord.Name = "tbWord";
			this.tbWord.Size = new System.Drawing.Size(178, 20);
			this.tbWord.TabIndex = 1;
			// 
			// tbLink
			// 
			this.tbLink.Location = new System.Drawing.Point(394, 12);
			this.tbLink.Name = "tbLink";
			this.tbLink.Size = new System.Drawing.Size(362, 20);
			this.tbLink.TabIndex = 2;
			// 
			// btFind
			// 
			this.btFind.Location = new System.Drawing.Point(247, 8);
			this.btFind.Name = "btFind";
			this.btFind.Size = new System.Drawing.Size(75, 23);
			this.btFind.TabIndex = 3;
			this.btFind.Text = "Find";
			this.btFind.UseVisualStyleBackColor = true;
			this.btFind.Click += new System.EventHandler(this.btFind_Click);
			// 
			// lbLink
			// 
			this.lbLink.AutoSize = true;
			this.lbLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
			this.lbLink.Location = new System.Drawing.Point(346, 14);
			this.lbLink.Name = "lbLink";
			this.lbLink.Size = new System.Drawing.Size(35, 18);
			this.lbLink.TabIndex = 0;
			this.lbLink.Text = "Link";
			// 
			// rtbSource
			// 
			this.rtbSource.Location = new System.Drawing.Point(12, 35);
			this.rtbSource.Name = "rtbSource";
			this.rtbSource.Size = new System.Drawing.Size(331, 282);
			this.rtbSource.TabIndex = 4;
			this.rtbSource.Text = "";
			// 
			// btGetLink
			// 
			this.btGetLink.Location = new System.Drawing.Point(349, 47);
			this.btGetLink.Name = "btGetLink";
			this.btGetLink.Size = new System.Drawing.Size(75, 23);
			this.btGetLink.TabIndex = 3;
			this.btGetLink.Text = "Get Link";
			this.btGetLink.UseVisualStyleBackColor = true;
			this.btGetLink.Click += new System.EventHandler(this.btGetLink_Click);
			// 
			// btGetAudio
			// 
			this.btGetAudio.Location = new System.Drawing.Point(349, 76);
			this.btGetAudio.Name = "btGetAudio";
			this.btGetAudio.Size = new System.Drawing.Size(75, 23);
			this.btGetAudio.TabIndex = 3;
			this.btGetAudio.Text = "Get Audio";
			this.btGetAudio.UseVisualStyleBackColor = true;
			this.btGetAudio.Click += new System.EventHandler(this.btGetAudio_Click);
			// 
			// btAudioPlay
			// 
			this.btAudioPlay.Location = new System.Drawing.Point(349, 105);
			this.btAudioPlay.Name = "btAudioPlay";
			this.btAudioPlay.Size = new System.Drawing.Size(75, 23);
			this.btAudioPlay.TabIndex = 3;
			this.btAudioPlay.Text = "Play Audio";
			this.btAudioPlay.UseVisualStyleBackColor = true;
			this.btAudioPlay.Click += new System.EventHandler(this.btAudioPlay_Click);
			// 
			// tbAudioLink
			// 
			this.tbAudioLink.Location = new System.Drawing.Point(430, 47);
			this.tbAudioLink.Name = "tbAudioLink";
			this.tbAudioLink.Size = new System.Drawing.Size(326, 20);
			this.tbAudioLink.TabIndex = 2;
			// 
			// pgbGetAudio
			// 
			this.pgbGetAudio.Location = new System.Drawing.Point(430, 79);
			this.pgbGetAudio.Name = "pgbGetAudio";
			this.pgbGetAudio.Size = new System.Drawing.Size(325, 19);
			this.pgbGetAudio.TabIndex = 5;
			// 
			// btStop
			// 
			this.btStop.Location = new System.Drawing.Point(430, 105);
			this.btStop.Name = "btStop";
			this.btStop.Size = new System.Drawing.Size(75, 23);
			this.btStop.TabIndex = 3;
			this.btStop.Text = "Stop Audio";
			this.btStop.UseVisualStyleBackColor = true;
			this.btStop.Click += new System.EventHandler(this.btStop_Click);
			// 
			// rtbMeaning
			// 
			this.rtbMeaning.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rtbMeaning.Location = new System.Drawing.Point(351, 165);
			this.rtbMeaning.Name = "rtbMeaning";
			this.rtbMeaning.Size = new System.Drawing.Size(404, 220);
			this.rtbMeaning.TabIndex = 6;
			this.rtbMeaning.Text = "";
			// 
			// btGetMeaning
			// 
			this.btGetMeaning.Location = new System.Drawing.Point(351, 136);
			this.btGetMeaning.Name = "btGetMeaning";
			this.btGetMeaning.Size = new System.Drawing.Size(91, 23);
			this.btGetMeaning.TabIndex = 7;
			this.btGetMeaning.Text = "Get Meaning";
			this.btGetMeaning.UseVisualStyleBackColor = true;
			this.btGetMeaning.Click += new System.EventHandler(this.btGetMeaning_Click);
			// 
			// lbPronuciation
			// 
			this.lbPronuciation.AutoSize = true;
			this.lbPronuciation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbPronuciation.Location = new System.Drawing.Point(16, 365);
			this.lbPronuciation.Name = "lbPronuciation";
			this.lbPronuciation.Size = new System.Drawing.Size(91, 18);
			this.lbPronuciation.TabIndex = 8;
			this.lbPronuciation.Text = "Pronuciation";
			// 
			// tbPronunciation
			// 
			this.tbPronunciation.ForeColor = System.Drawing.Color.ForestGreen;
			this.tbPronunciation.Location = new System.Drawing.Point(113, 366);
			this.tbPronunciation.Name = "tbPronunciation";
			this.tbPronunciation.Size = new System.Drawing.Size(230, 20);
			this.tbPronunciation.TabIndex = 9;
			// 
			// getAllMean
			// 
			this.getAllMean.Location = new System.Drawing.Point(448, 136);
			this.getAllMean.Name = "getAllMean";
			this.getAllMean.Size = new System.Drawing.Size(121, 23);
			this.getAllMean.TabIndex = 10;
			this.getAllMean.Text = "Get All Means";
			this.getAllMean.UseVisualStyleBackColor = true;
			this.getAllMean.Click += new System.EventHandler(this.getAllMean_Click);
			// 
			// btClear
			// 
			this.btClear.Location = new System.Drawing.Point(589, 136);
			this.btClear.Name = "btClear";
			this.btClear.Size = new System.Drawing.Size(108, 24);
			this.btClear.TabIndex = 11;
			this.btClear.Text = "Clear";
			this.btClear.UseVisualStyleBackColor = true;
			this.btClear.Click += new System.EventHandler(this.btClear_Click);
			// 
			// lbDefaultWordFormat
			// 
			this.lbDefaultWordFormat.AutoSize = true;
			this.lbDefaultWordFormat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbDefaultWordFormat.Location = new System.Drawing.Point(16, 348);
			this.lbDefaultWordFormat.Name = "lbDefaultWordFormat";
			this.lbDefaultWordFormat.Size = new System.Drawing.Size(90, 16);
			this.lbDefaultWordFormat.TabIndex = 12;
			this.lbDefaultWordFormat.Text = "Default format";
			// 
			// tbdfformat
			// 
			this.tbdfformat.Location = new System.Drawing.Point(113, 344);
			this.tbdfformat.Name = "tbdfformat";
			this.tbdfformat.Size = new System.Drawing.Size(229, 20);
			this.tbdfformat.TabIndex = 13;
			// 
			// Interface
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(768, 397);
			this.Controls.Add(this.tbdfformat);
			this.Controls.Add(this.lbDefaultWordFormat);
			this.Controls.Add(this.btClear);
			this.Controls.Add(this.getAllMean);
			this.Controls.Add(this.tbPronunciation);
			this.Controls.Add(this.lbPronuciation);
			this.Controls.Add(this.btGetMeaning);
			this.Controls.Add(this.rtbMeaning);
			this.Controls.Add(this.pgbGetAudio);
			this.Controls.Add(this.rtbSource);
			this.Controls.Add(this.btStop);
			this.Controls.Add(this.btAudioPlay);
			this.Controls.Add(this.btGetAudio);
			this.Controls.Add(this.btGetLink);
			this.Controls.Add(this.btFind);
			this.Controls.Add(this.tbAudioLink);
			this.Controls.Add(this.tbLink);
			this.Controls.Add(this.tbWord);
			this.Controls.Add(this.lbLink);
			this.Controls.Add(this.lbWord);
			this.Name = "Interface";
			this.Text = "Dictionary";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbWord;
		private System.Windows.Forms.TextBox tbWord;
		private System.Windows.Forms.TextBox tbLink;
		private System.Windows.Forms.Button btFind;
		private System.Windows.Forms.Label lbLink;
		private System.Windows.Forms.RichTextBox rtbSource;
		private System.Windows.Forms.Button btGetLink;
		private System.Windows.Forms.Button btGetAudio;
		private System.Windows.Forms.Button btAudioPlay;
		private System.Windows.Forms.TextBox tbAudioLink;
		private System.Windows.Forms.ProgressBar pgbGetAudio;
		private System.Windows.Forms.Button btStop;
		private System.Windows.Forms.RichTextBox rtbMeaning;
		private System.Windows.Forms.Button btGetMeaning;
		private System.Windows.Forms.Label lbPronuciation;
		private System.Windows.Forms.TextBox tbPronunciation;
		private System.Windows.Forms.Button getAllMean;
		private System.Windows.Forms.Button btClear;
		private System.Windows.Forms.Label lbDefaultWordFormat;
		private System.Windows.Forms.TextBox tbdfformat;
	}
}

