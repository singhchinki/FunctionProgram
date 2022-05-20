using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    internal class HarmonicNum
    {
        public void harmonic()
        {
            Console.WriteLine("Enter the number");
            int n =Convert.ToInt32(Console.ReadLine());
            float num = 1;
            if(n != 0)
            {
                for (float i = 2; i <= n; i++)
                {
                    num = num + (1/i);
                }
                Console.WriteLine("harmonic number is" + num);
            }
        }
    }
}
