using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FeatureFlashCard
{
	struct Word
	{
		public string id;
		public string eng;
		public string viet;
		public Word(string a, string b, string c)
		{
			id = a;
			eng = b;
			viet = c;
		}
	};
	class sqlConnection
	{
		String connString = @"Server=DESKTOP-HNQNQ1I\SQLEXPRESS;Database=ENGLISHVO;User Id=sa;Password=1;";
		public List<string> getList()
		{
			List<string> res= new List<string>();
			SqlConnection connection = new SqlConnection(connString);
			connection.Open();
			String sqlQuery = "select WORD from VOCABULARY";
			SqlCommand command = new SqlCommand(sqlQuery, connection);
			SqlDataReader reader = command.ExecuteReader();
			while (reader.HasRows)
			{
				if (reader.Read() == false) break;
				else
				{
					res.Add(reader[0].ToString());
				}
			}
			reader.Close();
			connection.Close();
			return res;
		}
	}
}
