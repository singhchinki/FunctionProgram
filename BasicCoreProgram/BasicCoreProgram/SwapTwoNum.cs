using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    internal class SwapTwoNum
    {
        public void change()
        {
            Console.WriteLine(" Enter the  first number:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("show the number before swap A:" + a + "B:" + b );
            int swap = a;
            a = b;
            b = swap;
            Console.WriteLine("After Swapping A and B" + a + b);
            
        }
    }
}
