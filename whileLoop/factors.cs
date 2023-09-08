using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whileLoop
{
    internal class factors
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Enter a number ");
            int num = Convert.ToInt32(Console.ReadLine());

            int i = 2;
            while(i <= num)      
            {
                if(num % i == 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }
        }
    }
}
