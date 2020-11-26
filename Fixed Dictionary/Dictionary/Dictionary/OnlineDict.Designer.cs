namespace Dictionary
{
	partial class OnlineDict
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
			this.btFind = new System.Windows.Forms.Button();
			this.rtbMean = new System.Windows.Forms.RichTextBox();
			this.lbDict = new System.Windows.Forms.Label();
			this.tbWord = new System.Windows.Forms.TextBox();
			this.btSpeak = new System.Windows.Forms.Button();
			this.lbPronuciation = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.btMakeFlashCard = new System.Windows.Forms.Button();
			this.pnMakeFlashCard = new System.Windows.Forms.Panel();
			this.btFlashCard = new System.Windows.Forms.Button();
			this.btChoose = new System.Windows.Forms.Button();
			this.btNext = new System.Windows.Forms.Button();
			this.lbWord = new System.Windows.Forms.Label();
			this.pnMakeFlashCard.SuspendLayout();
			this.SuspendLayout();
			// 
			// btFind
			// 
			this.btFind.Location = new System.Drawing.Point(561, 83);
			this.btFind.Name = "btFind";
			this.btFind.Size = new System.Drawing.Size(75, 23);
			this.btFind.TabIndex = 0;
			this.btFind.Text = "Find";
			this.btFind.UseVisualStyleBackColor = true;
			this.btFind.Click += new System.EventHandler(this.btFind_Click);
			// 
			// rtbMean
			// 
			this.rtbMean.Location = new System.Drawing.Point(78, 135);
			this.rtbMean.Name = "rtbMean";
			this.rtbMean.Size = new System.Drawing.Size(558, 180);
			this.rtbMean.TabIndex = 1;
			this.rtbMean.Text = "";
			// 
			// lbDict
			// 
			this.lbDict.AutoSize = true;
			this.lbDict.BackColor = System.Drawing.SystemColors.Control;
			this.lbDict.Font = new System.Drawing.Font("SVN-Trebuchets", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbDict.ForeColor = System.Drawing.Color.MidnightBlue;
			this.lbDict.Location = new System.Drawing.Point(196, 25);
			this.lbDict.Name = "lbDict";
			this.lbDict.Size = new System.Drawing.Size(263, 45);
			this.lbDict.TabIndex = 2;
			this.lbDict.Text = "Online Dictionary";
			// 
			// tbWord
			// 
			this.tbWord.Location = new System.Drawing.Point(78, 85);
			this.tbWord.Name = "tbWord";
			this.tbWord.Size = new System.Drawing.Size(477, 20);
			this.tbWord.TabIndex = 3;
			this.tbWord.TextChanged += new System.EventHandler(this.tbWord_TextChanged);
			// 
			// btSpeak
			// 
			this.btSpeak.Location = new System.Drawing.Point(561, 112);
			this.btSpeak.Name = "btSpeak";
			this.btSpeak.Size = new System.Drawing.Size(75, 23);
			this.btSpeak.TabIndex = 4;
			this.btSpeak.Text = "Speak";
			this.btSpeak.UseVisualStyleBackColor = true;
			this.btSpeak.Click += new System.EventHandler(this.btSpeak_Click);
			// 
			// lbPronuciation
			// 
			this.lbPronuciation.AutoSize = true;
			this.lbPronuciation.BackColor = System.Drawing.Color.Transparent;
			this.lbPronuciation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
			this.lbPronuciation.ForeColor = System.Drawing.Color.Black;
			this.lbPronuciation.Location = new System.Drawing.Point(74, 112);
			this.lbPronuciation.Name = "lbPronuciation";
			this.lbPronuciation.Size = new System.Drawing.Size(102, 20);
			this.lbPronuciation.TabIndex = 5;
			this.lbPronuciation.Text = "Pronuciation";
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// btMakeFlashCard
			// 
			this.btMakeFlashCard.Location = new System.Drawing.Point(5, 135);
			this.btMakeFlashCard.Name = "btMakeFlashCard";
			this.btMakeFlashCard.Size = new System.Drawing.Size(67, 39);
			this.btMakeFlashCard.TabIndex = 6;
			this.btMakeFlashCard.Text = "Make Flashcard";
			this.btMakeFlashCard.UseVisualStyleBackColor = true;
			this.btMakeFlashCard.Visible = false;
			this.btMakeFlashCard.Click += new System.EventHandler(this.btMakeFlashCard_Click);
			// 
			// pnMakeFlashCard
			// 
			this.pnMakeFlashCard.Controls.Add(this.lbWord);
			this.pnMakeFlashCard.Controls.Add(this.btNext);
			this.pnMakeFlashCard.Controls.Add(this.btChoose);
			this.pnMakeFlashCard.Controls.Add(this.btFlashCard);
			this.pnMakeFlashCard.Location = new System.Drawing.Point(5, 3);
			this.pnMakeFlashCard.Name = "pnMakeFlashCard";
			this.pnMakeFlashCard.Size = new System.Drawing.Size(160, 102);
			this.pnMakeFlashCard.TabIndex = 7;
			// 
			// btFlashCard
			// 
			this.btFlashCard.AllowDrop = true;
			this.btFlashCard.Font = new System.Drawing.Font("SVN-Avo", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btFlashCard.Location = new System.Drawing.Point(93, 72);
			this.btFlashCard.Name = "btFlashCard";
			this.btFlashCard.Size = new System.Drawing.Size(421, 164);
			this.btFlashCard.TabIndex = 0;
			this.btFlashCard.Text = "Meaning";
			this.btFlashCard.UseVisualStyleBackColor = true;
			// 
			// btChoose
			// 
			this.btChoose.Location = new System.Drawing.Point(250, 263);
			this.btChoose.Name = "btChoose";
			this.btChoose.Size = new System.Drawing.Size(75, 23);
			this.btChoose.TabIndex = 1;
			this.btChoose.Text = "Choose";
			this.btChoose.UseVisualStyleBackColor = true;
			this.btChoose.Click += new System.EventHandler(this.btChoose_Click);
			// 
			// btNext
			// 
			this.btNext.Location = new System.Drawing.Point(561, 118);
			this.btNext.Name = "btNext";
			this.btNext.Size = new System.Drawing.Size(59, 53);
			this.btNext.TabIndex = 2;
			this.btNext.Text = "Next";
			this.btNext.UseVisualStyleBackColor = true;
			this.btNext.Click += new System.EventHandler(this.btNext_Click);
			// 
			// lbWord
			// 
			this.lbWord.AutoSize = true;
			this.lbWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
			this.lbWord.Location = new System.Drawing.Point(262, 25);
			this.lbWord.Name = "lbWord";
			this.lbWord.Size = new System.Drawing.Size(63, 25);
			this.lbWord.TabIndex = 3;
			this.lbWord.Text = "Word";
			// 
			// OnlineDict
			// 
			this.AcceptButton = this.btFind;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(648, 334);
			this.Controls.Add(this.pnMakeFlashCard);
			this.Controls.Add(this.btMakeFlashCard);
			this.Controls.Add(this.lbPronuciation);
			this.Controls.Add(this.btSpeak);
			this.Controls.Add(this.tbWord);
			this.Controls.Add(this.lbDict);
			this.Controls.Add(this.rtbMean);
			this.Controls.Add(this.btFind);
			this.Name = "OnlineDict";
			this.Text = "OnlineDict";
			this.pnMakeFlashCard.ResumeLayout(false);
			this.pnMakeFlashCard.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btFind;
		private System.Windows.Forms.RichTextBox rtbMean;
		private System.Windows.Forms.Label lbDict;
		private System.Windows.Forms.TextBox tbWord;
		private System.Windows.Forms.Button btSpeak;
		private System.Windows.Forms.Label lbPronuciation;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Button btMakeFlashCard;
		private System.Windows.Forms.Panel pnMakeFlashCard;
		private System.Windows.Forms.Label lbWord;
		private System.Windows.Forms.Button btNext;
		private System.Windows.Forms.Button btChoose;
		private System.Windows.Forms.Button btFlashCard;
	}
}