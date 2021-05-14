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
        private TextBox txt_a;
        private TextBox txt_x;
        private TextBox txt_n;
        private TextBox txt_d;
        private Button btnBack;
        private Button btn_Solve;
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
            if (whichFunction == 0)
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
            else if (whichFunction == 1)
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
            MessageBox.Show($"True Value: {TV}\nApproximated Value: {EV}\n\nApproximated Value (Rounded): {rndEV}\nTaylor Series: {Pn}\n\nAbsolute Error: {AE.ToString("#0.##%")}\nPercentage Error: {PE.ToString("#0.##%")}");
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
            this.txt_a = new System.Windows.Forms.TextBox();
            this.txt_x = new System.Windows.Forms.TextBox();
            this.txt_n = new System.Windows.Forms.TextBox();
            this.txt_d = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btn_Solve = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(64, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(387, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "TAYLOR\'S POLYNOMIAL SERIES";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(42, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Choose a function to solve:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(45, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(251, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Enter a real or complex number (a):";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(42, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(249, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "Enter a real or complex number (x):";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(42, 252);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(297, 18);
            this.label8.TabIndex = 0;
            this.label8.Text = "Enter the degree of taylor\'s polynomial (n):";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(42, 293);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(254, 18);
            this.label9.TabIndex = 0;
            this.label9.Text = "Enter number of decimal places (d):";
            // 
            // txt_a
            // 
            this.txt_a.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_a.Location = new System.Drawing.Point(362, 161);
            this.txt_a.Name = "txt_a";
            this.txt_a.Size = new System.Drawing.Size(100, 26);
            this.txt_a.TabIndex = 2;
            // 
            // txt_x
            // 
            this.txt_x.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_x.Location = new System.Drawing.Point(362, 204);
            this.txt_x.Name = "txt_x";
            this.txt_x.Size = new System.Drawing.Size(100, 26);
            this.txt_x.TabIndex = 3;
            // 
            // txt_n
            // 
            this.txt_n.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_n.Location = new System.Drawing.Point(362, 244);
            this.txt_n.Name = "txt_n";
            this.txt_n.Size = new System.Drawing.Size(100, 26);
            this.txt_n.TabIndex = 4;
            // 
            // txt_d
            // 
            this.txt_d.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_d.Location = new System.Drawing.Point(362, 285);
            this.txt_d.Name = "txt_d";
            this.txt_d.Size = new System.Drawing.Size(100, 26);
            this.txt_d.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "cos(x)",
            "sin(x)*e^x"});
            this.comboBox1.Location = new System.Drawing.Point(362, 122);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 26);
            this.comboBox1.TabIndex = 1;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(78, 28);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btn_Solve
            // 
            this.btn_Solve.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Solve.Location = new System.Drawing.Point(45, 334);
            this.btn_Solve.Name = "btn_Solve";
            this.btn_Solve.Size = new System.Drawing.Size(417, 40);
            this.btn_Solve.TabIndex = 6;
            this.btn_Solve.Text = "SOLVE";
            this.btn_Solve.UseVisualStyleBackColor = true;
            this.btn_Solve.Click += new System.EventHandler(this.btn_Solve_Click);
            // 
            // FormTaylor
            // 
            this.ClientSize = new System.Drawing.Size(524, 411);
            this.Controls.Add(this.btn_Solve);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txt_d);
            this.Controls.Add(this.txt_n);
            this.Controls.Add(this.txt_x);
            this.Controls.Add(this.txt_a);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormTaylor";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Numerical Analysis | MP - Taylor\'s Polynomial Series";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormTaylor_FormClosed);
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

        private void btn_Solve_Click(object sender, EventArgs e)
        {
            double a = Double.Parse(txt_a.Text);
            double x = Double.Parse(txt_x.Text);
            int n = Int32.Parse(txt_n.Text);
            int d = Int32.Parse(txt_d.Text);

            int whichFunction = comboBox1.SelectedIndex;

            GetTaylorSeries(whichFunction, a, x, n, d);
        }
    }
}
