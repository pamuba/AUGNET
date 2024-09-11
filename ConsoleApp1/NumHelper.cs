using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class NumHelper
    {
        int _Number;
        public NumHelper(int Number)
        {
            _Number = Number;   
        }

        public void DisplayNumbers()
        {
            for (int i = 0; i <= _Number; i++)
            {
                Console.WriteLine(i);
            }
        }

    }
}
