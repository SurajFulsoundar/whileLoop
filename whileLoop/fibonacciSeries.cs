using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whileLoop
{
    internal class fibonacciSeries
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter series number ");
            int num = Convert.ToInt32(Console.ReadLine());

            int f1 = 0;
            int f2 = 1;
            int f3 = 0;

            int i = 1;
            while (i <= num)
            {
                f3 = f1 + f2;
                Console.WriteLine(f3);
                f1 = f2;
                f2 = f3;
                i++;
            }
        }
    }
}
