using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionary
{
	public partial class Interface : Form
	{
		Music wplayer;
		public Interface()
		{
			InitializeComponent();
		}

		private void btFind_Click(object sender, EventArgs e)
		{
			//this.pbLoad.Focus();
			if (this.tbWord.Text != "" && this.tbWord.Text.IndexOf(" ") == -1)
			{
				this.tbLink.Text = "https://iapi.glosbe.com/en/vi/" + this.tbWord.Text;
			}
			WebActivity wa = new WebActivity();
			rtbSource.Text = wa.getSource(this.tbLink.Text);
			if(rtbSource.Text=="")
			{
				rtbSource.ForeColor = Color.Red;
				rtbSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
				rtbSource.Text = "Error";
				return;
			}
			int k = rtbSource.Text.IndexOf("data-url-mp3");
			string h1 = rtbSource.Text;
			if (h1.Length > 20)
			{
				h1 = h1.Substring(k + 14, h1.Length - k - 14);
				tbAudioLink.Text = "https://iapi.glosbe.com/" + h1.Substring(0, h1.IndexOf('\"'));
			}
			string h = rtbSource.Text;
			k = h.IndexOf("IPA");
			h = h.Substring(k + 18);
			int num = h.IndexOf(',');
			string u;
			if(num == -1 || num > 50)
			{
				u = h.Substring(0, h.IndexOf(';'));
			}	
			else u = h.Substring(0, h.IndexOf(','));
			if (u.IndexOf('>') != -1) return;
			tbPronunciation.Text += u+"\n";
			rtbSource.Text = h;
		}

		private void btGetLink_Click(object sender, EventArgs e)
		{
		}

		private void btGetAudio_Click(object sender, EventArgs e)
		{
			WebActivity wa = new WebActivity();
			wa.getAudio(tbAudioLink.Text ,pgbGetAudio);
		}

		private void btAudioPlay_Click(object sender, EventArgs e)
		{
			pgbGetAudio.Value = 0;
			wplayer = new Music();
			wplayer.open("temp.mp3");
			wplayer.play();
			//wplayer.stop();
		}
		private void btStop_Click(object sender, EventArgs e)
		{
			wplayer.stop();
		}
		public void AppendText(RichTextBox box, string text, Color color)
		{
			box.SelectionStart = box.TextLength;
			box.SelectionLength = 0;

			box.SelectionColor = color;
			box.AppendText(text);
			box.SelectionColor = box.ForeColor;
		}
		private void btGetMeaning_Click(object sender, EventArgs e)
		{
			string h = this.rtbSource.Text;
			if (h.IndexOf("Show declension of") == -1) return;
			int k=h.IndexOf("strong class=\" phr\">");
			h = h.Substring(k + 20, h.Length - k - 20);
			string res = h.Substring(0, h.IndexOf('<'));
			k = h.IndexOf("gender-n-phrase\">");
			h = h.Substring(k + 40,h.Length-k-40);
			string wordformat = h.Substring(0, h.IndexOf("\t"));
			//get more detail

			if (wordformat.Length > 20) return;
			AppendText(rtbMeaning, res + " :" + wordformat, Color.Red);
			rtbSource.Text = h;
		}

		private void getAllMean_Click(object sender, EventArgs e)
		{
			
			string h = this.rtbSource.Text;
			//get default wordformat
			int typeindex = h.IndexOf("defmeta\">Type:");
			if(typeindex==-1)
			{
				rtbSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
				rtbSource.Text = "Error";
				tbPronunciation.Text = "";
				return;
			}
			string l= h.Substring(typeindex + 28);
			string df = l.Substring(0, l.IndexOf(";"));
			this.tbdfformat.Text = df;

			bool isTrueWord = false;
			while (true)
			{
				if (h.IndexOf("Show declension of") == -1) break;
				int k = h.IndexOf("strong class");
				if (k == -1) break;
				//MessageBox.Show("Đã lấy đc cái strong class" + k);
				h = h.Substring(k + 20, h.Length - k - 20);
				string res = h.Substring(0, h.IndexOf('<'));
				//MessageBox.Show(res);
				//MessageBox.Show(h);
				k = h.IndexOf("gender-n-phrase\">");
				string wordformat;
				if (k == -1)
				{
					wordformat = df;
				}
				else
				{
					h = h.Substring(k + 40, h.Length - k - 40);
					wordformat = h.Substring(0, h.IndexOf("\t"));
				}					
			
				//get more detail

				//if (wordformat.Length > 12) continue;
				//Cập nhật các điều kiện để fix mấy cái bug của chữ in
				string illegal = "!<>|:;";
				bool isOk = true;
				for(int i=0;i<illegal.Length;i++)
				{
					if(wordformat.IndexOf(illegal[i])!=-1)
					{
						isOk = false;
						break;
					}	
				}
				if (isOk == false) continue;
				//Cập nhật để fix chữ optimize
				for (int i = 0; i < illegal.Length; i++)
				{
					if (res.IndexOf(illegal[i]) != -1)
					{
						isOk = false;
						break;
					}
				}
				if (isOk == false) continue;

				AppendText(rtbMeaning, wordformat+"\n", Color.Blue);
				AppendText(rtbMeaning, "     " + res + "\n", Color.Black);
				isTrueWord = true;
			}
			if(isTrueWord==false)
			{
				rtbSource.ForeColor = Color.Red;
				rtbSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
				rtbSource.Text = "Error";
				tbPronunciation.Text = "";
				return;
			}	
			this.rtbSource.Text = h;
		}

		private void btClear_Click(object sender, EventArgs e)
		{
			if(File.Exists("temp.mp3"))
			{
				try
				{
					File.Delete("temp.mp3");
				}
				catch(Exception ev)
				{

				}
			}
			rtbSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			rtbSource.ForeColor = Color.Black;
			this.rtbMeaning.Text = "";
			this.rtbSource.Text = "";
			this.wplayer = new Music();
			this.tbPronunciation.Text = "";
			this.tbAudioLink.Text = "";
			this.tbWord.Text = "";
			this.tbLink.Text = "";
		}
	}
}
