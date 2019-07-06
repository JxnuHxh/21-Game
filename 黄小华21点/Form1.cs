using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace 黄小华21点
{
    public partial class Form1 : Form   //局部类型
    {
        Tran tran = new Tran();
        public int a, b, i, j, m = 4, n = 0,h=0,t=0,p=0,x=0,y=0,z=0,w=0;
        public int[] ab = new int[20];
        public int z_num = 0, w_num = 0, z_count = 0, w_count = 0;
        public PictureBox[] ptb = new PictureBox[20];
        Random r = new Random();
        private void button3_Click(object sender, EventArgs e)//不要牌
        {
            n = m;
            while (true)
            {
                if (z_num > 17)
                    break;
                tran.Fistly(out i, out b, z_num, ab);
                this.ptb[n] = new PictureBox();
                ptb[n].Left = 100 * (n - m + 2);
                this.ptb[n].Height = 140;
                this.ptb[n].Image = imageList1.Images[i];
                panel1.Controls.Add(ptb[n]);
                ab[n] = i;
                z_num = z_num + b;
                n++;
            }
            label3.Text = "点数:" + z_num;
            ptb[2].Height = 140;
            ptb[2].Image = imageList1.Images[x];
            panel1.Controls.Add(ptb[2]);
           
            if (z_num > 21)
            {
                if (w == 11 || z == 11)
                {
                    z_num = z_num - 10;
                    label3.Text = "点数:" + z_num;
                    if (z_num >= w_num)
                    {
                        z_count++;
                        label6.Text = " 庄家得分" + z_count;
                        MessageBox.Show("你的点数小！！ 庄家得一分");
                    }
                    else
                    {
                        w_count++;
                        label5.Text = "玩家得分" + w_count;
                        MessageBox.Show("你的点数大！！ 玩家得一分");
                    }
                }
                if (z_num > 21)
                {
                    w_count++;
                    label5.Text = "玩家得分" + w_count;
                    MessageBox.Show("庄家爆了！！ 玩家得一分");
                    button2.Visible = false;
                    button3.Visible = false;
                }
            }
            else
            {
                if (z_num >= w_num)
                {
                    z_count++;
                    label6.Text = " 庄家得分" + z_count;
                    MessageBox.Show("你的点数小！！ 庄家得一分");
                }
                else
                {
                    w_count++;
                    label5.Text = "玩家得分" + w_count;
                    MessageBox.Show("你的点数大！！ 玩家得一分");
                }
            }
      }
        private void panel1_Paint(object sender, PaintEventArgs e) {        }
        private void button5_Click(object sender, EventArgs e) //重新发牌
        {
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = false;
            for (int i = 0; i < 12; i++)
            {
                ab[i] = 100;
            }
            tran.Fistly(out j, out b, w_num, ab);
            this.ptb[0] = new PictureBox();
            this.ptb[0].Height = 140;
            this.ptb[0].Image = imageList1.Images[j];
            panel2.Controls.Add(ptb[0]);
            w_num = b;
            h = b;
            ab[0] = j;
            int k;
            tran.Fistly(out k, out b, w_num, ab);
            if (ab[0] == k)
            {
                while (ab[0] == k)
                {
                    tran.Fistly(out k, out b, w_num, ab);
                }
                w_num = w_num + b;
                t = b;
                this.ptb[1] = new PictureBox();
                ptb[1].Left = 100;
                this.ptb[1].Height = 140;
                this.ptb[1].Image = imageList1.Images[k];
                panel2.Controls.Add(ptb[1]);
                ab[1] = k;
            }
            else
            {
                w_num = w_num + b;
                t = b;
                this.ptb[1] = new PictureBox();
                ptb[1].Left = 100;
                this.ptb[1].Height = 140;
                this.ptb[1].Image = imageList1.Images[k];
                panel2.Controls.Add(ptb[1]);
                ab[1] = k;
            }
            tran.Fistly(out i, out b, z_num, ab);
            this.ptb[2] = new PictureBox();
            this.ptb[2].Height = 140;
            this.ptb[2].Image = imageList1.Images[52];
            panel1.Controls.Add(ptb[2]);
            x = i;
            y = b;
            w = b;
            ab[2] = i;           
            tran.Fistly(out i, out b, z_num, ab);
            if (ab[2] == i)
            {
                while (ab[2] == i)
                {
                    tran.Fistly(out i, out b, z_num, ab);
                }
                z_num = z_num + b;
                z = b;
                this.ptb[3] = new PictureBox();
                ptb[3].Left = 100;
                this.ptb[3].Height = 140;
                this.ptb[3].Image = imageList1.Images[i];
                panel1.Controls.Add(ptb[3]);
                ab[3] = i;
            }
            else
            {
                z_num = z_num + b;
                z = b;
                this.ptb[3] = new PictureBox();
                ptb[3].Left = 100;
                this.ptb[3].Height = 140;
                this.ptb[3].Image = imageList1.Images[i];
                panel1.Controls.Add(ptb[3]);
                ab[3] = i;
            }
            label3.Text = "点数:" + z_num;
            label4.Text = "点数:" + w_num;
            z_num = z_num + y;
        }
        public Form1()
        {
            InitializeComponent();
        }
        public void button1_Click(object sender, EventArgs e)    //开始游戏
        {
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            panel2.Visible = true;
            panel1.Visible = true;
            button1.Visible = false;
           for (int i = 0; i < 20; i++)
            {
                ab[i] = 100; 
            }
            tran.Fistly(out j, out b, w_num, ab);
            this.ptb[0] = new PictureBox();
            this.ptb[0].Height = 140;
            this.ptb[0].Image = imageList1.Images[j];
            panel2.Controls.Add(ptb[0]);
            w_num = b;
            h = b;         
            ab[0] = j;          
            tran.Fistly(out i, out b, w_num, ab);
            if (ab[0] == i)
            {
                while (ab[0] == i)
                {
                    tran.Fistly(out i, out b, w_num, ab);
                }
                w_num = w_num + b;
                t = b;
                this.ptb[1] = new PictureBox();
                ptb[1].Left = 100;
                this.ptb[1].Height = 140;
                this.ptb[1].Image = imageList1.Images[i];
                panel2.Controls.Add(ptb[1]);
                ab[1] = i;
            }
            else
            {
                w_num = w_num + b;
                t = b;
                this.ptb[1] = new PictureBox();
                ptb[1].Left = 100;
                this.ptb[1].Height = 140;
                this.ptb[1].Image = imageList1.Images[i];
                panel2.Controls.Add(ptb[1]);
                ab[1] = i;
            }
            tran.Fistly(out i, out b, z_num, ab);
            ptb[2] = new PictureBox();
            ptb[2].Height = 140;
            ptb[2].Image = imageList1.Images[52];
            panel1.Controls.Add(ptb[2]);
            x = i;
            y = b;
            w = b;
            ab[2] = i;
            tran.Fistly(out i, out b, z_num, ab);
            if (ab[2] == i)
            {
                while (ab[2] == i)
                {
                    tran.Fistly(out i, out b, z_num, ab);
                }
                z_num = b;
                z = b;
                this.ptb[3] = new PictureBox();
                ptb[3].Left = 100;
                this.ptb[3].Height = 140;
                this.ptb[3].Image = imageList1.Images[i];
                panel1.Controls.Add(ptb[3]);
                ab[3] = i;
            }
          else
            {
                z_num = b;
                z = b;
                ptb[3] = new PictureBox();
                ptb[3].Left = 100;
                ptb[3].Height = 140;
                ptb[3].Image = imageList1.Images[i];
                panel1.Controls.Add(ptb[3]);
                ab[3] = i;
            }
            label3.Text = "点数:" + z_num;
            label4.Text = "点数:" + w_num;
            z_num = z_num + y;
        }
        protected void Form1_Load(object sender, EventArgs e)
        {
          
            //SoundPlayer msc = new SoundPlayer("C:\\Users\\86183\\Desktop\\C#\\1.wav");
            //msc.Play();
        }
        private void button2_Click(object sender, EventArgs e)     //要牌
        {         
            tran.Fistly(out j, out b, w_num, ab);
            ptb[m] = new PictureBox();
            ptb[m].Height = 140;
            ptb[m].Left = 100 * (m - 2);
            ptb[m].Image = imageList1.Images[j];
            panel2.Controls.Add(ptb[m]);
            w_num = b + w_num;
             ab[m] = j;
            if (b == 11)
                p = 1;
            if (w_num > 21 && p == 1)
            {
                w_num = w_num - 10;
            }
            label4.Text = "点数:" + w_num;
            if (w_num > 21)
            {
                if (h==11||t == 11)
                {
                    w_num = w_num - 10;
                    label4.Text = "点数:" + w_num;
                    t = t + 1;
                    h = h + 1;
                }
                if (w_num >21)
                {                   
                    ptb[2].Height = 140;
                    ptb[2].Image = imageList1.Images[x];
                    panel1.Controls.Add(ptb[2]);
                    label3.Text = "点数:" + z_num;
                    MessageBox.Show("很遗憾你爆了！ 【庄家赢】");
                    z_count++;
                    label5.Text = "玩家得分" + w_count;
                    label6.Text = "庄家得分" + z_count;
                    button2.Visible = false;
                    button3.Visible = false;
                }
            }
           m++;
        }
        private void button4_Click(object sender, EventArgs e) //洗牌
        {
            button2.Visible = true;
            button3.Visible = true;
            button5.Visible = true;
            int i=0 ;
            while(ptb[i]!=null)
            {
                ptb[i].Visible = false;
                ab[i] = 100;
                i++;
            }
            z_num = 0;
            w_num = 0;
            m = 4;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            this.label3.Text = "未知";
            this.label4.Text = "未知";
        }
    }
    public class Tran
    {
        private int i;
        Random rf = new Random();
        public void Fistly(out int a, out int b, int q, int[] abc)
        {
              a = rf.Next(0, 51);
            if (a >= 0 && a <= 3)
            {
                b = 2;
            }
            else if (a >= 4 && a <= 7)
            {
                b = 3;
            }
            else if (a >= 8 && a <= 11)
            {
                b = 4;
            }
            else if (a >= 12 && a <= 15)
            {
                b = 5;
            }
            else if (a >= 16 && a <= 19)
            {
                b = 6;
            }
            else if (a >= 20 && a <= 23)
            {
                b = 7;
            }
            else if (a >= 24 && a <= 27)
            {
                b = 8;
            }
            else if (a >= 28 && a <= 31)
            {
                b = 9;
            }
            else if (a >= 32 && a <= 47)
            {
                b = 10;
            }
            else if (a >= 48 && a <= 51)
            {
                if (q >= 0 && q <= 10)
                {
                    b = 11;
                }
                else
                    b = 1;
            }
            else
            {
                b = 0;
                Console.Read();
            }
            for (i = 0; i < 20; i++)
            {
                if (abc[i] == a)
                    Fistly(out a, out b, q, abc);
                else if (i == 19)
                    break;
            }
        }
    }
}
