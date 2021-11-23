using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_4._5
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence;
            int counter = 0;
            Console.WriteLine("Enter a sentence:");
            sentence = Console.ReadLine();
            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] == ' ')
                {
                    counter++;
                }
            }
            Console.WriteLine("{0}", counter + 1);
            Console.ReadLine();
        }
    }
}
