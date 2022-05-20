using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    internal class PowerOf2
    {
            public void PowerOf()
            {
                Console.WriteLine("Power of Two");
                Console.WriteLine("Enter the value of N : ");
                int N = Convert.ToInt16(Console.ReadLine());
                for (int i = 0; i < N; i++)
                {
                    int power;
                    power = (int)Math.Pow(2, i);
                    Console.WriteLine("2 to the power of {0} is {1} ", i, power);
                }
            }
        }
    }

