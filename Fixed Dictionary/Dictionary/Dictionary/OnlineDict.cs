using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using FeatureFlashCard;

namespace Dictionary
{
    public partial class OnlineDict : Form
    {

        DictionaryFromWeb wa = new DictionaryFromWeb();
        List<string> Meanings;
        sqlConnection sql = new sqlConnection();
        int index = 1;
        public OnlineDict()
        {
            InitializeComponent();
            this.btSpeak.Visible = true;
            this.lbPronuciation.Visible = true;
            this.pnMakeFlashCard.Visible = false;
        }
        public void AppendText(RichTextBox box, string text, Color color)
        {
            box.SelectionStart = box.TextLength;
            box.SelectionLength = 0;

            box.SelectionColor = color;
            box.AppendText(text);
            box.SelectionColor = box.ForeColor;
        }
        private void btFind_Click(object sender, EventArgs e)
        {
            this.rtbMean.Text = "";
            if (File.Exists("temp.mp3"))
            {
                try
                {
                    File.Delete("temp.mp3");
                }
                catch (Exception ev)
                {

                }
            }
            if (tbWord.Text == "") return;
            this.lbPronuciation.Visible = false;
            this.btSpeak.Visible = false;
            Meanings = wa.onlineDictionary(tbWord.Text);
            if (Meanings.Count == 0 || Meanings[0] == "Error")
            {
                AppendText(rtbMean, "Không tìm thấy từ được nhập", Color.Blue);
                return;
            }
            this.btMakeFlashCard.Visible = true;
            if (Meanings[0] != "Null")
            {
                this.lbPronuciation.Text = "Pronuciation: " + Meanings[0];
                this.lbPronuciation.Visible = true;
            }
            if (File.Exists("temp.mp3"))
            {
                this.btSpeak.Visible = true;
            }

            for (int i = 1; i < Meanings.Count; i++)
            {
                int k = Meanings[i].IndexOf(";");
                if (k == -1) continue;
                string mean = Meanings[i].Substring(0, k);
                string wordformat = Meanings[i].Substring(k + 1, Meanings[i].Length - k - 1);
                AppendText(rtbMean, wordformat + "\n", Color.Blue);
                AppendText(rtbMean, "     " + mean + "\n", Color.Black);
            }
        }
        //private void HideForCreate()
        //{
        //    this.btFind.Visible = false;
        //    this.btMakeFlashCard.Visible = true;
        //    this.rtbMean.Visible = false;
        //    this.tbWord.Visible = false;
        //    this.lbDict.Visible = false;
        //    this.lbPronuciation.Visible = false;
        //    this.btSpeak.Visible = false;
        //}
        //private void ShowAgain()
        //{
        //    this.btFind.Visible = true;
        //    this.btMakeFlashCard.Visible = false;
        //    this.rtbMean.Visible = true;
        //    this.tbWord.Visible = true;
        //    this.lbDict.Visible = true;
        //    this.lbPronuciation.Visible = true;
        //    this.btSpeak.Visible = true;

        //}    
        private void btSpeak_Click(object sender, EventArgs e)
        {
            timer1.Interval = 5000;
            timer1.Tick += new System.EventHandler(this.timer1_Tick);
            timer1.Enabled = true;
            wa.openAudio("temp.mp3");
            wa.playAudio();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            wa.openAudio("temp.mp3");
            wa.stopAudio();
        }
        private void btMakeFlashCard_Click(object sender, EventArgs e)
        {
            this.pnMakeFlashCard.Visible = true;
            this.pnMakeFlashCard.Dock = DockStyle.Fill;
            lbWord.Text = this.tbWord.Text;
            index = 1;
            string m = Meanings[index];
            m = m.Substring(0, m.IndexOf(";"));
            btFlashCard.Text = m;
            this.btMakeFlashCard.Visible = false;
        }
        private void tbWord_TextChanged(object sender, EventArgs e)
        {
            this.btMakeFlashCard.Visible = false;
        }
        private void btNext_Click(object sender, EventArgs e)
        {
            index += 1;
            if(index==Meanings.Count)
            {
                index = 1;
            }
            string m = Meanings[index];
            m = m.Substring(0, m.IndexOf(";"));
            btFlashCard.Text = m;
        }
        private void btChoose_Click(object sender, EventArgs e)
        {
            sql.CustomFlashCard(this.lbWord.Text, this.btFlashCard.Text);
            this.Close();
        }
    }
}
