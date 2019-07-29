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
    public partial class Form1 : Form
    {
        public static int numOfCells = 0;
        public static int xLocation = 0;
        public static int yLocation = 0;
        public static string route_1 = null;
        public static string instruction_1 = null;
        public static int xLocation2 = 0;
        public static int yLocation2 = 0;
        public static string route_2 = null;
        public static string instruction_2 = null;


        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(alanBoyutuTxt.Text) && !String.IsNullOrEmpty(xLoc1.Text) && !String.IsNullOrEmpty(yLoc1.Text) && !String.IsNullOrEmpty(route1.Text))
            {
                numOfCells = Convert.ToInt32(alanBoyutuTxt.Text);
                xLocation = Convert.ToInt32(xLoc1.Text) * 40;
                yLocation = Convert.ToInt32(yLoc1.Text) * 40;
                route_1 = route1.Text.ToUpper();
                instruction_1 = instruction1.Text.ToUpper();
                xLocation2 = Convert.ToInt32(xLoc2.Text) * 40;
                yLocation2 = Convert.ToInt32(yLoc2.Text) * 40;
                route_2 = route2.Text.ToUpper();
                instruction_2 = instruction2.Text.ToUpper();
            }

            Form2 form2 = new Form2();

            if (numOfCells >= (xLocation + yLocation) / 40 || numOfCells >= (xLocation2 + yLocation2) / 40 || (route_1 == "W" || route_1 == "E" | route_1 == "S" || route_1 == "N") && (route_2 == "W" || route_2 == "E" | route_2 == "S" || route_2 == "N"))
            {
                form2.Show();
            }
            else
            {
                MessageBox.Show("Olası hatalar: " +
                    " - Boyut bilgisi konum bilgisi oordinatlarından küçük olamaz." +
                    " - Rota bilgisi yalnızca N, W, E, S değerlerini alabilir.");
            }
        }

        public void ApplyIntruction1(string instruction)
        {
            char[] routes = new char[] { 'N', 'E', 'S', 'W' };
            char[] charArr = instruction.ToCharArray();
            for (int i = 0; i < charArr.Length; i++)
            {
                if (charArr[i] == 'R')
                {
                    if (route_1 == "W")
                    {
                        route_1 = "N";
                    }
                    else if (route_1 == "N")
                    {
                        route_1 = "E";
                    }
                    else if (route_1 == "E")
                    {
                        route_1 = "S";
                    }
                    else if (route_1 == "S")
                    {
                        route_1 = "W";
                    }
                }
                else if (charArr[i] == 'L')
                {
                    if (route_1 == "W")
                    {
                        route_1 = "S";
                    }
                    else if (route_1 == "S")
                    {
                        route_1 = "E";
                    }
                    else if (route_1 == "E")
                    {
                        route_1 = "N";
                    }
                    else if (route_1 == "N")
                    {
                        route_1 = "W";
                    }
                }
                else if (charArr[i] == 'M')
                {
                    if (route_1 == "W" && xLocation >= 40)
                    {
                        xLocation -= 40;
                    }
                    else if (route_1 == "S" && yLocation + 40 <= numOfCells * 40)
                    {
                        yLocation += 40;
                    }
                    else if (route_1 == "E" && xLocation + 40 <= numOfCells * 40)
                    {
                        xLocation += 40;
                    }
                    else if (route_1 == "N" && yLocation >= 40)
                    {
                        yLocation -= 40;
                    }
                }
                else
                {
                    MessageBox.Show("Hatalı rota bilgisi!");
                }
            }
        }

        public void ApplyIntruction2(string instruction)
        {
            char[] routes = new char[] { 'N', 'E', 'S', 'W' };
            char[] charArr = instruction.ToCharArray();
            for (int i = 0; i < charArr.Length; i++)
            {
                if (charArr[i] == 'R')
                {
                    if (route_2 == "W")
                    {
                        route_2 = "N";
                    }
                    else if (route_2 == "N")
                    {
                        route_2 = "E";
                    }
                    else if (route_2 == "E")
                    {
                        route_2 = "S";
                    }
                    else if (route_2 == "S")
                    {
                        route_2 = "W";
                    }
                }
                else if (charArr[i] == 'L')
                {
                    if (route_2 == "W")
                    {
                        route_2 = "S";
                    }
                    else if (route_2 == "S")
                    {
                        route_2 = "E";
                    }
                    else if (route_2 == "E")
                    {
                        route_2 = "N";
                    }
                    else if (route_2 == "N")
                    {
                        route_2 = "W";
                    }
                }
                else if (charArr[i] == 'M')
                {
                    if (route_2 == "W" && xLocation2 >= 40)
                    {
                        xLocation2 -= 40;
                    }
                    else if (route_2 == "S" && yLocation2 + 40 <= numOfCells * 40)
                    {
                        yLocation2 += 40;
                    }
                    else if (route_2 == "E" && xLocation2 + 40 <= numOfCells * 40)
                    {
                        xLocation2 += 40;
                    }
                    else if (route_2 == "N" && yLocation2 >= 40)
                    {
                        yLocation2 -= 40;
                    }
                }
                else
                {
                    MessageBox.Show("Hatalı rota bilgisi!");
                }
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(alanBoyutuTxt.Text) && !String.IsNullOrEmpty(xLoc1.Text) && !String.IsNullOrEmpty(yLoc1.Text) && !String.IsNullOrEmpty(route1.Text))
            {
                numOfCells = Convert.ToInt32(alanBoyutuTxt.Text);
                xLocation = Convert.ToInt32(xLoc1.Text) * 40;
                yLocation = Convert.ToInt32(yLoc1.Text) * 40;
                route_1 = route1.Text.ToUpper();
                instruction_1 = instruction1.Text.ToUpper();
                xLocation2 = Convert.ToInt32(xLoc2.Text) * 40;
                yLocation2 = Convert.ToInt32(yLoc2.Text) * 40;
                route_2 = route2.Text.ToUpper();
                instruction_2 = instruction2.Text.ToUpper();
            }

            ApplyIntruction1(instruction_1);
            ApplyIntruction2(instruction_2);

            Form3 form3 = new Form3();

            if (numOfCells >= (xLocation + yLocation) / 40 || numOfCells >= (xLocation2 + yLocation2) / 40 || (route_1 == "W" || route_1 == "E" | route_1 == "S" || route_1 == "N") && (route_2 == "W" || route_2 == "E" | route_2 == "S" || route_2 == "N"))
            {
                form3.Show();
            }
            else
            {
                MessageBox.Show("Olası hatalar: " +
                    " - Boyut bilgisi konum bilgisi oordinatlarından küçük olamaz." +
                    " - Rota bilgisi yalnızca N, W, E, S değerlerini alabilir.");
            }
        }
    }
}
