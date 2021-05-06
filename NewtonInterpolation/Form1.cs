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

        float[] xPts;
        float[] yPts;

        private int globalN, globalLocY;
        private TextBox tbox_xcoord;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Enter_Click(object sender, EventArgs e)
        {
            try
            {
                int points = int.Parse(txtPoints.Text);

                int pointAX = 109;
                int pointAY = 5;

                int pointBX = 239;
                int pointBY = 5;

                int locY = 0;

                panel2.Controls.Clear();
                
                // Generate textboxes according to number of points entered
                for (int i = 0; i < points; i++)
                {
                    TextBox x = new TextBox();
                    x.Name = "txt_xPt" + (i + 1).ToString();
                    x.Location = new Point(pointAX, pointAY);
                    x.Font = new Font("Malgun Gothic", 12);
                    x.TextAlign = HorizontalAlignment.Center;
                    panel2.Controls.Add(x);
                    panel2.Show();
                    tboxX.Add(x);
                    pointAY += 35;

                    TextBox y = new TextBox();
                    y.Name = "txt_yPt" + (i + 1).ToString();
                    y.Location = new Point(pointBX, pointBY);
                    y.Font = new Font("Malgun Gothic", 12);
                    y.TextAlign = HorizontalAlignment.Center;
                    panel2.Controls.Add(y);
                    panel2.Show();
                    tboxY.Add(y);
                    pointBY += 35;
                    locY = pointBY;
                }

                // Generate label for interpolating points
                Label lbl_InterpolPts = new Label();
                lbl_InterpolPts.Text = "Interpolating Points:";
                lbl_InterpolPts.Location = new Point(150, locY + 10);
                lbl_InterpolPts.AutoSize = true;
                lbl_InterpolPts.Font = new Font("Malgun Gothic", 12);
                panel2.Controls.Add(lbl_InterpolPts);

                // Generate label for x interpolation point
                Label lbl_InterpolPtsX = new Label();
                lbl_InterpolPtsX.Text = "x";
                lbl_InterpolPtsX.Location = new Point(215, locY + 35);
                lbl_InterpolPtsX.AutoSize = true;
                lbl_InterpolPtsX.Font = new Font("Malgun Gothic", 12);
                panel2.Controls.Add(lbl_InterpolPtsX);

                // Generate x coordinate TextBox
                TextBox txt_xCoord = new TextBox();
                txt_xCoord.Location = new Point(175, locY + 60);
                txt_xCoord.Font = new Font("Malgun Gothic", 12);
                txt_xCoord.TextAlign = HorizontalAlignment.Center;
                tbox_xcoord = txt_xCoord;
                panel2.Controls.Add(txt_xCoord);

                // Generate solve button
                Button btn_Solve = new Button();
                btn_Solve.Name = "btn_Solve";
                btn_Solve.Text = "SOLVE";
                btn_Solve.Height = 30;
                btn_Solve.Width = 100;
                btn_Solve.Location = new Point(175, locY + 100);
                btn_Solve.Font = new Font("Malgun Gothic", 12, FontStyle.Bold);
                btn_Solve.BackColor = Color.LightGreen;
                btn_Solve.Click += new System.EventHandler(this.btn_Solve_Click);
                panel2.Controls.Add(btn_Solve);
                
                Button btn_Clear = new Button();
                btn_Clear.Name = "btn_Clear";
                btn_Clear.Text = "CLEAR";
                btn_Clear.Height = 30;
                btn_Clear.Width = 100;
                btn_Clear.Location = new Point(175, locY + 140);
                btn_Clear.Font = new Font("Malgun Gothic", 12, FontStyle.Bold);
                btn_Clear.BackColor = Color.LightGreen;
                btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
                panel2.Controls.Add(btn_Clear);

                globalLocY = locY;
                globalN = points;

            }
            catch (Exception)
            {
                MessageBox.Show("Enter a valid number");
                txtPoints.Clear();
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            tbox_xcoord.Text = "";
            globalN = 0;
            globalLocY = 0;

            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);

            tboxX.Clear();
            tboxY.Clear();

            if (xPts != null || xPts.Length == 0)
            {
                Array.Clear(xPts, 0, xPts.Length);
            }
            else if (yPts != null || yPts.Length == 0)
            {
                Array.Clear(yPts, 0, yPts.Length);
            }
        }

        private void btn_Solve_Click(object sender, EventArgs e)
        {
            try
            {
                float xCoord = float.Parse(tbox_xcoord.Text);
                xPts = new float[globalN];
                yPts = new float[globalN];

                // Converting list items to array
                for (int i = 0; i < globalN; i++)
                {
                    xPts[i] = float.Parse(tboxX[i].Text);
                    yPts[i] = float.Parse(tboxY[i].Text);
                }

                float yValue = Newton.NewtonInterpolate(xPts, yPts, xCoord);

                string title = "Interpolated y Coordinate";
                MessageBox.Show(yValue.ToString(), title);
            }
            catch
            {
                MessageBox.Show("Please fill all fields.");
            }
        }
    }
}
