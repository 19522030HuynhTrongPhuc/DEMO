namespace FeatureFlashCard
{
	partial class FCheckKnowLedge
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
			this.btNope = new System.Windows.Forms.Button();
			this.btKnow = new System.Windows.Forms.Button();
			this.btFlip = new System.Windows.Forms.Button();
			this.btFlashCard = new System.Windows.Forms.Button();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.lbFinish = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btNope
			// 
			this.btNope.Location = new System.Drawing.Point(15, 67);
			this.btNope.Name = "btNope";
			this.btNope.Size = new System.Drawing.Size(75, 174);
			this.btNope.TabIndex = 1;
			this.btNope.Text = "Nope !!!";
			this.btNope.UseVisualStyleBackColor = true;
			this.btNope.Click += new System.EventHandler(this.btNope_Click);
			// 
			// btKnow
			// 
			this.btKnow.Location = new System.Drawing.Point(450, 67);
			this.btKnow.Name = "btKnow";
			this.btKnow.Size = new System.Drawing.Size(75, 174);
			this.btKnow.TabIndex = 1;
			this.btKnow.Text = "Know it ??";
			this.btKnow.UseVisualStyleBackColor = true;
			this.btKnow.Click += new System.EventHandler(this.btKnow_Click);
			// 
			// btFlip
			// 
			this.btFlip.Location = new System.Drawing.Point(108, 272);
			this.btFlip.Name = "btFlip";
			this.btFlip.Size = new System.Drawing.Size(320, 35);
			this.btFlip.TabIndex = 2;
			this.btFlip.Text = "Flip";
			this.btFlip.UseVisualStyleBackColor = true;
			this.btFlip.Click += new System.EventHandler(this.btFlip_Click);
			// 
			// btFlashCard
			// 
			this.btFlashCard.Font = new System.Drawing.Font("Consolas", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
			this.btFlashCard.Location = new System.Drawing.Point(108, 10);
			this.btFlashCard.Name = "btFlashCard";
			this.btFlashCard.Size = new System.Drawing.Size(320, 256);
			this.btFlashCard.TabIndex = 3;
			this.btFlashCard.UseVisualStyleBackColor = true;
			this.btFlashCard.Click += new System.EventHandler(this.btFlashCard_Click);
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// lbFinish
			// 
			this.lbFinish.AllowDrop = true;
			this.lbFinish.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.lbFinish.AutoSize = true;
			this.lbFinish.Cursor = System.Windows.Forms.Cursors.Default;
			this.lbFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
			this.lbFinish.Location = new System.Drawing.Point(11, 145);
			this.lbFinish.Name = "lbFinish";
			this.lbFinish.Size = new System.Drawing.Size(523, 17);
			this.lbFinish.TabIndex = 4;
			this.lbFinish.Text = "You haved finished check your knowledge go to learn to learn your unknown word";
			this.lbFinish.Visible = false;
			this.lbFinish.Click += new System.EventHandler(this.lbFinish_Click);
			// 
			// FCheckKnowLedge
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(546, 310);
			this.Controls.Add(this.lbFinish);
			this.Controls.Add(this.btFlashCard);
			this.Controls.Add(this.btFlip);
			this.Controls.Add(this.btKnow);
			this.Controls.Add(this.btNope);
			this.Name = "FCheckKnowLedge";
			this.Text = "FCheckKnowLedge";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btNope;
		private System.Windows.Forms.Button btKnow;
		private System.Windows.Forms.Button btFlip;
		private System.Windows.Forms.Button btFlashCard;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label lbFinish;
	}
}