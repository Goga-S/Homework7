using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_7._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter circle radius");
            var inputRes = int.TryParse(Console.ReadLine(), out int radius);
            if(inputRes)
            {
                // 2 * radius ანუ წრის დიამეტრი დიდი კვადრატის გვერდია
                var bigQArea = 4 * radius * radius; 
                /*პატარა კვადრატის ფართობი შეგვიძლია წარმოვიდგინოთ ორი სამკუთხედის ფართობის ჯამად.
                 რომელიც თავის მხრივ ფუძის (= დიამეტრის) და მასზე მართობულად დაშვებული სიმაღლის (= რადიუსის) 
                 ნამრავლის ნახევარია*/
                var smallQArea = 2 * radius * radius; 
                Console.WriteLine(bigQArea - smallQArea);
            }else
            {
                Console.WriteLine("enter valid number");
            }
        }
    }
}
