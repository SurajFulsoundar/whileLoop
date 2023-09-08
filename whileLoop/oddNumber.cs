using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whileLoop
{
    internal class oddNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Enter a number ");
            int num = Convert.ToInt32(Console.ReadLine());

            int i = 1;

            while (i <= num)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine($"The odd numbe is {i}");
                    
                }
                i++;
            }
          

            
        }
    }
}
