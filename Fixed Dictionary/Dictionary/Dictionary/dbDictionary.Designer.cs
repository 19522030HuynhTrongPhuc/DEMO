namespace Dictionary
{
	partial class dbDictionary
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
			this.rtbMean = new System.Windows.Forms.RichTextBox();
			this.lbDict = new System.Windows.Forms.Label();
			this.btFind = new System.Windows.Forms.Button();
			this.tbWord = new System.Windows.Forms.ComboBox();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// rtbMean
			// 
			this.rtbMean.Location = new System.Drawing.Point(40, 106);
			this.rtbMean.Name = "rtbMean";
			this.rtbMean.Size = new System.Drawing.Size(648, 172);
			this.rtbMean.TabIndex = 1;
			this.rtbMean.Text = "";
			// 
			// lbDict
			// 
			this.lbDict.AutoSize = true;
			this.lbDict.Font = new System.Drawing.Font("SVN-Neogrey", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbDict.Location = new System.Drawing.Point(241, 18);
			this.lbDict.Name = "lbDict";
			this.lbDict.Size = new System.Drawing.Size(263, 49);
			this.lbDict.TabIndex = 3;
			this.lbDict.Text = "DICTIONARY";
			// 
			// btFind
			// 
			this.btFind.Location = new System.Drawing.Point(639, 69);
			this.btFind.Name = "btFind";
			this.btFind.Size = new System.Drawing.Size(49, 31);
			this.btFind.TabIndex = 4;
			this.btFind.Text = "Find";
			this.btFind.UseVisualStyleBackColor = true;
			this.btFind.Click += new System.EventHandler(this.btFind_Click);
			// 
			// tbWord
			// 
			this.tbWord.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.tbWord.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.tbWord.FormattingEnabled = true;
			this.tbWord.Location = new System.Drawing.Point(40, 75);
			this.tbWord.Name = "tbWord";
			this.tbWord.Size = new System.Drawing.Size(593, 21);
			this.tbWord.TabIndex = 5;
			this.tbWord.TextChanged += new System.EventHandler(this.tbWord_TextChanged);
			this.tbWord.Enter += new System.EventHandler(this.tbWord_Enter);
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// dbDictionary
			// 
			this.AcceptButton = this.btFind;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(722, 301);
			this.Controls.Add(this.tbWord);
			this.Controls.Add(this.btFind);
			this.Controls.Add(this.lbDict);
			this.Controls.Add(this.rtbMean);
			this.Name = "dbDictionary";
			this.Text = "dbDictionary";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RichTextBox rtbMean;
		private System.Windows.Forms.Label lbDict;
		private System.Windows.Forms.Button btFind;
		private System.Windows.Forms.ComboBox tbWord;
		private System.Windows.Forms.Timer timer1;
	}
}