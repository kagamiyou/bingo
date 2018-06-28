using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bingo
{
    public partial class Form1 : Form
    {
        List<ListBox> girl = new List<ListBox>();
        int count = 23;
        public Form1()
        {
            InitializeComponent();
            girl = new List<ListBox>();
            foreach(ListBox l in this.Controls.OfType<ListBox>())
            {
                girl.Add(l);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Update("Miki");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Update("Kanon");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Update("Haruka");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Update("Subaru");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Update("Nozomi");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Update("Yuri");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Update("Kurumi");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Update("Asuha");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Update("Anko");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Update("Hinata");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Update("Sadone");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Update("Kaede");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Update("Michelle");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Update("Urara");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Update("Shiho");
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Update("Misaki");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Update("Renge");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Update("Sakura");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Update("Kokomi");
        }
       

        private void Update(string s)
        {
            girl[count].Items.Add(s);
            count--;
        }

   private void clear_Click(object sender, EventArgs e)
        {
            bingo1.Items.Clear();
            bingo2.Items.Clear();
            bingo3.Items.Clear();
            bingo4.Items.Clear();
            bingo5.Items.Clear();
            bingo6.Items.Clear();
            bingo7.Items.Clear();
            bingo8.Items.Clear();
            bingo9.Items.Clear();
            bingo10.Items.Clear();
            bingo11.Items.Clear();
            bingo12.Items.Clear();
            bingo14.Items.Clear();
            bingo15.Items.Clear();
            bingo16.Items.Clear();
            bingo17.Items.Clear();
            bingo18.Items.Clear();
            bingo19.Items.Clear();
            bingo20.Items.Clear();
            bingo21.Items.Clear();
            bingo22.Items.Clear();
            bingo23.Items.Clear();
            bingo24.Items.Clear();
            bingo25.Items.Clear();
            ans.Items.Clear();
        }

        private void start_Click(object sender, EventArgs e)
        {
            ans.Items.Add("共有12條結果,");
            ans.Items.Add("必須選: Miki、Haruka、Subaru、Nozomi、Yuri、Kurumi、");
            ans.Items.Add("Asuha、Anko、Hinata、Sadone、Kaede、Michelle、Urara、");
            ans.Items.Add("Kanon、Shiho、Misaki");
        }
    }
}
