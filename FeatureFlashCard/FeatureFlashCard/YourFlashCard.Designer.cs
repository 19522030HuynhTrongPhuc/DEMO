namespace FeatureFlashCard
{
	partial class YourFlashCard
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
			this.btFlashCard = new System.Windows.Forms.Button();
			this.btNext = new System.Windows.Forms.Button();
			this.btFlip = new System.Windows.Forms.Button();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// btFlashCard
			// 
			this.btFlashCard.Font = new System.Drawing.Font("SVN-Trebuchets", 22.25F);
			this.btFlashCard.Location = new System.Drawing.Point(114, 29);
			this.btFlashCard.Name = "btFlashCard";
			this.btFlashCard.Size = new System.Drawing.Size(320, 202);
			this.btFlashCard.TabIndex = 0;
			this.btFlashCard.Text = "FlashCard";
			this.btFlashCard.UseVisualStyleBackColor = true;
			this.btFlashCard.Click += new System.EventHandler(this.btFlashCard_Click);
			// 
			// btNext
			// 
			this.btNext.Location = new System.Drawing.Point(459, 122);
			this.btNext.Name = "btNext";
			this.btNext.Size = new System.Drawing.Size(59, 41);
			this.btNext.TabIndex = 1;
			this.btNext.Text = "Next";
			this.btNext.UseVisualStyleBackColor = true;
			this.btNext.Click += new System.EventHandler(this.btNext_Click);
			// 
			// btFlip
			// 
			this.btFlip.Location = new System.Drawing.Point(215, 247);
			this.btFlip.Name = "btFlip";
			this.btFlip.Size = new System.Drawing.Size(112, 23);
			this.btFlip.TabIndex = 2;
			this.btFlip.Text = "Flip";
			this.btFlip.UseVisualStyleBackColor = true;
			this.btFlip.Click += new System.EventHandler(this.btFlip_Click);
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// YourFlashCard
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(560, 282);
			this.Controls.Add(this.btFlip);
			this.Controls.Add(this.btNext);
			this.Controls.Add(this.btFlashCard);
			this.Name = "YourFlashCard";
			this.Text = "YourFlashCard";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btFlashCard;
		private System.Windows.Forms.Button btNext;
		private System.Windows.Forms.Button btFlip;
		private System.Windows.Forms.Timer timer1;
	}
}