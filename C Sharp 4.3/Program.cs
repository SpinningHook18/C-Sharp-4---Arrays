using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Int32[] number = new Int32[10] { 7, 12, 9, 3, 15, 4, 6, 8, 10, 5 };
            int[] multiple = new int[10];
            for (int i = 0; i < 10; i++)
            {
                multiple[i] = number[i] * i;
            }
            for (int j = 0; j < 10; j++)
            {
                Console.WriteLine("{0}", multiple[j]);
            }
            Console.ReadLine();
        }
    }
}
