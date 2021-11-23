using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Sharp_4._6
{
    class Program
    {
        static void Main(string[] args)
        {
            string word;
            int counter = 0;
            Console.WriteLine("Enter a word:");
            word = Console.ReadLine();
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'a' || word[i] == 'e' || word[i] == 'i' || word[i] == 'o' || word[i] == 'u')
                {
                    counter++;
                }
            }
            Console.WriteLine("{0}", counter);
            Console.ReadLine();
        }
    }
}
