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
        public Form1()
        {
            InitializeComponent();
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
            bingo11.Items.Add("Miki");
            bingo18.Items.Add("Miki");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            bingo9.Items.Add("Kanon");
            bingo21.Items.Add("Kanon");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bingo15.Items.Add("Haruka");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bingo7.Items.Add("Subaru");
            bingo19.Items.Add("Subaru");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bingo14.Items.Add("Nozomi");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bingo17.Items.Add("Yuri");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            bingo5.Items.Add("Kurumi");
            bingo24.Items.Add("Kurumi");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            bingo8.Items.Add("Asuha");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            bingo2.Items.Add("Anko");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            bingo3.Items.Add("Hinata");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            bingo4.Items.Add("Sadone");
            bingo20.Items.Add("Sadone");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            bingo12.Items.Add("Kaede");
            bingo25.Items.Add("Kaede");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            bingo1.Items.Add("Michelle");
            bingo22.Items.Add("Michelle");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            bingo16.Items.Add("Urara");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            bingo6.Items.Add("Shiho");
            bingo23.Items.Add("Shiho");
        }

        private void button19_Click(object sender, EventArgs e)
        {
            bingo10.Items.Add("Misaki");
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
