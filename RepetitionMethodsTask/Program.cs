using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepetitionMethodsTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr = {"Baki", "Sumgayit","Gence"};
            Console.WriteLine("Please enter a char");
            string input = Console.ReadLine();
            char c = Convert.ToChar(input);

            foreach (string word in arr)
            {
                foreach (char letter in word)
                {
                    if(c == letter)
                    {
                        Console.WriteLine("same");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Not Same");
                        return;
                    }
                }
            }
        }
    }
}
