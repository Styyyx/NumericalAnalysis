using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumAnal_TaylorSeries
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("NUMERICAL ANALYSIS\nTAYLOR'S POLYNOMIAL SERIES\nROUNDING");

            Console.WriteLine("\nChoose a function to solve:");
            Console.WriteLine("[1] cos(x)\n[2] sin(x)*e^x");
            int whichFunction = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nEnter a real or complex number (a): ");
            double a = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Enter a real or complex number (x): ");
            double x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the degree of taylor's polynomial (n): ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter number of decimal places (d): ");
            int d = Convert.ToInt32(Console.ReadLine());

            GetTaylorSeries(whichFunction, a, x, n, d);
            Console.ReadLine();
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
    }
}
