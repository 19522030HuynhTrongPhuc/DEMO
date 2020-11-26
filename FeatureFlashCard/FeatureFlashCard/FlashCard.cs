using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms.VisualStyles;

namespace FeatureFlashCard
{
	public partial class FlashCard : Form
	{
		public FlashCard()
		{
			InitializeComponent();
		}
		FCheckKnowLedge f;
		Learning learn;
		Statistic stastic;
		YourFlashCard yourFlashCard;
		private void HideElement()
		{
			this.btCheck.Visible = false;
			this.btLearn.Visible = false;
			this.btYourFlashCard.Visible = false;
			this.btViewAll.Visible = false;
			this.btStastics.Visible = false;
		}
		private void ShowElement()
		{
			this.btCheck.Visible = true;
			this.btLearn.Visible = true;
			this.btYourFlashCard.Visible = true;
			this.btViewAll.Visible = true;
			this.btStastics.Visible = true;
		}
		private void btCheck_Click(object sender, EventArgs e)
		{
			if (f == null)
			{
				f = new FCheckKnowLedge();
				f.MdiParent = this;
				f.FormClosed += new FormClosedEventHandler(Check_Close);
				HideElement();
				f.Show();
			}
			else f.Activate();
			f.WindowState = FormWindowState.Maximized;
		}
		private void Check_Close(object sender, FormClosedEventArgs e)
		{
			ShowElement();
			f = null;
		}
		private void RefineDatabase()
		{
			int i = 0;
			using (var newFile = File.AppendText("H:\\Refine.sql"))
			{
				foreach (var line in File.ReadLines("H:\\edict.sql"))
				{
					string updatedLine;
					if (line.IndexOf("('") != -1)
					{
						updatedLine = line.Replace("('", "(" + i + ",'");
						i++;
					}
					else updatedLine = line;
					newFile.WriteLine(updatedLine);
				}
			}
		}
		private void btLearn_Click(object sender, EventArgs e)
		{
			if (learn == null)
			{
				learn = new Learning();
				learn.MdiParent = this;
				learn.FormClosed += new FormClosedEventHandler(Learn_Close);
				HideElement();
				learn.Show();
			}
			else learn.Activate();
			learn.WindowState = FormWindowState.Maximized;
		}
		private void Learn_Close(object sender, FormClosedEventArgs e)
		{
			ShowElement();
			learn = null;
		}

		private void btYourFlashCard_Click(object sender, EventArgs e)
		{
			if (yourFlashCard == null)
			{
				yourFlashCard = new YourFlashCard();
				yourFlashCard.MdiParent = this;
				yourFlashCard.FormClosed += new FormClosedEventHandler(YourFlashCard_Close);
				HideElement();
				yourFlashCard.Show();
			}
			else yourFlashCard.Activate();
			yourFlashCard.WindowState = FormWindowState.Maximized;
		}
		private void YourFlashCard_Close(object sender, FormClosedEventArgs e)
		{
			ShowElement();
			yourFlashCard = null;
		}

		private void btStastics_Click(object sender, EventArgs e)
		{
			if (stastic == null)
			{
				stastic = new Statistic();
				stastic.MdiParent = this;
				stastic.FormClosed += new FormClosedEventHandler(Statistic_Close);
				HideElement();
				stastic.Show();
			}
			else stastic.Activate();
			stastic.WindowState = FormWindowState.Maximized;
		}
		private void Statistic_Close(object sender, FormClosedEventArgs e)
		{
			ShowElement();
			stastic = null;
		}
	}
    
}
