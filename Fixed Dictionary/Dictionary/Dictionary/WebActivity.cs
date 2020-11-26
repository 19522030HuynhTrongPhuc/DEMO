using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Windows.Forms;
using System.IO;
using System.CodeDom.Compiler;

namespace Dictionary
{
	class WebActivity
	{
		public string getSource(string link)
		{
			WebClient client = new WebClient();
			client.Encoding = Encoding.UTF8;
			client.Headers.Add(HttpRequestHeader.UserAgent, "Mozilla/5.0 (Windows NT 10.0; WOW64; rv:47.0) Gecko/20100101 Firefox/47.0");
			string res = "";
			try
			{
				res=client.DownloadString(link);
			}
			catch(Exception ex)
			{

			}
			return res;
		}
		public void getAudio(string linkaudio,ProgressBar pgb)
		{
			using (WebClient wc = new WebClient())
			{
				wc.DownloadProgressChanged += wc_DownloadProgressChanged;
				wc.DownloadFileAsync(new Uri(linkaudio),"temp.mp3");
			}
			// Event to track the progress
			void wc_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
			{
				pgb.Value = e.ProgressPercentage;
			}
		}
		public string getLinkAudio(string source)
		{
			int k = source.IndexOf("data-url-mp3");
			string h = source;
			if (h.Length < 20) return "";
			h = h.Substring(k + 14, h.Length - k - 14);
			string shortlink = "https://iapi.glosbe.com/"+ h.Substring(0, h.IndexOf('\"'));
			return shortlink;
		}
	}
}
