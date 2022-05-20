using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    internal class QuotientRemander
    {
        public void divide()
        {
            Console.WriteLine("Enter the number for dividend");
            int dividend =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the divisor");
            int divisor  = Convert.ToInt32(Console.ReadLine());
            double quotient = dividend / divisor;
            double remander = dividend % divisor;
            Console.WriteLine("Quotient is" + quotient);
            Console.WriteLine("Remander is" + remander);
        }
    }
}
