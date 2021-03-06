﻿using System;
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
		public List<Word> getWord()
		{
			List<Word> res= new List<Word>();
			SqlConnection connection = new SqlConnection(connString);
			connection.Open();

			String sqlQuery = "select v.id, v.WORD, v.MEAN  from VOCABULARY v where v.id not in (select id_word from Learned l where l.id_user = " + Data.id_user + ") and v.id not in (select id_word from ToLearn t where t.id_user = " + Data.id_user + ") order by v.id";

			SqlCommand command = new SqlCommand(sqlQuery, connection);

			SqlDataReader reader = command.ExecuteReader();

			int target = 11;
			while (reader.HasRows)
			{
				if (reader.Read() == false) break;
				{
					Word w = new Word(reader[0].ToString(), reader[1].ToString(), reader[2].ToString());
					res.Add(w);
					target--;
					if(target==0)
						return res;
				}
			}
			reader.Close();
			connection.Close();
			return res;
		}
		public void Learned(string word_id)
		{
			SqlConnection connection = new SqlConnection(connString);
			connection.Open();
			String sqlQuery = "insert into Learned (id_word, id_user) values (" + word_id + "," + Data.id_user+ ")";
			SqlCommand command = new SqlCommand(sqlQuery, connection);
			SqlDataReader reader = command.ExecuteReader();
			reader.Close();
			connection.Close();
		}
		public void ToLearn(string word_id)
		{
			SqlConnection connection = new SqlConnection(connString);
			connection.Open();
			String sqlQuery = "insert into ToLearn (id_word, id_user) values (" + word_id + "," + Data.id_user + ")";
			SqlCommand command = new SqlCommand(sqlQuery, connection);
			SqlDataReader reader = command.ExecuteReader();
			reader.Close();
			connection.Close();
		}
		public List<string> getInfo(string user_id)
		{
			List<string> ls = new List<string>();
			SqlConnection connection = new SqlConnection(connString);
			connection.Open();
			String sqlQuery = "select id, username, email from USERINFO where id="+user_id;
			SqlCommand command = new SqlCommand(sqlQuery, connection);
			SqlDataReader reader = command.ExecuteReader();
			while (reader.HasRows)
			{
				if (reader.Read() == false) break;
				else
				{
					ls.Add(reader[0].ToString());
					ls.Add(reader[1].ToString());
					ls.Add(reader[2].ToString());

				}					
			}
			reader.Close();
			sqlQuery = "select count(*) as dem from Learned where id_user=" + Data.id_user;
			command = new SqlCommand(sqlQuery, connection);
			reader = command.ExecuteReader();
			while (reader.HasRows)
			{
				if (reader.Read() == false) break;
				else
				{
					ls.Add(reader[0].ToString());
				}
			}
			reader.Close();
			sqlQuery = "select count(*) as dem from ToLearn where id_user=" + Data.id_user;
			command = new SqlCommand(sqlQuery, connection);
			reader = command.ExecuteReader();
			while (reader.HasRows)
			{
				if (reader.Read() == false) break;
				else
				{
					ls.Add(reader[0].ToString());
				}
			}
			reader.Close();
			connection.Close();
			return ls;
		}
		public List<Word> getOwnFlashCard()
		{
			List<Word> res = new List<Word>();
			SqlConnection connection = new SqlConnection(connString);
			connection.Open();
			String sqlQuery = "select f.id, f.word, f.mean from FlashCard f where f.userID ="+ Data.id_user + "order by f.id";
			SqlCommand command = new SqlCommand(sqlQuery, connection);
			SqlDataReader reader = command.ExecuteReader();
			while (reader.HasRows)
			{
				if (reader.Read() == false) break;
				{
					Word w = new Word(reader[0].ToString(), reader[1].ToString(), reader[2].ToString());
					res.Add(w);
				}
			}
			reader.Close();
			connection.Close();
			return res;
		}
	}
}
