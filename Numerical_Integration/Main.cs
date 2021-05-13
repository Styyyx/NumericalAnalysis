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
//using System.Runtime.InteropServices;

namespace Numerical_Integration
{
    public partial class Main : Form
    {

        //[DllImport("kernel32.dll", SetLastError = true)]
        //[return: MarshalAs(UnmanagedType.Bool)]
        //static extern bool AllocConsole();

        public Main()
        {
            InitializeComponent();
        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            //AllocConsole();
            try
            {
                double a, b, n;

                if (tboxFx.Text == "" || tboxA.Text == "" || tboxB.Text == "")
                {
                    throw new MissingInputException();
                }

                Function fx = new Function($"f(x) = {PreParser.PreParse(tboxFx.Text)}");

                
                if (!double.TryParse(tboxA.Text, out a))
                {
                    throw new LowerLimitNotNumericException();
                }
                if (!double.TryParse(tboxB.Text, out b))
                {
                    throw new UpperLimitNotNumericException();
                }

                n = Convert.ToDouble(numUpDownN.Value);

                double Tn = TrapezoidRule(fx, a, b, (int)n);
                double Tn1 = TrapezoidRule(fx, a, b, (int)n + 1);
                double TRelErr = Math.Abs((Tn1 - Tn) / Tn) * 100;

                double Sn = SimpsonRule(fx, a, b, (int)n);
                double Sn2 = SimpsonRule(fx, a, b, (int)n + 2);
                double SRelErr = Math.Abs((Sn2 - Sn) / Sn) * 100;

                //MessageBox.Show(fx.getErrorMessage());

                labTResult.Text = $"Trapezoid Result = {Math.Round(Tn, 4)}";
                labTError.Text = $"Relative Error = {Math.Round(TRelErr, 4)}%";
                labSResult.Text = $"Simpson Result = {Math.Round(Sn, 4)}";
                labSError.Text = $"Relative Error = {Math.Round(SRelErr, 4)}%";

                labTResult.Visible = true;
                labTError.Visible = true;
                labSResult.Visible = true;
                labSError.Visible = true;

            }
            catch (LowerLimitNotNumericException)
            {
                MessageBox.Show("Lower Limit (a) must be a number.");
            }
            catch (UpperLimitNotNumericException)
            {
                MessageBox.Show("Upper Limit (b) must be a number.");
            }
            catch (MissingInputException)
            {
                MessageBox.Show("Missing Input.");
            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            tboxFx.Text = "";
            tboxA.Text = "";
            tboxB.Text = "";
            numUpDownN.Value = 2;

            labTResult.Text = "";
            labTError.Text = "";
            labSResult.Text = "";
            labSError.Text = "";

            labTResult.Visible = false;
            labTError.Visible = false;
            labSResult.Visible = false;
            labSError.Visible = false;
        }

        static private double TrapezoidRule(Function fx, double a, double b, int n)
        {
            double sum = 0;
            double deltaX = (b - a) / n;
            double[] intervals = new double[n + 1];
            double[] values = new double[n + 1];

            intervals[0] = a;
            intervals[n] = b;

            for (int i = 1; i < n; i++)
            {
                intervals[i] = (intervals[i - 1] + deltaX);
            }

            for (int i = 0; i < n+1; i++)
            {
                if (i == 0 || i == n)
                {
                    values[i] = fx.calculate(intervals[i]);
                }
                else
                {
                    values[i] = (2d * fx.calculate(intervals[i]));
                }
            }

            //Console.WriteLine("\nTrapezoid Rule Values:");
            for (int i = 0; i < n+1; i++)
            {
                //Console.WriteLine($"f({intervals[i]}) = {values[i]}");
                sum += values[i];
            }
            double total = (deltaX / 2) * sum;

            //Console.WriteLine($"\nT{n} = {total}");

            return total;
        }

        static private double SimpsonRule(Function fx, double a, double b, int n)
        {
            double sum = 0;
            double deltaX = (b - a) / n;
            double[] intervals = new double[n + 1];
            double[] values = new double[n + 1];

            intervals[0] = a;
            intervals[n] = b;

            for (int i = 1; i < n; i++)
            {
                intervals[i] = (intervals[i - 1] + deltaX);
            }

            for (int i = 0; i < n + 1; i++)
            {
                if (i == 0 || i == n)
                {
                    values[i] = fx.calculate(intervals[i]);
                }
                else if (i%2 == 1)
                {
                    values[i] = (4d * fx.calculate(intervals[i]));
                }
                else
                {
                    values[i] = (2d * fx.calculate(intervals[i]));
                }
            }

            //Console.WriteLine("\nSimpson Rule Values:");
            for (int i = 0; i < n + 1; i++)
            {
                Console.WriteLine($"f({intervals[i]}) = {values[i]}");
                sum += values[i];
            }

            double total = (deltaX / 3) * sum;

            //Console.WriteLine($"\nS{n} = {total}");

            return total;
        }
    }

    public class LowerLimitNotNumericException : Exception
    {
        public LowerLimitNotNumericException() { }
    }
    public class UpperLimitNotNumericException : Exception
    {
        public UpperLimitNotNumericException() { }
    }

    public class MissingInputException : Exception
    {
        public MissingInputException() { }
    }
}
