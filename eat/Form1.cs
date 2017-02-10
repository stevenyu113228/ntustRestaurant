using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eat
{
    public partial class Form1 : Form
    {
        Random rand = new Random();
        private bool[] prefer = new bool[4];
        private int din = 87;
        private string restaurant = "";
        private  string[,] rest = new string[4,15] 
        {
            {"摩斯","美而美","嚴茶","韓風小舖","四海遊龍","上品排骨","台灣古早味","安娜的廚房","自助餐","地中海","鐵板","丼太郎","李媽媽","全家","7-11"},
            {"7-11","麵包店","美而美","豪享來","饗初滷味","燒臘","八方雲集","自助餐","日和", "藝素佳","蔥抓餅","阿水","","",""},
            {"自助餐","燒臘","","","","","","","","","","","","",""},
            {"炒飯","炒麵","","","","","","","","","","","","",""}
        };
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("ㄤㄤ\n今天尼要ㄘ什麼ㄋ?","ㄘ什麼 V1.0",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
        }
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
                prefer[3] = true;
            else
                prefer[3] = false;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
                prefer[2] = true;
            else
                prefer[2] = false;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
                prefer[1] = true;
            else
                prefer[1] = false;
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                prefer[0] = true;
            else
                prefer[0] = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
            }
            else
            {
                checkBox1.Checked = true;
                checkBox2.Checked = true;
                checkBox3.Checked = true;
                checkBox4.Checked = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            return;
        }
        private void getRest()
        {
            din = rand.Next(0, 4);
            while (prefer[din] != true)
            {
                din = rand.Next(0, 4);
            }
            switch (din)
            {
                case 0:
                    label2.Text = checkBox1.Text;
                    restaurant = checkBox1.Text;
                    break;
                case 1:
                    label2.Text = checkBox2.Text;
                    restaurant = checkBox2.Text;
                    break;
                case 2:
                    label2.Text = checkBox3.Text;
                    restaurant = checkBox3.Text;
                    break;
                case 3:
                    label2.Text = checkBox4.Text;
                    restaurant = checkBox4.Text;
                    break;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {

            bool ck = false;
            for (int i = 0; i < 4; i++)
            {
                if (prefer[i])
                {
                    ck = true;
                }
            }
            if (ck == false)
            {
                MessageBox.Show("87\n你沒有勾選", "8787", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            getRest();
            /*
            if (din == 87)
            {
                MessageBox.Show("請先選擇餐廳!!","87忘記選餐廳",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return ;
            }
            */
            int choose = 0;
            switch(din)
            {
                case 0:
                    choose = rand.Next(0, 15);
                    break;
                case 1:
                    choose = rand.Next(0, 12);
                    break;
                case 2:
                    choose = rand.Next(0, 2);
                    break;
                case 3:
                    choose = rand.Next(0, 2);
                    break;
            }
            label2.Text += " ";
            label2.Text += rest[din, choose];
            MessageBox.Show(string.Format("今天ㄘ{0}的{1}", restaurant, rest[din,choose]),"ㄘㄉ東西",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
        }
    }
}
