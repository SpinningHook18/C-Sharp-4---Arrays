using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] name = new string[10] { "Ann", "Bilal", "Chris", "Emma", "Farrah", "Greg", "Harry", "Ian", "Joe", "Kamal" };
            int[] mark = new int[10] { 75, 67, 90, 58, 82, 34, 73, 46, 89, 76 };
            string nameInput;
            bool found = false;
            int pass = 60;
            Console.WriteLine("Enter a name:");
            nameInput = Console.ReadLine();
            for (int i = 0; i < 10; i++)
            {
                if (nameInput == name[i])
                {
                    Console.WriteLine("{0}", mark[i]);
                    if (mark[i] >= pass)
                    {
                        Console.WriteLine("Pass");
                    }
                    else
                    {
                        Console.WriteLine("Fail");
                    }
                    found = true;
                }
                else if (i == 9 && found == false)
                {
                    Console.WriteLine("Name not found");
                }
            }
            Console.ReadLine();
        }
    }
}
