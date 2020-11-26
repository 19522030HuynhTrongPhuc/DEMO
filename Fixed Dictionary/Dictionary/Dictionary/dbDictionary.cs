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

namespace Dictionary
{
	public partial class dbDictionary : Form
	{
		sqlConnection sql = new sqlConnection();
		List<string> my_list = new List<string>();
		bool isChange = false;
		public dbDictionary()
		{
			InitializeComponent();
			//this.tbWord.DataSource = my_list;
			//timer1.Enabled = true;
			var acsc = new AutoCompleteStringCollection();
			acsc.AddRange(sql.Suggest("").ToArray());
			tbWord.AutoCompleteCustomSource = acsc;
			isChange = false;
		}

		private void btFind_Click(object sender, EventArgs e)
		{
			this.rtbMean.Text = sql.Find(this.tbWord.Text);
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			//if (tbWord.Text != "" && isChange==true)
			//{
			//	my_list = sql.Suggest(tbWord.Text);
			//	//this.tbWord = new ComboBox();
			//	this.tbWord.DataSource = my_list;
			//	tbWord.DroppedDown = true;
			//	Cursor.Current = Cursors.Default;
			//	isChange = false; 
			//}
			//else if(tbWord.Text=="") tbWord.DroppedDown = false;
			//if (tbWord.Text != "" && isChange == true)
			//{
			//	var acsc = new AutoCompleteStringCollection();
			//	acsc.AddRange(sql.Suggest(tbWord.Text).ToArray());
			//	tbWord.AutoCompleteCustomSource = acsc;
			//	isChange = false;
			//}

		}

		private void tbWord_TextChanged(object sender, EventArgs e)
		{
			isChange = true;
		}

		private void tbWord_Enter(object sender, EventArgs e)
		{
			this.rtbMean.Text = sql.Find(this.tbWord.Text);
		}
	}
}
