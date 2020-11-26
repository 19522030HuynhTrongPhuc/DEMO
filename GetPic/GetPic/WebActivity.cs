using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Drawing.Imaging;
using Microsoft.SqlServer.Server;
using System.Drawing.Imaging;
using System.IO;
using System.Drawing;

namespace GetPic
{
	class WebActivity
	{
		List<string> allLink = new List<string>();
		WebClient client = new WebClient();
		public string renderLink(string key)
		{
			if (key.IndexOf(" ") != -1)
			{
				return "https://www.google.com.vn/search?tbm=isch&q=unknown&sclient=img&safe=active";
			}
			string sample = "https://www.google.com.vn/search?tbm=isch&q=stringtofind&sclient=img&safe=active";
			sample = sample.Replace("stringtofind", key);
			return sample;
		}	
		public string getSource(string key)
		{
			WebClient client = new WebClient();
			client.Headers.Add(HttpRequestHeader.UserAgent, "Mozilla/5.0 (Windows NT 10.0; WOW64; rv:47.0) Gecko/20100101 Firefox/47.0");
			string res= client.DownloadString(renderLink(key));
			return res;
		}
		public List<string> getLinkPic(string source)
		{
			List<string> allLink1 = new List<string>();
			for (int i = 0; i < 10; i++)
			{
				// Tách đến link hình ảnh
				string h = source;
				string toFind = "[\"https";
				int k = h.IndexOf(toFind);
				if (k == -1)
					break;
				// Trường hợp này xảy ra khi có sensitive image
				h = h.Substring(k, h.Length - k);
				source = h;
				// Tách link thực sự
				h = source;
				h = h.Substring(h.IndexOf(']') + 1, h.Length - 1 - h.IndexOf(']'));
				h = h.Substring(4, h.Length - 4);
				string link = h.Substring(0, h.IndexOf('\"'));
				allLink1.Add(link);
			}
			return allLink1;
		}
		public bool DownLoadPic(string link, string key)
		{
			try
			{
				Stream stream = client.OpenRead(link);
				Bitmap bitmap;
				bitmap = new Bitmap(stream);

				if (bitmap != null)
				{
					bitmap.Save("IMG/" + key + ".png", ImageFormat.Png);
				}

				stream.Flush();
				stream.Close();
				//client.Dispose();
				return true;
			}
			catch (Exception ex)
			{
				return false;
			}
		}
		public void DownLoadUntil(string key)
		{
			string source = getSource(key);
			allLink=getLinkPic(source);
			for(int i = 0;i < allLink.Count; i++)
			{
				if (DownLoadPic(allLink[i],key) == true) 
					break;
			}	
		}
	}
}
