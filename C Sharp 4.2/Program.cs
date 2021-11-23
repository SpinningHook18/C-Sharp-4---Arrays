using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32 [] nums= new Int32[10];
            Int32 num, total = 0, average;
            for (Int32 i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter a number:");
                num = Convert.ToInt32(Console.ReadLine());
                nums[i] = num;
                total = total + num;
            }
            average = total / 10;
            for (Int32 j = 0; j < 10; j++)
            {
                if (nums[j] > average)
                {
                    Console.WriteLine("{0}", nums[j]);
                }
            }
            Console.ReadLine();
          
        }
    }
}
