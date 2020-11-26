using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FeatureFlashCard
{
	public partial class Statistic : Form
	{
		sqlConnection sql = new sqlConnection();
		public Statistic()
		{
			InitializeComponent();
			Init();
		}
		private void Init()
		{
			List<string> ls = sql.getInfo(Data.id_user);
			this.lbID.Text = "ID: " + ls[0];
			this.lbUsername.Text = "Username: " + ls[1];
			this.lbEmail.Text = "Email: " + ls[2];
			this.lbLearned.Text =  "Learned: "+ ls[3];
			this.lbToLearn.Text = "To Learn: "+ ls[4];
		}

		private void btBack_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
