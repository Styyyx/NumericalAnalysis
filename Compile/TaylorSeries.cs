using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Compile
{
    public partial class FormTaylor:System.Windows.Forms.Form
    {
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private GroupBox groupBox1;
        private Label label10;
        private Label label12;
        private Label label11;
        private Label label14;
        private Label label13;
        private Label label15;
        private TextBox textBox11;
        private TextBox textBox10;
        private TextBox textBox9;
        private TextBox textBox8;
        private TextBox textBox7;
        private TextBox textBox6;
        private Button btnBack;
        private ComboBox comboBox1;

        public FormTaylor()
        {
            InitializeComponent();
        }

        ///<summary>
        ///Generates a Taylor Series with the chosen function and up to number of terms based on degree input.
        ///</summary>
        ///
        ///<param name="whichFunction">
        ///Determines which function to use, takes only 1 or 2 as input:
        /// 1 = cos(x),
        /// 2 = sin(x)*e^x
        ///</param>
        ///
        ///<param name="x">
        ///The value to which the function will be EValuated to.
        ///</param>
        /// 
        ///<param name="n">
        ///The degree to which the series will be generated to. Must be > 0. Default to 1
        ///</param>
        ///
        ///<param name="a">
        ///The point where the derivatives of the function are centered onto. Default to 0 for MacLaurin.
        ///</param>
        ///

        static public void GetTaylorSeries(int whichFunction, double a = 0, double x = 0, int n = 1, int d = 0)
        {
            double TV = 0;
            double EV = 0;
            double rndEV = 0;
            double AE = 0;
            double PE = 0;
            string Pn = "";
            string currFunc;
            double currCoeff = 0;
            if (whichFunction == 1)
            {
                TV = Math.Cos(x);
                EV = Math.Cos(a);
                Pn = $"{EV}";

                currFunc = "cos(x)";

                for (int i = 1; i <= n; i++)
                {
                    switch(currFunc)
                    {
                        case "cos(x)":
                            {
                                currFunc = "-sin(x)";
                                currCoeff = -Math.Sin(a) / GetFactorial(i);
                                break;
                            }
                        case "-sin(x)":
                            {
                                currFunc = "-cos(x)";
                                currCoeff = -Math.Cos(a) / GetFactorial(i);
                                break;
                            }
                        case "-cos(x)":
                            {
                                currFunc = "sin(x)";
                                currCoeff = Math.Sin(a) / GetFactorial(i);
                                break;
                            }
                        case "sin(x)":
                            {
                                currFunc = "cos(x)";
                                currCoeff = Math.Cos(a) / GetFactorial(i);
                                break;
                            }
                    }
                    if (currCoeff != 0)
                    {
                        Pn += $" + ({currCoeff}x^{i})";
                        EV += currCoeff * (Math.Pow(x, i));
                    }
                }

                rndEV = Math.Round(EV, d);
                AE = GetAbsoluteError(TV, EV, d);
                PE = GetPercentageError(TV, EV, d);
            }
            else if (whichFunction == 2)
            {
                TV = (Math.Pow(Math.E, x) * Math.Sin(x));
                EV = (Math.Pow(Math.E, a) * Math.Sin(a));
                Pn = $"{EV}";

                /** Derivation Pattern
                 * 
                 * exsinx -> exsinx, excosx
                 * excosx -> excosx, -exsinx
                 * -exsinx -> -exsinx, -excosx
                 * -excosx -> -excosx, exsinx
                 * 
                 * Only check for exsinx, excosx, -exsinx, -excosx
                 */
                List<string> currPolynomial = new List<string> { "exsinx" };

                // Loop to nth degree
                for (int i = 1; i <= n; i++)
                {
                    currCoeff = 0;

                    // Derive
                    List<string> newPolynomial = new List<string> { };
                    for (int j = 0; j < currPolynomial.Count(); j++)
                    {
                        string currTerm = currPolynomial[j];

                        //Product rule
                        newPolynomial.Add(currTerm);

                        switch(currPolynomial[j])
                        {
                            case "exsinx":
                                {
                                    newPolynomial.Add("excosx");
                                    break;
                                }
                            case "excosx":
                                {
                                    newPolynomial.Add("-exsinx");
                                    break;
                                }
                            case "-exsinx":
                                {
                                    newPolynomial.Add("-excosx");
                                    break;
                                }
                            case "-excosx":
                                {
                                    newPolynomial.Add("exsinx");
                                    break;
                                }
                        }
                    }

                    // Update current polynomial
                    currPolynomial = newPolynomial;

                    // EValuate
                    for (int k = 0; k < currPolynomial.Count(); k++)
                    {
                        switch (currPolynomial[k])
                        {
                            case "exsinx":
                                {
                                    currCoeff += (Math.Pow(Math.E, a) * Math.Sin(a));
                                    break;
                                }
                            case "excosx":
                                {
                                    currCoeff += (Math.Pow(Math.E, a) * Math.Cos(a));
                                    break;
                                }
                            case "-exsinx":
                                {
                                    currCoeff += (Math.Pow(Math.E, a) * -Math.Sin(a));
                                    break;
                                }
                            case "-excosx":
                                {
                                    currCoeff += (Math.Pow(Math.E, a) * -Math.Cos(a));
                                    break;
                                }
                        }
                    }


                    currCoeff /= GetFactorial(i);

                    if (currCoeff != 0)
                    {
                        Pn += $" + ({currCoeff}x^{i})";
                        EV += currCoeff * (Math.Pow(x, i));
                    }
                }

                rndEV = Math.Round(EV, d);                
                AE = GetAbsoluteError(TV, EV, d);
                PE = GetPercentageError(TV, EV, d);
            }

            Console.WriteLine($"\nTrue Value: {TV}\nApproximated Value: {EV}\n\nApproximated Value (Rounded): {rndEV}\nTaylor Series: {Pn}\n\nAbsolute Error: {AE.ToString("#0.##%")}\nPercentage Error: {PE.ToString("#0.##%")}");
        }

        static public int GetFactorial(int x)
        {
            if (x == 0 || x == 1) { return 1; }

            int sum = 1;
            while (x > 0)
            {
                sum *= x;
                x--;
            }
            return sum;
        }

        static public double GetAbsoluteError(double TV, double EV, int d)
        {
            double rndTV = 0, rndEV = 0, AE = 0;
            rndTV = Math.Round(TV, d);
            rndEV = Math.Round(EV, d);
            return AE = Math.Abs(TV - EV);
        }

        static public double GetPercentageError(double TV, double EV, int d)
        {
            double rndTV = 0, rndEV = 0, PE = 0;
            rndTV = Math.Round(TV, d);
            rndEV = Math.Round(EV, d);
            return PE = Math.Abs((TV - EV)/ TV);
        }

        private void InitializeComponent()
        {
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(342, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(332, 31);
            this.label4.TabIndex = 0;
            this.label4.Text = "Taylor\'s Polynomial Series";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Choose a function to solve:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(256, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Enter a real or complex number (a):";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(254, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Enter a real or complex number (x):";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(30, 250);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(305, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Enter the degree of taylor\'s polynomial (n):";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(30, 291);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(259, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Enter number of decimal places (d):";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(350, 159);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 26);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(350, 202);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 26);
            this.textBox3.TabIndex = 1;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(350, 242);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 26);
            this.textBox4.TabIndex = 1;
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(350, 283);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 26);
            this.textBox5.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.textBox11);
            this.groupBox1.Controls.Add(this.textBox10);
            this.groupBox1.Controls.Add(this.textBox9);
            this.groupBox1.Controls.Add(this.textBox8);
            this.groupBox1.Controls.Add(this.textBox7);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(485, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(469, 225);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RESULT";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(19, 191);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(134, 20);
            this.label15.TabIndex = 0;
            this.label15.Text = "Percentage Error:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(19, 158);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(115, 20);
            this.label14.TabIndex = 0;
            this.label14.Text = "Absolute Error:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(19, 127);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(104, 20);
            this.label13.TabIndex = 0;
            this.label13.Text = "Taylor Series:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(19, 94);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(236, 20);
            this.label12.TabIndex = 0;
            this.label12.Text = "Approximated Value (Rounded):";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(19, 59);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(156, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "Approximated Value:";
            // 
            // textBox11
            // 
            this.textBox11.Enabled = false;
            this.textBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox11.Location = new System.Drawing.Point(264, 183);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(180, 26);
            this.textBox11.TabIndex = 1;
            // 
            // textBox10
            // 
            this.textBox10.Enabled = false;
            this.textBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox10.Location = new System.Drawing.Point(264, 150);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(180, 26);
            this.textBox10.TabIndex = 1;
            // 
            // textBox9
            // 
            this.textBox9.Enabled = false;
            this.textBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox9.Location = new System.Drawing.Point(264, 119);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(180, 26);
            this.textBox9.TabIndex = 1;
            // 
            // textBox8
            // 
            this.textBox8.Enabled = false;
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.Location = new System.Drawing.Point(264, 86);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(180, 26);
            this.textBox8.TabIndex = 1;
            // 
            // textBox7
            // 
            this.textBox7.Enabled = false;
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(264, 51);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(180, 26);
            this.textBox7.TabIndex = 1;
            // 
            // textBox6
            // 
            this.textBox6.Enabled = false;
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(264, 20);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(180, 26);
            this.textBox6.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(19, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "True Value:";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "cos(x)",
            "sin(x)*e^x"});
            this.comboBox1.Location = new System.Drawing.Point(350, 120);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 28);
            this.comboBox1.TabIndex = 3;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(65, 40);
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FormTaylor
            // 
            this.ClientSize = new System.Drawing.Size(984, 361);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Name = "FormTaylor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Numerical Analysis | MP - Taylor\'s Polynomial Series";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormTaylor_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormTaylor_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.formMain.Show();
            this.Dispose();
        }
    }
}
