using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var scoreRecords = new List<int>();
            var count = 1;
            const int indexW = 3, indexD = 1, indexL = 0;
            Console.WriteLine("Enter numbers for Wins, Draws and Loses with that order: ");
            while (count < 4)
            {
                var win = int.TryParse(Console.ReadLine(), out int quant);
                scoreRecords.Add(quant);
               
                count++;
            }
            var sum = scoreRecords[0]*indexW + scoreRecords[1]*indexD + scoreRecords[2]*indexL;

            Console.WriteLine($"total points are: {sum}");
            
        }
    }
}
