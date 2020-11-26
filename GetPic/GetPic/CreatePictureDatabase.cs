using FeatureFlashCard;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetPic
{
	public partial class CreatePictureDatabase : Form
	{
		List<string> ls;
		sqlConnection sql = new sqlConnection();
		WebActivity w = new WebActivity();
		public CreatePictureDatabase()
		{
			InitializeComponent();
			this.btTest.Visible = false;
			this.lbTestStatus.Visible = false;
		}
		private void btGetList_Click(object sender, EventArgs e)
		{
			ls = sql.getList();
			lbStatus.Text = "Done";
		}
		private void btGetPic_Click(object sender, EventArgs e)
		{
			progressBar1.Step = (int)(100.0 / 10);
			for(int i = 0; i < 10; i++)
			{
				w.DownLoadUntil(ls[i]);
				progressBar1.PerformStep();
			}	
		}

		private void btTest_Click(object sender, EventArgs e)
		{
			w.DownLoadUntil("king");
			lbTestStatus.Text = "OK";
		}
	}
}
