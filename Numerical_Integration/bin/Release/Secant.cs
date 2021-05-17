using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using org.mariuszgromada.math.mxparser;

namespace Compile
{
    public partial class FormSecant : Form
    {
        static public List<(int n, double x0, double x1, double fx0, double fx1, double x2, double err)> secantResult = 
            new List<(int n, double x0, double x1, double fx0, double fx1, double x2, double err)> {};

        public FormSecant()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Secant_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.formMain.Show();
            this.Dispose();
        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            try
            {
                if (tboxFx.Text == "" || tboxX0.Text == "" || tboxX1.Text == "")
                {
                    throw new MissingInputException();
                }

                Function fx = new Function($"f(x) = {PreParser.PreParse(tboxFx.Text)}");
                double x0, x1;
                bool isMaxIter;
                int maxIter = 1;
                double maxErr = 0d;

                if (!double.TryParse(tboxX0.Text, out x0))
                {
                    throw new x0NotNumericException();
                }
                if (!double.TryParse(tboxX1.Text, out x1))
                {
                    throw new x1NotNumericException();
                }

                isMaxIter = rbtnIter.Checked ? true : false;

                if (isMaxIter)
                {
                    if (!int.TryParse(tboxStopForce.Text, out maxIter))
                    {
                        throw new StopForceValueInvalidException();
                    }
                }
                else
                {
                    if (!double.TryParse(tboxStopForce.Text, out maxErr))
                    {
                        throw new StopForceValueInvalidException();
                    }
                }

                Secant(1, x0, x1, fx, isMaxIter, maxIter, maxErr);

                new FormSecantResult(secantResult).ShowDialog();
                secantResult.Clear();

            }
            catch (MissingInputException)
            {
                MessageBox.Show("At least one text field is missing an input.");
            }
            catch (StopForceValueInvalidException)
            {
                MessageBox.Show("Stopping force value is invalid.");
            }
        }
        public void Secant(int n, double x0, double x1, Function fx, bool isMaxIter, int maxIter, double maxErr)
        {
            double fx0 = fx.calculate(x0);
            double fx1 = fx.calculate(x1);
            double x2 = x1 - ((fx1 * (x1 - x0)) / (fx1 - fx0));
            double err = Math.Abs(x2 - x1);

            secantResult.Add((n, x0, x1, fx0, fx1, x2, err));

            if (isMaxIter)
            {
                if (n == maxIter) { return; }
            }
            else
            {
                if (err <= maxErr) { return; }
            }

            Secant(n + 1, x1, x2, fx, isMaxIter, maxIter, maxErr);
            return;
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            tboxFx.Text = "";
            tboxX0.Text = "";
            tboxX1.Text = "";
            tboxStopForce.Text = "";
        }
    }

    public class x0NotNumericException : Exception
    {
        public x0NotNumericException() { }
    }
    public class x1NotNumericException : Exception
    {
        public x1NotNumericException() { }
    }

    public class StopForceValueInvalidException : Exception
    {
        public StopForceValueInvalidException() { }
    }
}
