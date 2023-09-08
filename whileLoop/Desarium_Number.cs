using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whileLoop
{
    internal class Desarium_Number
    {
                                               /* For example: num = 135  ----->  1 power 1
                                                                                     +
                                                                                 3 power 2
                                                                                     +
                                                                                 5 power 3 = 135.
                                                this  number is called desarium number. */
        static void Main(string[] args)
        {
            Console.WriteLine(" Enter a number ");
            int num = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
            int remd = 0;
            int count = 0;
            int temp = num;
            

            while (num != 0)
            {
                count++;
                num = num / 10;          

            }
            num = temp;

            while (num != 0)
            {
                remd = num % 10;
                int power = 1;

                for(int i = 1; i <= count; i++)
                {
                    power = power * remd;

                }
                 sum = sum + power;
                 count--;
                 num = num / 10;

            }
            if (sum == temp)
            {
                Console.WriteLine(" Number is Desarium ");
            }
            else
            {
                Console.WriteLine(" Not Desarium ");
            }
        }
    }
}
