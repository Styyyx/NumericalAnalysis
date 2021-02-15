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

        }

        ///<summary>
        ///Generates a Taylor Series with the chosen function and up to number of terms based on degree input.
        ///</summary>
        ///
        ///<param name="func">
        ///Determines which function to use, takes only 1 or 2 as input:
        /// 1 = cos(x),
        /// 2 = sin(x)*e^x
        ///</param>
        ///
        ///<param name="degree">
        ///The degree to which the series will be generated to. 0 to pos infinity.
        ///</param>
        static public List<PolyTerm> GetTaylorSeries(int func, int degree)
        {
            List<PolyTerm> TS = new List<PolyTerm> { };

            // cos(x)
            if (func == 1)
            {
                TS.Add(new PolyTerm('+', 1, "cos(x)"));
                
                for (int i = 0; i < degree; i++)
                {
                    TS.Add(Derive(TS[i], 1));
                }
            }
            // sin(x)*e^x
            else if (func == 2)
            {

            }

            return TS;
        }

        static public List<PolyTerm> GetPolynomial(int func, int degree)
        {

        }

        static public PolyTerm Derive(PolyTerm x, int func)
        {
            string x_textForm = x.TextForm;

            char tempSign = '+';
            int tempCoeff = 0;
            string tempVar = "";

            if (func == 1)
            {
                if (x_textForm == "+ cos(x)")
                {
                    tempSign = '-';
                    tempCoeff = 1;
                    tempVar = "sin(x)";
                }
                else if (x_textForm == "- sin(x)")
                {
                    tempSign = '-';
                    tempCoeff = 1;
                    tempVar = "cos(x)";
                }
                else if (x_textForm == "- cos(x)")
                {
                    tempSign = '+';
                    tempCoeff = 1;
                    tempVar = "sin(x)";

                }
                else if (x_textForm == "+ sin(x)")
                {
                    tempSign = '+';
                    tempCoeff = 1;
                    tempVar = "cos(x)";
                }
            }
            else if (func == 2)
            {

            }

            return new PolyTerm(tempSign, tempCoeff, tempVar);
        }
    }
}
