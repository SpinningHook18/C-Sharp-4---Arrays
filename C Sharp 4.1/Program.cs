using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[5];
            for (Int32 i = 0; i <= 4; i = i + 1)
            {
                Console.WriteLine("Enter a name:");
                names[i] = Console.ReadLine();
            }
            for (Int32 i = 0; i <= 4; i = i + 1)
            {
                Console.WriteLine(names[4 - i]);
            }

            Console.ReadLine();
        }
    }
}
