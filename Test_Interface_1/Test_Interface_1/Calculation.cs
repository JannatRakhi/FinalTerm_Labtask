using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Interface_1
{
    class Calculation : ScientificCalculatorInterface, BasicCalculatorInterface
    {

        public int XtoY(int x, int y)
        {

            return Convert.ToInt32(Math.Pow(x, y));

        }


        public int sum(int x, int y)
        {
            return x + y;
        }


        public int sub(int x, int y)
        {
            return x - y;
        }


        public int multiplication(int x, int y)
        {
            return x * y;
        }


        public int division(int x, int y)
        {
            return x / y;
        }

    }
}
