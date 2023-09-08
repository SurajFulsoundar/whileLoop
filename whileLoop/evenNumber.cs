using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whileLoop
{
    internal class evenNumber
    {
        static void Main(string[] args)
        {
            int num = 1;

            while (num <= 100)
            {
                if (num % 2 == 0)
                {
                    Console.WriteLine($"The even number is{num}");
                }
                num++;
            }
        }
    }
}
