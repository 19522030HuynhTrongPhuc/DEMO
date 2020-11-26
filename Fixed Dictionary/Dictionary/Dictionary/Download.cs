using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace Dictionary
{
	public partial class Download : Form
	{
		public Download()
		{
			InitializeComponent();
		}
		void wc_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
		{
			pgbDownload.Value = e.ProgressPercentage;
		}
		private void btDownload_Click(object sender, EventArgs e)
		{
			using (WebClient wc = new WebClient())
			{
				wc.DownloadProgressChanged += wc_DownloadProgressChanged;
				wc.DownloadFileAsync(new Uri(this.tbLink.Text), "temp.gif");
			}
			// Event to track the progress
		}
	}
}
