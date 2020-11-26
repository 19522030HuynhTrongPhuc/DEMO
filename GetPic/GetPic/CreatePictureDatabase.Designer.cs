namespace GetPic
{
	partial class CreatePictureDatabase
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
			this.btGetList = new System.Windows.Forms.Button();
			this.btGetPic = new System.Windows.Forms.Button();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.lbStatus = new System.Windows.Forms.Label();
			this.btTest = new System.Windows.Forms.Button();
			this.lbTestStatus = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btGetList
			// 
			this.btGetList.Location = new System.Drawing.Point(21, 56);
			this.btGetList.Name = "btGetList";
			this.btGetList.Size = new System.Drawing.Size(121, 33);
			this.btGetList.TabIndex = 1;
			this.btGetList.Text = "Get List";
			this.btGetList.UseVisualStyleBackColor = true;
			this.btGetList.Click += new System.EventHandler(this.btGetList_Click);
			// 
			// btGetPic
			// 
			this.btGetPic.Location = new System.Drawing.Point(21, 108);
			this.btGetPic.Name = "btGetPic";
			this.btGetPic.Size = new System.Drawing.Size(121, 31);
			this.btGetPic.TabIndex = 1;
			this.btGetPic.Text = "Get";
			this.btGetPic.UseVisualStyleBackColor = true;
			this.btGetPic.Click += new System.EventHandler(this.btGetPic_Click);
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(148, 108);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(399, 31);
			this.progressBar1.TabIndex = 2;
			// 
			// lbStatus
			// 
			this.lbStatus.AutoSize = true;
			this.lbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
			this.lbStatus.ForeColor = System.Drawing.Color.Navy;
			this.lbStatus.Location = new System.Drawing.Point(157, 56);
			this.lbStatus.Name = "lbStatus";
			this.lbStatus.Size = new System.Drawing.Size(101, 29);
			this.lbStatus.TabIndex = 3;
			this.lbStatus.Text = "Undone";
			// 
			// btTest
			// 
			this.btTest.Location = new System.Drawing.Point(21, 159);
			this.btTest.Name = "btTest";
			this.btTest.Size = new System.Drawing.Size(121, 33);
			this.btTest.TabIndex = 4;
			this.btTest.Text = "Test";
			this.btTest.UseVisualStyleBackColor = true;
			this.btTest.Click += new System.EventHandler(this.btTest_Click);
			// 
			// lbTestStatus
			// 
			this.lbTestStatus.AutoSize = true;
			this.lbTestStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
			this.lbTestStatus.ForeColor = System.Drawing.Color.Navy;
			this.lbTestStatus.Location = new System.Drawing.Point(157, 163);
			this.lbTestStatus.Name = "lbTestStatus";
			this.lbTestStatus.Size = new System.Drawing.Size(101, 29);
			this.lbTestStatus.TabIndex = 3;
			this.lbTestStatus.Text = "Undone";
			// 
			// CreatePictureDatabase
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(559, 246);
			this.Controls.Add(this.btTest);
			this.Controls.Add(this.lbTestStatus);
			this.Controls.Add(this.lbStatus);
			this.Controls.Add(this.progressBar1);
			this.Controls.Add(this.btGetPic);
			this.Controls.Add(this.btGetList);
			this.Name = "CreatePictureDatabase";
			this.Text = "CreatePictureDatabase";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btGetList;
		private System.Windows.Forms.Button btGetPic;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.Label lbStatus;
		private System.Windows.Forms.Button btTest;
		private System.Windows.Forms.Label lbTestStatus;
	}
}