using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Numerical_Integration
{
    class PreParser
    {
        static private List<string> keywords = new List<string>()
        {
            "pi",
            "sin",
            "cos",
            "tan",
            "sqrt",
            "e",
        };
        static private List<string> operators = new List<string>() { "+", "-", "/", "*", "^" };

        static public string PreParse(string eq)
        {
            try
            {
                List<string> tree = new List<string>() { };
                List<int> keyStarts = new List<int>() { };
                List<int> keyLengths = new List<int>() { };
                int groupCount = 0;

                eq = eq.Replace(" ", String.Empty);

                foreach (string key in keywords)
                {
                    foreach (Match match in Regex.Matches(eq, key))
                    {
                        //Mark its start index and length
                        keyStarts.Add(match.Index);
                        keyLengths.Add(match.Length);
                    }
                }

                int k = 0;
                while (k < eq.Length)
                {
                    if (keyStarts.Contains(k))
                    {
                        if (tree.Count != 0 && !operators.Contains(tree[tree.Count - 1]))
                        {
                            tree.Add("*");
                        }
                        int length = keyLengths[keyStarts.IndexOf(k)];
                        tree.Add(eq.Substring(k, length));
                        k += length;
                        continue;
                    }
                    string curr = eq.Substring(k, 1);

                    if (tree.Count == 0 && curr != "-")
                    {
                        tree.Add(curr);
                    }
                    else if (int.TryParse(curr, out _))
                    {
                        if (int.TryParse(tree[tree.Count - 1], out _))
                        {
                            tree[tree.Count - 1] += curr;
                        }
                        else
                        {
                            tree.Add(curr);
                        }
                    }
                    else if (operators.Contains(curr))
                    {
                        if ((curr == "-" || curr == "+") && (tree.Count == 0 || operators.Contains(tree[tree.Count - 1])))
                        {
                            tree.Add("0");
                            tree.Add(curr);
                        }
                        else { tree.Add(curr); }
                    }
                    else if (curr == "(" || curr == ")")
                    {
                        if (curr == "(")
                        {
                            if (int.TryParse(tree[tree.Count - 1], out _))
                            {
                                tree.Append("*");
                            }
                            tree.Add(curr);
                            groupCount++;
                        }
                        else
                        {
                            if (groupCount > 0 && !operators.Contains(tree[tree.Count - 1]))
                            {
                                tree.Add(curr);
                                groupCount--;
                            }
                            else { throw new InvalidGroupingsException(); }
                        }
                    }
                    else if (Regex.IsMatch(curr, @"[a-zA-Z]"))
                    {
                        if (curr == "x")
                        {
                            if (int.TryParse(tree[tree.Count - 1], out _))
                            {
                                tree.Add("*");
                            }
                            tree.Add(curr);

                        }
                        else if (curr == "x" && tree.Count == 0)
                        {
                            tree.Add(curr);
                        }
                        else
                        {
                            throw new VariableXOnlyException();
                        }
                    }
                    else
                    {
                        throw new CannotProcessFunctionStringException();
                    }
                    k++;
                }

                return string.Join("", tree);
            }
            catch (InvalidGroupingsException)
            {
                MessageBox.Show("Invalid groupings in function string.");
            }
            catch (VariableXOnlyException)
            {
                MessageBox.Show("Function string only accepts \'x\' as variable.");
            }
            catch (CannotProcessFunctionStringException)
            {
                MessageBox.Show("Cannot process function string. Something's wrong");
            }
            return "An Error Occurred.";
        }
    }

    public class InvalidGroupingsException : Exception
    {
        public InvalidGroupingsException() { }
    }

    public class CannotProcessFunctionStringException : Exception
    {
        public CannotProcessFunctionStringException() { }
    }

    public class VariableXOnlyException : Exception
    {
        public VariableXOnlyException() { }
    }
}
