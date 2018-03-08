using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculate
    {
        private double _num1;
        private double _num2;
        private double _total;

        public double total
        {
            get
            {
                return _num1;
            }
            set
            {
                _num1 = value;
            }
        }
        public double num2
        {
            get
            {
                return _num2;
            }
            set
            {
                _num2 = value;
            }
        }
        
        public double num1
        {
            get
            {
                return _num1;
            }
            set
            {
                _num1 = value;
            }
        }

        public void multiply()
        {
            _total = num1 * num2;
        }

        public void divide()
        {
            _total = num1 / num2;
        }
        
        public void add()
        {
            _total = num1 + num2;
        }

        public void subtract()
        {
            _total = num1 - num2;
        }
    }
}
