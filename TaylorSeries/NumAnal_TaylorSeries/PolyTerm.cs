using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumAnal_TaylorSeries
{
    // Class for Polynomial Terms
    // A term is divided into: _sign, _coeffecient, _variable
    public class PolyTerm
    {
        // + or - only
        private char _sign;

        // positive ints only
        private int _coefficcient;

        //may include '/' and '^'
        //best to populate with '()'
        private string _variable;

        // if _coefficient == 1, it is removed in _textForm
        private string _textForm;

        public PolyTerm(char sign, int coefficient, string variable)
        {
            _sign = sign;
            _coefficcient = coefficient;
            _variable = variable;

            if (_coefficcient != 1)
            {
                _textForm = $"{_sign} {_coefficcient}{_variable}";
            }
            else
            {
                _textForm = $"{_sign} {_variable}";
            }
        }

        public string TextForm
        {
            get { return _textForm; }
        }

        public char Sign
        {
            get { return _sign; }
        }

        private int Coefficient
        {
            get { return _coefficcient; }
        }
    }
}
