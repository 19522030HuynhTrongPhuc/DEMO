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
using System.IO;
using System.Drawing.Imaging;

namespace GetPic
{
	public partial class Form1 : Form
	{
		List<string> allLink = new List<string>();
		public Form1()
		{
			InitializeComponent();
		}
		private void butGet_Click(object sender, EventArgs e)
		{
			WebClient client = new WebClient();
			//client.Encoding = Encoding.UTF8;
			client.Headers.Add(HttpRequestHeader.UserAgent, "Mozilla/5.0 (Windows NT 10.0; WOW64; rv:47.0) Gecko/20100101 Firefox/47.0");
			//client.Headers.Add(HttpRequestHeader.Cookie, webBrowser1.Document.Cookie);
			richTextBox1.Text = client.DownloadString(txtURL.Text);
			//Bắt exception ở đây
			timer1.Start();
		}
		//Compact và get pic chỉ cần 10 lần
		private void GetPic_Click(object sender, EventArgs e)
		{
			string h = richTextBox1.Text;
			string toFind = "[\"https";
			int k = h.IndexOf(toFind);
			h = h.Substring(k, h.Length - k);
			richTextBox1.Text = h;
		}
		private void butCompact_Click(object sender, EventArgs e)
		{
			string h = richTextBox1.Text;
			h = h.Substring(h.IndexOf(']') + 1, h.Length - 1 - h.IndexOf(']'));
			h = h.Substring(4, h.Length - 4);
			string link = h.Substring(0, h.IndexOf('\"'));
			richTextBox2.Text +="\n" + link;
			richTextBox1.Text = h;
		}
		private void butGetPic_Click(object sender, EventArgs e)
		{
			for(int i=0;i<10;i++)
			{
				// Tách đến link hình ảnh
				string h = richTextBox1.Text;
				string toFind = "[\"https";
				int k = h.IndexOf(toFind);
				if (k == -1)
					return;
				// Trường hợp này xảy ra khi có sensitive image
				h = h.Substring(k, h.Length - k);
				richTextBox1.Text = h;
				// Tách link thực sự
				h = richTextBox1.Text;
				h = h.Substring(h.IndexOf(']') + 1, h.Length - 1 - h.IndexOf(']'));
				h = h.Substring(4, h.Length - 4);
				string link = h.Substring(0, h.IndexOf('\"'));
				richTextBox2.Text += "\n" + link;
				allLink.Add(link);
				richTextBox1.Text = h;
			}	
		}
		public void SaveImage(string filename, string imageUrl)
		{
			WebClient client = new WebClient();
			try
			{
				Stream stream = client.OpenRead(imageUrl);
				Bitmap bitmap; 
				bitmap = new Bitmap(stream);

				if (bitmap != null)
				{
					bitmap.Save(filename, ImageFormat.Png);
				}

				stream.Flush();
				stream.Close();
				client.Dispose();
			}
			catch(Exception ex)
			{
				return;
			}
			
		}
		private void butDownLoad_Click(object sender, EventArgs e)
		{
			for(int i = 0; i< allLink.Count;i++)
			{
				SaveImage("IMG/"+ i + ".png", allLink[i]);
				this.pgbDownload.PerformStep();
			}	
		}
		private void butRender_Click(object sender, EventArgs e)
		{
			// chỉ cho tìm kiếm từ đơn
			if(txtKeyword.Text.IndexOf(" ")!=-1)
			{
				return;
			}
			string sample = "https://www.google.com.vn/search?tbm=isch&q=stringtofind&sclient=img&safe=active";
			sample = sample.Replace("stringtofind", txtKeyword.Text);
			this.txtURL.Text = sample;
		}
		private void butClear_Click(object sender, EventArgs e)
		{
			txtURL.Text = "";
			txtKeyword.Text = "";
			allLink.Clear();
			this.pgbGetSource.Value = 0;
		}
		private void timer1_Tick(object sender, EventArgs e)
		{
			this.pgbGetSource.PerformStep();
			if (pgbGetSource.Value == 100)
				timer1.Stop();
		}
	}
}
