using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public delegate void ResultCallbackDelegate(int results);
    internal class NumberHelper
    {
        private int _Number;
        private ResultCallbackDelegate _resultCallbackDelegate;


        public NumberHelper(int Number, ResultCallbackDelegate resultCallbackDelegate)
        {
            _Number = Number;
            _resultCallbackDelegate = resultCallbackDelegate;
        }

        public void CalculateSum() {
            int result = 0;
            for (int i = 0; i <= _Number; i++)
            {
                result += i;
            }
            if (_resultCallbackDelegate != null) {
                _resultCallbackDelegate(result);
            }
        }
        
    }
}
