namespace MarsRoverTeam
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.plateau = new System.Windows.Forms.PictureBox();
            this.rover2Coor = new System.Windows.Forms.Label();
            this.rover1Coor = new System.Windows.Forms.Label();
            this.rover2Txt = new System.Windows.Forms.Label();
            this.rover1Txt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.plateau)).BeginInit();
            this.SuspendLayout();
            // 
            // plateau
            // 
            this.plateau.Location = new System.Drawing.Point(12, 12);
            this.plateau.Name = "plateau";
            this.plateau.Size = new System.Drawing.Size(499, 365);
            this.plateau.TabIndex = 2;
            this.plateau.TabStop = false;
            this.plateau.Paint += new System.Windows.Forms.PaintEventHandler(this.Plateau_Paint);
            // 
            // rover2Coor
            // 
            this.rover2Coor.AutoSize = true;
            this.rover2Coor.Location = new System.Drawing.Point(553, 101);
            this.rover2Coor.Name = "rover2Coor";
            this.rover2Coor.Size = new System.Drawing.Size(109, 13);
            this.rover2Coor.TabIndex = 34;
            this.rover2Coor.Text = "Rover_2 Koordinatları";
            // 
            // rover1Coor
            // 
            this.rover1Coor.AutoSize = true;
            this.rover1Coor.Location = new System.Drawing.Point(553, 46);
            this.rover1Coor.Name = "rover1Coor";
            this.rover1Coor.Size = new System.Drawing.Size(109, 13);
            this.rover1Coor.TabIndex = 33;
            this.rover1Coor.Text = "Rover_1 Koordinatları";
            // 
            // rover2Txt
            // 
            this.rover2Txt.AutoSize = true;
            this.rover2Txt.Location = new System.Drawing.Point(553, 81);
            this.rover2Txt.Name = "rover2Txt";
            this.rover2Txt.Size = new System.Drawing.Size(103, 13);
            this.rover2Txt.TabIndex = 32;
            this.rover2Txt.Text = "Rover2 Koordinatları";
            // 
            // rover1Txt
            // 
            this.rover1Txt.AutoSize = true;
            this.rover1Txt.Location = new System.Drawing.Point(553, 26);
            this.rover1Txt.Name = "rover1Txt";
            this.rover1Txt.Size = new System.Drawing.Size(103, 13);
            this.rover1Txt.TabIndex = 31;
            this.rover1Txt.Text = "Rover1 Koordinatları";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 391);
            this.Controls.Add(this.rover2Coor);
            this.Controls.Add(this.rover1Coor);
            this.Controls.Add(this.rover2Txt);
            this.Controls.Add(this.rover1Txt);
            this.Controls.Add(this.plateau);
            this.Name = "Form3";
            this.Text = "Talimat Sonrası Konum Bilgisi";
            ((System.ComponentModel.ISupportInitialize)(this.plateau)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox plateau;
        private System.Windows.Forms.Label rover2Coor;
        private System.Windows.Forms.Label rover1Coor;
        private System.Windows.Forms.Label rover2Txt;
        private System.Windows.Forms.Label rover1Txt;
    }
}