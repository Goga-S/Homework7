using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_7._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
            Console.WriteLine("Enter daily progress in numbers, please separate numbers by commas ");
            var progressList =  (Console.ReadLine().Split(',').ToList()).ConvertAll<int>(int.Parse);
            
                
            
            var progressCounter = 0;

            for (int i = 1; i < progressList.Count; i++)
            {
                if (progressList.Count > 1)
                {
                    if (progressList[i - 1] < progressList[i])
                    {
                        progressCounter++;
                    }
                }
            }
            Console.WriteLine($"output: {progressCounter}");
            
        }
    }
}
