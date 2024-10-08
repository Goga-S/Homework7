using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Task_7._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var charList = new List<char>();
            Console.WriteLine("Enter characters to exit enter e ");
            while (true) { 
                
                var cr = char.Parse(Console.ReadLine());
                if(cr != 'e')
                {
                    charList.Add(cr);
                } else
                {
                    break;
                }
                
                 
            }

            var l = charList.Count;

            for (int i = 1; i < l; i++)
            {

                if (charList[0] != charList[i])
                {
                    Console.WriteLine("No");
                    break;
                } else if (charList[0] == charList[l - 1])
                {
                    Console.WriteLine("Yes");
                }
            }
            
        }
    }
}
