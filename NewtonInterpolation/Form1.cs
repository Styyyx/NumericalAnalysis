using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NewtonInterpolation;

namespace NewtonInterpolation
{
    public partial class Form1 : Form
    {

        private List<TextBox> tboxX = new List<TextBox> { };
        private List<TextBox> tboxY = new List<TextBox> { };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Enter_Click(object sender, EventArgs e)
        {
            //try
            //{

            int points = int.Parse(txtPoints.Text);

            int pointAX = 109;
            int pointAY = 5;

            int pointBX = 239;
            int pointBY = 5;

            int locX = 180;
            int locY = 0;
            /*
                TextBox[] xPts = new TextBox[points];

                for (int u = 0; u < points; u++)
                {
                    xPts[u] = new TextBox();
                }

                int i = 0;

                foreach (TextBox txt in xPts)
                {
                    // string name = "txt_xPt" + i.ToString();
                    TextBox x = new TextBox();
                    x.Name = "txt_xPt" + (i + 1).ToString();
                    x.Text = "";
                    x.Location = new Point(pointAX, pointAY);
                    x.Font = new Font("Malgun Gothic", 12);
                    x.TextAlign = HorizontalAlignment.Center;
                    panel2.Controls.Add(x);
                    panel2.Show();
                    pointAY += 35;
                    i++;
                }

                TextBox[] yPts = new TextBox[points];

                foreach (TextBox txt in yPts)
                {
                    //string name = "txt_xPt" + i.ToString();

                    txt.Name = "txt_yPt" + (i + 1).ToString();
                    txt.Text = "";
                    txt.Location = new Point(pointBX, pointBY);
                    txt.Font = new Font("Malgun Gothic", 12);
                    txt.TextAlign = HorizontalAlignment.Center;
                    panel3.Controls.Add(txt);
                    panel3.Show();
                    pointBY += 35;
                    locY = pointBY;
                    i++;
                }
            */
            panel2.Controls.Clear();
            panel3.Controls.Clear();

            for (int i = 0; i < points; i++)
            {
                TextBox x = new TextBox();

                x.Name = "txt_xPt" + (i + 1).ToString();
                x.Font = new Font("Malgun Gothic", 12);
                x.TextAlign = HorizontalAlignment.Center;
                panel2.Controls.Add(x);
                panel2.Show();
                tboxX.Add(x);
                pointAY += 35;

                // xPoints.Add(float.Parse(panel2.Controls["txt_xPt" + (i + 1).ToString()].Text));

                // xPoints.Add(float.Parse((TextBox)panel2.Controls["txt_xPt" + (i + 1).ToString()]).Text);

                //    TextBox tbx = this.Controls.Find("txt_xPt" + (i + 1).ToString(), true).FirstOrDefault() as TextBox;
                //    string xPt = tbx.Text;
                //    xPoints.Add(float.Parse(xPt));

                TextBox y = new TextBox();
                y.Location = new Point(pointBX, pointBY);
                x.Name = "txt_yPt" + (i + 1).ToString();
                y.Font = new Font("Malgun Gothic", 12);
                y.TextAlign = HorizontalAlignment.Center;
                panel2.Controls.Add(y);
                panel2.Show();
                tboxY.Add(y);
                pointBY += 35;
                locY = pointBY;
            }
            // yPoints.Add(float.Parse(panel2.Controls["txt_yPt" + (i + 1).ToString()].Text));


            // Solve Button
            Button btn_Solve = new Button();
            btn_Solve.Name = "btn_Solve";
            btn_Solve.Text = "SOLVE";
            btn_Solve.Height = 30;
            btn_Solve.Width = 100;
            btn_Solve.Location = new Point(locX, locY);
            btn_Solve.Font = new Font("Malgun Gothic", 12, FontStyle.Bold);
            btn_Solve.BackColor = Color.LightGreen;
            panel2.Controls.Add(btn_Solve);

            // Generate Label for Interpolating Points
            Label lbl_InterpolPts = new Label();
            lbl_InterpolPts.Text = "Interpolating Points:";
            lbl_InterpolPts.Location = new Point(150, locY + 40);
            lbl_InterpolPts.AutoSize = true;
            lbl_InterpolPts.Font = new Font("Malgun Gothic", 12);
            panel2.Controls.Add(lbl_InterpolPts);

            Label lbl_InterpolPtsX = new Label();
            lbl_InterpolPtsX.Text = "x";
            lbl_InterpolPtsX.Location = new Point(150, locY + 60);
            lbl_InterpolPtsX.AutoSize = true;
            lbl_InterpolPtsX.Font = new Font("Malgun Gothic", 12);
            panel2.Controls.Add(lbl_InterpolPtsX);

            Label lbl_InterpolPtsY = new Label();
            lbl_InterpolPtsY.Text = "y";
            lbl_InterpolPtsY.Location = new Point(280, locY + 60);
            lbl_InterpolPtsY.AutoSize = true;
            lbl_InterpolPtsY.Font = new Font("Malgun Gothic", 12);
            panel2.Controls.Add(lbl_InterpolPtsY);

            // Generate TextBox for x coordinate
            TextBox txt_xCoord = new TextBox();
            txt_xCoord.Name = "txt_xCoord";
            txt_xCoord.Location = new Point(pointAX, pointAY + 90);
            txt_xCoord.Font = new Font("Malgun Gothic", 12);
            txt_xCoord.TextAlign = HorizontalAlignment.Center;
            panel2.Controls.Add(txt_xCoord);

            // Generate TextBox for y coordinate
            TextBox txt_yCoord = new TextBox();
            txt_yCoord.Name = "txt_yCoord";
            txt_yCoord.Location = new Point(pointBX, pointBY + 90);
            txt_yCoord.Font = new Font("Malgun Gothic", 12);
            txt_yCoord.BackColor = Color.LightGreen;
            txt_yCoord.TextAlign = HorizontalAlignment.Center;
            txt_yCoord.ReadOnly = true;
            txt_yCoord.Enabled = false;
            panel2.Controls.Add(txt_yCoord);

            //float xCoord = float.Parse(txt_xCoord.Text);
            //string yCoord = txt_yCoord.Text;


            // }
            /*
                       catch (Exception)
                        {
                            MessageBox.Show("Enter a valid number");
                            txtPoints.Clear();
                        }
            */
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txtPoints.Clear();
        }

        /*
        private float[] xPts;
        private int intScoreCount = 0;
        private int i = 0;
        */

        private void btn_Solve_Click(object sender, EventArgs e, int points, float xCoord)
        {
            /*
            List<String> xPts = new List<String>();
            List<String> yPts = new List<String>();

            foreach (Control c in panel2.Controls)
            {
                if (c is TextBox)
                    xPts.Add(((TextBox)c).Text);
            }
            xPts.ToArray();
            
            foreach (Control c in panel3.Controls)
            {
                if (c is TextBox)
                    yPts.Add(((TextBox)c).Text);
            }
            yPts.ToArray();
           */

            /*
            for (i = 0; i > points; i++)
            {
                if (float.TryParse(txt_xPts + (i + 1).Text, out float isNumber))
                {
                    xPts[i] = isNumber;
                    i++;
                }
                else
                    MessageBox.Show($"{textBox1.Text} is not a number, check and try again.", "Wrong value provided", MessageBoxButtons.OK);
            }
            
                for (int i = 0; i > points; i++)
                {
                    xPoints.Add(float.Parse("txt_xPt" + i + 1.ToString().Text));
                }
            */

            try
            {

                float[] xPts = new float[points];
                float[] yPts = new float[points];


                for (int i = 0; i > points; i++)
                {
                    xPts[i] = float.Parse(tboxX[i].Text);
                    yPts[i] = float.Parse(tboxY[i].Text);
                }

                float y = Newton.NewtonInterpolate(xPts, yPts, xCoord);
            }
            catch
            {
                MessageBox.Show("Please fill all fields.");
            }
        }
    }
}
