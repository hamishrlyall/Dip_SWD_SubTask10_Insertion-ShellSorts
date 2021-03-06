using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Dip_SWD_SubTask10_LinearSearch_BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var reader = new StreamReader(@"D:\Users\Hamish\source\repos\Dip_SWD_SubTask10_Insertion-ShellSorts\unsorted_numbers.csv"))
            {
                //Reads every element in file and adds it to a string list.
                List<string> listA = new List<string>();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(' ');
                    listA.Add(values[0]);
                }
                //Converts string list into int list
                List<int> listB = listA.Select(int.Parse).ToList();
                //Then converts int list into int array (If there's a better way to do this I'd like to know about it.)
                int[] arrayB = listB.ToArray();
                Array.Sort(arrayB);
                //foreach (var element in arrayB)
                //Console.WriteLine(element);
                //Console.WriteLine(LinearSearch(ref arrayB, 100));
                Console.WriteLine(LinearSearchMaxValue(ref arrayB));
                //Console.WriteLine(Every1500thNum(arrayB));


                Console.WriteLine("Done");
                Console.ReadKey();
            }
        }

        public static int LinearSearchMaxValue (ref int[] x)
        {
            int maxValue = x[0];
            for (int i = 1; i < x.Length; i++)
            {
                if (x[i] > maxValue)
                    maxValue = x[i];
            }
            return maxValue;
        }
        public static int LinearSearch(ref int[] x, int valueToFind)
        {
            for (int i = 0; i < x.Length; i++)
            {
                if (valueToFind == x[i])
                {
                    return i;
                }
            }
            return -1;
        }
        public static List<int> Every1500thNum(int[] x)
        {
            int arrayLength = x.Length;
            List<int> every1500thlist = new List<int>();
            int n = 1;
            while (arrayLength > 0)
            {
                while (n % 1500 != 0)
                {
                    n++;
                }
                if (n % 1500 == 0)
                {
                    every1500thlist.Add(x[n]);
                }
                arrayLength--;
            }
            return every1500thlist;
        }

    }
}
