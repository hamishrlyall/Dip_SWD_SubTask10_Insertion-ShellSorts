using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Dip_SWD_SubTask10_Insertion_ShellSorts
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var reader = new StreamReader(@"D:\Users\Hamish\source\repos\Dip_SWD_SubTask10_Insertion-ShellSorts\unsorted_numbers.csv"))
            {
                List<string> listA = new List<string>();
                while(!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');
                    listA.Add(values[0]);
                }

                foreach (var element in listA)
                    Console.WriteLine(element);

                Console.WriteLine("Done");
                Console.ReadKey();
            }
        }
    }
}
