namespace FeatureFlashCard
{
	partial class Learning
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
			this.bt1 = new System.Windows.Forms.Button();
			this.bt2 = new System.Windows.Forms.Button();
			this.bt3 = new System.Windows.Forms.Button();
			this.bt4 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lbWord
			// 
			this.lbWord.AutoSize = true;
			this.lbWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbWord.Location = new System.Drawing.Point(53, 83);
			this.lbWord.Name = "lbWord";
			this.lbWord.Size = new System.Drawing.Size(107, 33);
			this.lbWord.TabIndex = 0;
			this.lbWord.Text = "WORD";
			// 
			// bt1
			// 
			this.bt1.Location = new System.Drawing.Point(48, 132);
			this.bt1.Name = "bt1";
			this.bt1.Size = new System.Drawing.Size(242, 77);
			this.bt1.TabIndex = 1;
			this.bt1.Text = "meaning  1";
			this.bt1.UseVisualStyleBackColor = true;
			// 
			// bt2
			// 
			this.bt2.Location = new System.Drawing.Point(308, 132);
			this.bt2.Name = "bt2";
			this.bt2.Size = new System.Drawing.Size(245, 77);
			this.bt2.TabIndex = 1;
			this.bt2.Text = "meaning  2";
			this.bt2.UseVisualStyleBackColor = true;
			// 
			// bt3
			// 
			this.bt3.Location = new System.Drawing.Point(48, 224);
			this.bt3.Name = "bt3";
			this.bt3.Size = new System.Drawing.Size(242, 77);
			this.bt3.TabIndex = 1;
			this.bt3.Text = "meaning  3";
			this.bt3.UseVisualStyleBackColor = true;
			// 
			// bt4
			// 
			this.bt4.Location = new System.Drawing.Point(311, 224);
			this.bt4.Name = "bt4";
			this.bt4.Size = new System.Drawing.Size(242, 77);
			this.bt4.TabIndex = 1;
			this.bt4.Text = "meaning  4";
			this.bt4.UseVisualStyleBackColor = true;
			// 
			// Learning
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::FeatureFlashCard.Properties.Resources.LearnNewWords;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(605, 325);
			this.Controls.Add(this.bt2);
			this.Controls.Add(this.bt4);
			this.Controls.Add(this.bt3);
			this.Controls.Add(this.bt1);
			this.Controls.Add(this.lbWord);
			this.DoubleBuffered = true;
			this.Name = "Learning";
			this.Text = "Learning";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lbWord;
		private System.Windows.Forms.Button bt1;
		private System.Windows.Forms.Button bt2;
		private System.Windows.Forms.Button bt3;
		private System.Windows.Forms.Button bt4;
	}
}