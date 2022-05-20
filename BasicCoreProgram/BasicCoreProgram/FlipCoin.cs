using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    internal class FlipCoin
    {
        public void flipCoin()
        {
            int head = 0;
            int tail = 0;
            Random random = new Random();
            Console.WriteLine("coin flip number");
            int count = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                double flip = random.NextDouble();
                if (flip < 0.5)
                {
                    head ++;
                }
                else
                {
                    tail ++;
                }
            }
            double headPer = head + 100 / count;
            double tailPer = tail + 100 / count;
            Console.WriteLine("Percentage of Heads is:" + headPer + "%");
            Console.WriteLine("Percentage of Heads is:" + tailPer + "%");

        }
    }
}

