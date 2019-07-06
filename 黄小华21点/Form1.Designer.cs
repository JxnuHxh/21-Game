namespace 黄小华21点
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(414, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 93);
            this.button1.TabIndex = 0;
            this.button1.Text = "开始游戏";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Lime;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(163, 405);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 77);
            this.button2.TabIndex = 1;
            this.button2.Text = "要牌";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Lime;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.Location = new System.Drawing.Point(299, 405);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 77);
            this.button3.TabIndex = 2;
            this.button3.Text = "不要牌";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(93, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(809, 145);
            this.panel1.TabIndex = 3;
            this.panel1.Visible = false;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.AllowDrop = true;
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Location = new System.Drawing.Point(93, 233);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(809, 142);
            this.panel2.TabIndex = 4;
            this.panel2.Visible = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "h2.jpg");
            this.imageList1.Images.SetKeyName(1, "m2.jpg");
            this.imageList1.Images.SetKeyName(2, "ht2.jpg");
            this.imageList1.Images.SetKeyName(3, "f2.jpg");
            this.imageList1.Images.SetKeyName(4, "h3.jpg");
            this.imageList1.Images.SetKeyName(5, "f3.jpg");
            this.imageList1.Images.SetKeyName(6, "ht3.jpg");
            this.imageList1.Images.SetKeyName(7, "m3.jpg");
            this.imageList1.Images.SetKeyName(8, "h4.jpg");
            this.imageList1.Images.SetKeyName(9, "m4.jpg");
            this.imageList1.Images.SetKeyName(10, "f4.jpg");
            this.imageList1.Images.SetKeyName(11, "ht4.jpg");
            this.imageList1.Images.SetKeyName(12, "h5.jpg");
            this.imageList1.Images.SetKeyName(13, "m5.jpg");
            this.imageList1.Images.SetKeyName(14, "f5.jpg");
            this.imageList1.Images.SetKeyName(15, "ht5.jpg");
            this.imageList1.Images.SetKeyName(16, "m6.jpg");
            this.imageList1.Images.SetKeyName(17, "h6.jpg");
            this.imageList1.Images.SetKeyName(18, "f6.jpg");
            this.imageList1.Images.SetKeyName(19, "ht6.jpg");
            this.imageList1.Images.SetKeyName(20, "m7.jpg");
            this.imageList1.Images.SetKeyName(21, "f7.jpg");
            this.imageList1.Images.SetKeyName(22, "h7.jpg");
            this.imageList1.Images.SetKeyName(23, "ht7.jpg");
            this.imageList1.Images.SetKeyName(24, "h8.jpg");
            this.imageList1.Images.SetKeyName(25, "m8.jpg");
            this.imageList1.Images.SetKeyName(26, "f8.jpg");
            this.imageList1.Images.SetKeyName(27, "ht8.jpg");
            this.imageList1.Images.SetKeyName(28, "h9.jpg");
            this.imageList1.Images.SetKeyName(29, "m9.jpg");
            this.imageList1.Images.SetKeyName(30, "f9.jpg");
            this.imageList1.Images.SetKeyName(31, "ht9.jpg");
            this.imageList1.Images.SetKeyName(32, "h10.jpg");
            this.imageList1.Images.SetKeyName(33, "ht10.jpg");
            this.imageList1.Images.SetKeyName(34, "m10.jpg");
            this.imageList1.Images.SetKeyName(35, "f10.jpg");
            this.imageList1.Images.SetKeyName(36, "m11.jpg");
            this.imageList1.Images.SetKeyName(37, "ht11.jpg");
            this.imageList1.Images.SetKeyName(38, "h11.jpg");
            this.imageList1.Images.SetKeyName(39, "f11.jpg");
            this.imageList1.Images.SetKeyName(40, "m12.jpg");
            this.imageList1.Images.SetKeyName(41, "h12.jpg");
            this.imageList1.Images.SetKeyName(42, "f12.jpg");
            this.imageList1.Images.SetKeyName(43, "ht12.jpg");
            this.imageList1.Images.SetKeyName(44, "m13.jpg");
            this.imageList1.Images.SetKeyName(45, "ht13.jpg");
            this.imageList1.Images.SetKeyName(46, "f13.jpg");
            this.imageList1.Images.SetKeyName(47, "h13.jpg");
            this.imageList1.Images.SetKeyName(48, "m1.jpg");
            this.imageList1.Images.SetKeyName(49, "ht1.jpg");
            this.imageList1.Images.SetKeyName(50, "f1.jpg");
            this.imageList1.Images.SetKeyName(51, "h3.jpg");
            this.imageList1.Images.SetKeyName(52, "bm.jpg");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(96, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "玩家";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(96, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "庄家";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(160, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "未知";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(160, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "未知";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(372, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "比分";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(496, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "比分";
            this.label6.Visible = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Cyan;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button4.Location = new System.Drawing.Point(580, 401);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(107, 69);
            this.button4.TabIndex = 12;
            this.button4.Text = "洗牌";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Purple;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button5.Location = new System.Drawing.Point(721, 401);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(117, 69);
            this.button5.TabIndex = 13;
            this.button5.Text = "重新发牌";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Visible = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.BackgroundImage = global::黄小华21点.Properties.Resources.QQ图片20181228112638;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(937, 572);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "21点游戏";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

