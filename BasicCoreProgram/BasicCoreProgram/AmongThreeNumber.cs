using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    internal class AmongThreeNumber
    {
        public void large()
        {
            Console.WriteLine("Enter the number");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            if (a != b && a != c)
                Console.WriteLine("Largest number is" + a);
            else if (b > a && b> c)
                Console.WriteLine(" Largest number is" + b);
            else if (c > b && c > b)
                    Console.WriteLine(" Largest number is" + c);
        }
    }
}
