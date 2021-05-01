using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewtonInterpolation
{
    public partial class Form1 : Form
    {
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
                int txtno = int.Parse(txtPoints.Text);
                int pointAX = 110;
                int pointAY = 5;

                int pointBX = 240;
                int pointBY = 5;

                panel2.Controls.Clear();
                for (int i = 0; i < txtno; i++)
                {
                    TextBox x = new TextBox();
                    // Text = (i + 1).ToString();
                    x.Location = new Point(pointAX, pointAY);
                    x.Font = new Font("Malgun Gothic", 12);
                    x.TextAlign = HorizontalAlignment.Center;
                    panel2.Controls.Add(x);
                    panel2.Show();
                    pointAY += 35;

                    TextBox y = new TextBox();
                    // Text = (i + 1).ToString();
                    y.Location = new Point(pointBX, pointBY);
                    y.Font = new Font("Malgun Gothic", 12);
                    y.TextAlign = HorizontalAlignment.Center;
                    panel2.Controls.Add(y);
                    panel2.Show();
                    pointBY += 35;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Enter a valid number");
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txtPoints.Clear();
        }

        private void btn_Solve_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch
            {
                MessageBox.Show("Please fill all fields");
            }
        }
    }
}
