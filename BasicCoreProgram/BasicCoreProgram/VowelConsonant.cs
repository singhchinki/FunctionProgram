using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    internal class VowelConsonant
    {
        public void Vowel()
        {
            Console.WriteLine("Enter any alphabet to check:");
            char a = Convert.ToChar(Console.ReadLine());
            if (a == 'a' || a == 'e' || a == 'i' || a == '0' || a == 'u')
                Console.WriteLine(" Given alphabet is vowel");
            else
                Console.WriteLine(" Given alphabet is consonant");
        }
    }
}
