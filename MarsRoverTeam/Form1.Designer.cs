namespace MarsRoverTeam
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.alanBoyutuTxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.route1 = new System.Windows.Forms.TextBox();
            this.yLoc1 = new System.Windows.Forms.TextBox();
            this.xLoc1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.route2 = new System.Windows.Forms.TextBox();
            this.yLoc2 = new System.Windows.Forms.TextBox();
            this.xLoc2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.instruction1 = new System.Windows.Forms.TextBox();
            this.instruction2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Alan Boyutu";
            // 
            // alanBoyutuTxt
            // 
            this.alanBoyutuTxt.Location = new System.Drawing.Point(139, 45);
            this.alanBoyutuTxt.Name = "alanBoyutuTxt";
            this.alanBoyutuTxt.Size = new System.Drawing.Size(135, 20);
            this.alanBoyutuTxt.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(296, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 36);
            this.button1.TabIndex = 3;
            this.button1.Text = "Mecut Konum Göster";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(149, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Rover_1 Koordinatları";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Yön (N,S,W,E)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Y";
            // 
            // route1
            // 
            this.route1.Location = new System.Drawing.Point(152, 196);
            this.route1.Name = "route1";
            this.route1.Size = new System.Drawing.Size(135, 20);
            this.route1.TabIndex = 16;
            // 
            // yLoc1
            // 
            this.yLoc1.Location = new System.Drawing.Point(152, 170);
            this.yLoc1.Name = "yLoc1";
            this.yLoc1.Size = new System.Drawing.Size(135, 20);
            this.yLoc1.TabIndex = 15;
            // 
            // xLoc1
            // 
            this.xLoc1.Location = new System.Drawing.Point(152, 144);
            this.xLoc1.Name = "xLoc1";
            this.xLoc1.Size = new System.Drawing.Size(135, 20);
            this.xLoc1.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(132, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "X";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(301, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Rover_2 Koordinatları";
            // 
            // route2
            // 
            this.route2.Location = new System.Drawing.Point(304, 196);
            this.route2.Name = "route2";
            this.route2.Size = new System.Drawing.Size(135, 20);
            this.route2.TabIndex = 23;
            // 
            // yLoc2
            // 
            this.yLoc2.Location = new System.Drawing.Point(304, 170);
            this.yLoc2.Name = "yLoc2";
            this.yLoc2.Size = new System.Drawing.Size(135, 20);
            this.yLoc2.TabIndex = 22;
            // 
            // xLoc2
            // 
            this.xLoc2.Location = new System.Drawing.Point(304, 144);
            this.xLoc2.Name = "xLoc2";
            this.xLoc2.Size = new System.Drawing.Size(135, 20);
            this.xLoc2.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(39, 229);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "Keşif Talimatı (R,L,M)";
            // 
            // instruction1
            // 
            this.instruction1.Location = new System.Drawing.Point(152, 222);
            this.instruction1.Name = "instruction1";
            this.instruction1.Size = new System.Drawing.Size(135, 20);
            this.instruction1.TabIndex = 27;
            // 
            // instruction2
            // 
            this.instruction2.Location = new System.Drawing.Point(304, 222);
            this.instruction2.Name = "instruction2";
            this.instruction2.Size = new System.Drawing.Size(135, 20);
            this.instruction2.TabIndex = 29;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(437, 281);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 36);
            this.button2.TabIndex = 30;
            this.button2.Text = "Talimat Sonrası Konum\r\nGöster";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(280, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(286, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "(Ör: 5x5\'lik koordinat sistemi oluşturmak istiyorsanız 5 yazın.)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(445, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "(Ör:2)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(445, 177);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "(Ör:3)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(445, 203);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 34;
            this.label11.Text = "(Ör:N)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(445, 229);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 13);
            this.label12.TabIndex = 35;
            this.label12.Text = "(Ör:MMLMMLMR)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 359);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.instruction2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.instruction1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.route2);
            this.Controls.Add(this.yLoc2);
            this.Controls.Add(this.xLoc2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.route1);
            this.Controls.Add(this.yLoc1);
            this.Controls.Add(this.xLoc1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.alanBoyutuTxt);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Anasayfa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox alanBoyutuTxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox route1;
        private System.Windows.Forms.TextBox yLoc1;
        private System.Windows.Forms.TextBox xLoc1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox route2;
        private System.Windows.Forms.TextBox yLoc2;
        private System.Windows.Forms.TextBox xLoc2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox instruction1;
        private System.Windows.Forms.TextBox instruction2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}

