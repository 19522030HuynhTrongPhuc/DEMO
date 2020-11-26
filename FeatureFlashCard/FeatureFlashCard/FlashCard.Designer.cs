namespace FeatureFlashCard
{
	partial class FlashCard
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
			this.btYourFlashCard = new System.Windows.Forms.Button();
			this.btCheck = new System.Windows.Forms.Button();
			this.btLearn = new System.Windows.Forms.Button();
			this.btViewAll = new System.Windows.Forms.Button();
			this.btStastics = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btYourFlashCard
			// 
			this.btYourFlashCard.Location = new System.Drawing.Point(33, 142);
			this.btYourFlashCard.Name = "btYourFlashCard";
			this.btYourFlashCard.Size = new System.Drawing.Size(144, 103);
			this.btYourFlashCard.TabIndex = 0;
			this.btYourFlashCard.Text = "Your Own FlashCard";
			this.btYourFlashCard.UseVisualStyleBackColor = true;
			this.btYourFlashCard.Click += new System.EventHandler(this.btYourFlashCard_Click);
			// 
			// btCheck
			// 
			this.btCheck.Location = new System.Drawing.Point(214, 142);
			this.btCheck.Name = "btCheck";
			this.btCheck.Size = new System.Drawing.Size(144, 103);
			this.btCheck.TabIndex = 0;
			this.btCheck.Text = "Check your Knowledge";
			this.btCheck.UseVisualStyleBackColor = true;
			this.btCheck.Click += new System.EventHandler(this.btCheck_Click);
			// 
			// btLearn
			// 
			this.btLearn.Location = new System.Drawing.Point(399, 142);
			this.btLearn.Name = "btLearn";
			this.btLearn.Size = new System.Drawing.Size(144, 103);
			this.btLearn.TabIndex = 0;
			this.btLearn.Text = "Learning";
			this.btLearn.UseVisualStyleBackColor = true;
			this.btLearn.Click += new System.EventHandler(this.btLearn_Click);
			// 
			// btViewAll
			// 
			this.btViewAll.Location = new System.Drawing.Point(464, 306);
			this.btViewAll.Name = "btViewAll";
			this.btViewAll.Size = new System.Drawing.Size(101, 24);
			this.btViewAll.TabIndex = 1;
			this.btViewAll.Text = "View AllFlashCard";
			this.btViewAll.UseVisualStyleBackColor = true;
			// 
			// btStastics
			// 
			this.btStastics.Location = new System.Drawing.Point(12, 307);
			this.btStastics.Name = "btStastics";
			this.btStastics.Size = new System.Drawing.Size(75, 23);
			this.btStastics.TabIndex = 3;
			this.btStastics.Text = "Statistics";
			this.btStastics.UseVisualStyleBackColor = true;
			this.btStastics.Click += new System.EventHandler(this.btStastics_Click);
			// 
			// FlashCard
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::FeatureFlashCard.Properties.Resources.Revision_Background__2_;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(577, 341);
			this.Controls.Add(this.btStastics);
			this.Controls.Add(this.btViewAll);
			this.Controls.Add(this.btLearn);
			this.Controls.Add(this.btCheck);
			this.Controls.Add(this.btYourFlashCard);
			this.IsMdiContainer = true;
			this.Name = "FlashCard";
			this.Text = "Flash Card";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btYourFlashCard;
		private System.Windows.Forms.Button btCheck;
		private System.Windows.Forms.Button btLearn;
		private System.Windows.Forms.Button btViewAll;
		private System.Windows.Forms.Button btStastics;
	}
}

