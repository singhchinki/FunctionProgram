using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    internal class Factor
    {
        public void factor()
        {
            Console.WriteLine("Enter the number for factorial");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("factorial of given number is" + n);
            for (int i = 2; i < n; i++)
            {
                while (n % i == 0)
                {
                    Console.WriteLine(i + "");
                    n = n / i;
                }
            }
            if(n>2)
            {
                Console.WriteLine(n);
            }
        }
    }
}
