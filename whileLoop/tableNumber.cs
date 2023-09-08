using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whileLoop
{
    internal class tableNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number ");
            int num = Convert.ToInt32(Console.ReadLine());

            int i = 1;

            while (i <= 10)
            {
              int result = num * i;
                Console.WriteLine(result);
                i++;

            }
            
        }

        
    }
}
