using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Interface_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculation calculation = new Calculation();
            int x = 20;
            int y = 5;
            Console.WriteLine("The value of x & y are: " + x + " and " + y + "\n");
            Console.WriteLine(x + " Power " + y + " = " + calculation.XtoY(x, y));
            Console.WriteLine(x + " + " + y + " = " + calculation.sum(x, y));
            Console.WriteLine(x + " - " + y + " = " + calculation.sub(x, y));
            Console.WriteLine(x + " * " + y + " = " + (calculation.multiplication(x, y)));
            Console.WriteLine(x + " / " + y + " = " + calculation.division(x, y));


            Console.ReadLine();
        }
    }
}
