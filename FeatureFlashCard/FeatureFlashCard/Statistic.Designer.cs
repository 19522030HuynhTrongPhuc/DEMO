namespace FeatureFlashCard
{
	partial class Statistic
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
			this.lbLearned = new System.Windows.Forms.Label();
			this.lbnumLearned = new System.Windows.Forms.Label();
			this.lbStatistic = new System.Windows.Forms.Label();
			this.Avatar = new System.Windows.Forms.PictureBox();
			this.lbToLearn = new System.Windows.Forms.Label();
			this.lbnumTolearn = new System.Windows.Forms.Label();
			this.lbUsername = new System.Windows.Forms.Label();
			this.lbEmail = new System.Windows.Forms.Label();
			this.lbID = new System.Windows.Forms.Label();
			this.btBack = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.Avatar)).BeginInit();
			this.SuspendLayout();
			// 
			// lbLearned
			// 
			this.lbLearned.AutoSize = true;
			this.lbLearned.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbLearned.Location = new System.Drawing.Point(9, 136);
			this.lbLearned.Name = "lbLearned";
			this.lbLearned.Size = new System.Drawing.Size(130, 22);
			this.lbLearned.TabIndex = 1;
			this.lbLearned.Text = "Learned Word";
			// 
			// lbnumLearned
			// 
			this.lbnumLearned.AutoSize = true;
			this.lbnumLearned.Location = new System.Drawing.Point(146, 143);
			this.lbnumLearned.Name = "lbnumLearned";
			this.lbnumLearned.Size = new System.Drawing.Size(0, 13);
			this.lbnumLearned.TabIndex = 2;
			// 
			// lbStatistic
			// 
			this.lbStatistic.AutoSize = true;
			this.lbStatistic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
			this.lbStatistic.ForeColor = System.Drawing.SystemColors.Desktop;
			this.lbStatistic.Location = new System.Drawing.Point(213, 19);
			this.lbStatistic.Name = "lbStatistic";
			this.lbStatistic.Size = new System.Drawing.Size(70, 20);
			this.lbStatistic.TabIndex = 3;
			this.lbStatistic.Text = "Statistic";
			// 
			// Avatar
			// 
			this.Avatar.BackgroundImage = global::FeatureFlashCard.Properties.Resources.unknown_person_icon_4;
			this.Avatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.Avatar.Location = new System.Drawing.Point(13, 48);
			this.Avatar.Name = "Avatar";
			this.Avatar.Size = new System.Drawing.Size(77, 73);
			this.Avatar.TabIndex = 0;
			this.Avatar.TabStop = false;
			// 
			// lbToLearn
			// 
			this.lbToLearn.AutoSize = true;
			this.lbToLearn.Font = new System.Drawing.Font("Consolas", 13.75F);
			this.lbToLearn.Location = new System.Drawing.Point(12, 169);
			this.lbToLearn.Name = "lbToLearn";
			this.lbToLearn.Size = new System.Drawing.Size(90, 22);
			this.lbToLearn.TabIndex = 1;
			this.lbToLearn.Text = "To Learn";
			// 
			// lbnumTolearn
			// 
			this.lbnumTolearn.AutoSize = true;
			this.lbnumTolearn.Location = new System.Drawing.Point(146, 178);
			this.lbnumTolearn.Name = "lbnumTolearn";
			this.lbnumTolearn.Size = new System.Drawing.Size(0, 13);
			this.lbnumTolearn.TabIndex = 2;
			// 
			// lbUsername
			// 
			this.lbUsername.AutoSize = true;
			this.lbUsername.Location = new System.Drawing.Point(111, 48);
			this.lbUsername.Name = "lbUsername";
			this.lbUsername.Size = new System.Drawing.Size(55, 13);
			this.lbUsername.TabIndex = 4;
			this.lbUsername.Text = "Username";
			// 
			// lbEmail
			// 
			this.lbEmail.AutoSize = true;
			this.lbEmail.Location = new System.Drawing.Point(111, 78);
			this.lbEmail.Name = "lbEmail";
			this.lbEmail.Size = new System.Drawing.Size(32, 13);
			this.lbEmail.TabIndex = 4;
			this.lbEmail.Text = "Email";
			// 
			// lbID
			// 
			this.lbID.AutoSize = true;
			this.lbID.Location = new System.Drawing.Point(111, 108);
			this.lbID.Name = "lbID";
			this.lbID.Size = new System.Drawing.Size(18, 13);
			this.lbID.TabIndex = 4;
			this.lbID.Text = "ID";
			// 
			// btBack
			// 
			this.btBack.Location = new System.Drawing.Point(487, 274);
			this.btBack.Name = "btBack";
			this.btBack.Size = new System.Drawing.Size(75, 23);
			this.btBack.TabIndex = 5;
			this.btBack.Text = "Back";
			this.btBack.UseVisualStyleBackColor = true;
			this.btBack.Click += new System.EventHandler(this.btBack_Click);
			// 
			// Statistic
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(585, 309);
			this.Controls.Add(this.btBack);
			this.Controls.Add(this.lbID);
			this.Controls.Add(this.lbEmail);
			this.Controls.Add(this.lbUsername);
			this.Controls.Add(this.lbStatistic);
			this.Controls.Add(this.lbnumTolearn);
			this.Controls.Add(this.lbnumLearned);
			this.Controls.Add(this.lbToLearn);
			this.Controls.Add(this.lbLearned);
			this.Controls.Add(this.Avatar);
			this.Name = "Statistic";
			this.Text = "Static";
			((System.ComponentModel.ISupportInitialize)(this.Avatar)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox Avatar;
		private System.Windows.Forms.Label lbLearned;
		private System.Windows.Forms.Label lbnumLearned;
		private System.Windows.Forms.Label lbStatistic;
		private System.Windows.Forms.Label lbToLearn;
		private System.Windows.Forms.Label lbnumTolearn;
		private System.Windows.Forms.Label lbUsername;
		private System.Windows.Forms.Label lbEmail;
		private System.Windows.Forms.Label lbID;
		private System.Windows.Forms.Button btBack;
	}
}