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
            GetTaylorSeries(2, 5, 5);
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
        ///The value to which the function will be evaluated to.
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


        static public void GetTaylorSeries(int whichFunction, double x, int n= 1, double a = 0)
        {
            double TV = 0;
            double EV = 0;
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

                    // Evaluate
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
            }

            Console.WriteLine($"True Value: {TV}\nEstimated Value: {EV}\nTaylor Series: {Pn}");
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
    }
}
