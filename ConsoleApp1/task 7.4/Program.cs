using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace task_7._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var hrsPerDayArr = new List<int>();
            var cnt = 0;
            Console.WriteLine("enter number of hours for each day of a week:");
            while(cnt < 7)
            {
                hrsPerDayArr.Add(int.Parse(Console.ReadLine()));
                cnt++;
            }
            const int ratePerHr = 10;
            const double indForOvertime = 1.5;
            const int indForWeekend = 2;

            double sum = 0;

            for (int i = 0; i < 7; i++) 
            { 
                if (i <= 4 && hrsPerDayArr[i] <= 8)
                {
                    sum += hrsPerDayArr[i] * ratePerHr;
                }
                else if (i <= 4 && hrsPerDayArr[i] > 8)
                {
                    sum += 8 * ratePerHr + ((hrsPerDayArr[i] - 8) * ratePerHr * indForOvertime);
                }else if (i > 4)
                {
                    sum += hrsPerDayArr[i] * ratePerHr * indForWeekend;
                }
            }

            Console.WriteLine(sum);


        }
    }
}
