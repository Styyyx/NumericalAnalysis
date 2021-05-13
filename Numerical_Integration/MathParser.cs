using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Numerical_Integration
{
    class MathParser
    {
        static string[] operators = new string[] { "+", "-", "*", "/" };
        static string[] groupingSymbols = new string[] { "(", ")" };
        static string[] keywords = new string[]{"e","pi","sin","cos","tan","sec","csc","cot","sqrt"};
        static public void Parse(string equation)
        {
            //Remove all spaces
            equation = equation.Replace("",String.Empty);
            List <int> keyStarts = new List<int> { };
            List<int> keyLength = new List<int> { };

            List<string> tree = new List<string> { };

            // Check each keyword if it exists in the equation
            foreach (string key in keywords)
            {
                foreach (Match match in Regex.Matches(equation, key))
                {
                    //Mark its start index and length
                    keyStarts.Add(match.Index);
                    keyLength.Add(match.Length);
                }
            }

            // Current index in parsing equation
            int k = 0;
            while (k < equation.Length)
            {
                // Check and retrieve if current index is a keyword start
                if (keyStarts.Contains(k))
                {
                    // Check if tree is not empty and the last item of tree is not in operators
                    if (tree.Count != 0 && !operators.Contains(tree[tree.Count - 1]))
                    {
                        // Add * for cases when user uses parenthesis as subsitute for *
                        tree.Add("*");
                    }
                    int length = keyLength[keyStarts.IndexOf(k)];

                    // Retrieve the keyword and add to tree
                    tree.Add(equation.Substring(k, length));

                    // Set keyword's last index as current index in parsing
                    k = k + length;
                    continue;
                }

                // Get current char by index
                string current = equation.Substring(k, 1);

                if (tree.Count != 0 && current != "-")
                {
                    tree.Add(current);
                }
                else if (int.TryParse(current, out _))
                {
                    if (int.TryParse(tree[tree.Count-1], out _))
                    {
                        tree[tree.Count - 1] += current;
                    }
                    else
                    {
                        tree.Add(current);
                    }
                }

            }
        }
    }
}
