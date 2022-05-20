using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    internal class EvenOdd
    {
        public void computation()
        {
            Console.WriteLine("Enter number to check its even or odd value");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 0)
                Console.WriteLine("Given number is even");
            else
                Console.WriteLine("Given Number is odd");
        }
    }
}
