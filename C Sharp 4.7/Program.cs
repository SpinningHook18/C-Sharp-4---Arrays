using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_4._7
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] tally = new int[6];
            int die;
            for (int i = 0; i < 30; i++)
            {
                die = rnd.Next(6);
                tally[die]++;
            }
            Console.WriteLine("Die Roll     Frequency");
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("   {0}             {1}", i + 1, tally[i]);
            }
            Console.ReadLine();
        }
    }
}
