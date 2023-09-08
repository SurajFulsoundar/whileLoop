using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whileLoop
{
    internal class divisibleBy3
    {
        static void Main(string[] args)
        {
            int i = 1;

            while(i <= 30)
            {
                if(i % 3 == 0)
                {
                    Console.WriteLine(i);

                }
                i++;
            }
        }

       
    }
}
