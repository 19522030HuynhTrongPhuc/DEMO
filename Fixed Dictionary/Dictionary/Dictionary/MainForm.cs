using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionary
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		dbDictionary dic;
		OnlineDict dict;
		Interface fixedDict;
		private void Dic_Close(object sender, FormClosedEventArgs e)
		{
			dic = null;
		}

		private void databaseDictionaryToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (dic == null)
			{
				dic = new dbDictionary();
				dic.MdiParent = this;
				dic.FormClosed += new FormClosedEventHandler(Dic_Close);
				dic.Show();
			}
			else dic.Activate();
			dic.WindowState = FormWindowState.Maximized;
		}

		private void onlineToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (dict == null)
			{
				dict = new OnlineDict();
				dict.MdiParent = this;
				dict.FormClosed += new FormClosedEventHandler(Dict_Close);
				dict.Show();
			}
			else dict.Activate();
			dict.WindowState = FormWindowState.Maximized;
		}
		private void Dict_Close(object sender, FormClosedEventArgs e)
		{
			dict = null;
		}

		private void fixDictionaryToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (fixedDict == null)
			{
				fixedDict = new Interface();
				fixedDict.MdiParent = this;
				fixedDict.FormClosed += new FormClosedEventHandler(FixedDict_Close);
				fixedDict.Show();
			}
			else fixedDict.Activate();
			fixedDict.WindowState = FormWindowState.Maximized;
		}
		private void FixedDict_Close(object sender, FormClosedEventArgs e)
		{
			fixedDict = null;
		}

		private void titleVerticalToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.LayoutMdi(MdiLayout.TileVertical);
		}

		private void titleHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.LayoutMdi(MdiLayout.TileHorizontal);
		}
	}
}
