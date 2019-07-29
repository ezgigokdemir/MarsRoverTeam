using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarsRoverTeam
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            plateau.Location = new Point(0, 0);
            rover1Coor.Text = (Form1.xLocation / 40).ToString() + " " + (Form1.yLocation / 40).ToString() + " " + Form1.route_1;
            rover2Coor.Text = (Form1.xLocation2 / 40).ToString() + " " + (Form1.yLocation2 / 40).ToString() + " " + Form1.route_2;
        }

        private void Plateau_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int numOfCells = Form1.numOfCells;
            int cellSize = 40;
            this.Size = new Size((numOfCells * 40) + 130, numOfCells * 40 + 130);
            rover1Txt.Location = new Point((numOfCells * 40) + 10, 20);
            rover1Coor.Location = new Point((numOfCells * 40) + 10, 40);
            rover2Txt.Location = new Point((numOfCells * 40) + 10, 75);
            rover2Coor.Location = new Point((numOfCells * 40) + 10, 95);
            plateau.Size = new Size(numOfCells * 40, numOfCells * 40);
            Pen p = new Pen(Color.Black);

            for (int y = 0; y < numOfCells; ++y)
            {
                g.DrawLine(p, 0, y * cellSize, numOfCells * cellSize, y * cellSize);
            }

            for (int x = 0; x < numOfCells; ++x)
            {
                g.DrawLine(p, x * cellSize, 0, x * cellSize, numOfCells * cellSize);
            }

            using (Font myFont = new Font("Arial", 12))
            {
                if (Form1.route_1 == "N")
                {
                    e.Graphics.DrawString("R1⬆", myFont, Brushes.Red, new Point(Form1.xLocation, Form1.yLocation));
                }
                else if (Form1.route_1 == "S")
                {
                    e.Graphics.DrawString("R1⬇", myFont, Brushes.Red, new Point(Form1.xLocation, Form1.yLocation));
                }
                else if (Form1.route_1 == "W")
                {
                    e.Graphics.DrawString("←R1", myFont, Brushes.Red, new Point(Form1.xLocation, Form1.yLocation));
                }
                else if (Form1.route_1 == "E")
                {
                    e.Graphics.DrawString("R1→", myFont, Brushes.Red, new Point(Form1.xLocation, Form1.yLocation));
                }

                if (Form1.route_2 == "N")
                {
                    e.Graphics.DrawString("R2⬆", myFont, Brushes.Red, new Point(Form1.xLocation2, Form1.yLocation2));
                }
                else if (Form1.route_2 == "S")
                {
                    e.Graphics.DrawString("R2⬇", myFont, Brushes.Red, new Point(Form1.xLocation2, Form1.yLocation2));
                }
                else if (Form1.route_2 == "W")
                {
                    e.Graphics.DrawString("←R2", myFont, Brushes.Red, new Point(Form1.xLocation2, Form1.yLocation2));
                }
                else if (Form1.route_2 == "E")
                {
                    e.Graphics.DrawString("R2→", myFont, Brushes.Red, new Point(Form1.xLocation2, Form1.yLocation2));
                }
            }
        }
    }
}
