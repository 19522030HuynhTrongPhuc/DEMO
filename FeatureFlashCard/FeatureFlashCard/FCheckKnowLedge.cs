﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FeatureFlashCard
{
	public partial class FCheckKnowLedge : Form
	{
		int state = 0, k = 0;
		int width = 320, height = 256;
		sqlConnection sql = new sqlConnection();
		List<Word> st ;
		bool signal = true, isflipping = false;
		private void HideElement()
		{
			btFlashCard.Visible = false;
			btFlip.Visible = false;
			btKnow.Visible = false;
			btNope.Visible = false;
		}
		public FCheckKnowLedge()
		{
			InitializeComponent();
			st = sql.getWord();
			this.btFlashCard.Size = new System.Drawing.Size(width, height);
			btFlashCard.Text = st[k].eng;
		}
		private void btFlip_Click(object sender, EventArgs e)
		{
			if (isflipping == true) return;	
			timer1.Interval = 1;
			timer1.Enabled = true;
			isflipping = true;
		}
		private void btNope_Click(object sender, EventArgs e)
		{
			sql.ToLearn(st[k].id);
			if (k < 10)
			{
				k++;
			}
			else
			{
				HideElement();
				this.lbFinish.Visible = true;
			}			
			btFlashCard.Text = st[k].eng;
		}
		private void lbFinish_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		private void timer1_Tick(object sender, EventArgs e)
		{
			if (signal == true)
			{
				if (width > 0)
				{
					int x = this.btFlashCard.Location.X + 10;
					int y = this.btFlashCard.Location.Y;
					width -= 20;
					this.btFlashCard.Size = new System.Drawing.Size(width, height);
					this.btFlashCard.Location = new System.Drawing.Point(x, y);
				}
				else 
				{
					signal = false;
					if (state == 0)
					{
						state = 1;
						btFlashCard.Text = st[k].viet;
					}
					else
					{
						state = 0;
						btFlashCard.Text = st[k].eng;
					}
					
				} 
			}
			else if (signal == false)
			{
				if (width < 320)
				{
					int x = this.btFlashCard.Location.X - 10;
					int y = this.btFlashCard.Location.Y;
					width += 20;
					this.btFlashCard.Size = new System.Drawing.Size(width, height);
					this.btFlashCard.Location = new System.Drawing.Point(x, y);
				}
				else
				{
					width = 320;
					this.btFlashCard.Size = new System.Drawing.Size(width, height);
					this.btFlashCard.Location = new System.Drawing.Point(108, 10);
					signal = true;
					timer1.Enabled = false;
					isflipping = false;
				}
			}
		}
		private void btKnow_Click(object sender, EventArgs e)
		{
			sql.Learned(st[k].id);
			if (k < 10)
			{
				k++;
			}
			else
			{
				HideElement();
				this.lbFinish.Visible = true;
			}
			btFlashCard.Text = st[k].eng;
		}
		private void btFlashCard_Click(object sender, EventArgs e)
		{
			if (state == 0)
			{
				state = 1;
				btFlashCard.Text = st[k].viet;
			}
			else
			{
				state = 0;
				btFlashCard.Text = st[k].eng;
			} 
		}

	}
}
