using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_7._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter words separated by commas");
            var wordsList = Console.ReadLine().Split(',').ToList();
            Console.WriteLine("enter a number to check if there are words of the number's length");
            var length = int.Parse(Console.ReadLine());

            var count = wordsList.Where(w => w.Length == length).Count();
            if (count > 0)
            {
                Console.WriteLine($"output: {count}");
            }else
            {
                Console.WriteLine("No elements are found");
            }
        }
    }
}
