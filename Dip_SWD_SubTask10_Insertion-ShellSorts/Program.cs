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
        private static object strings;

        static void Main(string[] args)
        {
            using (var reader = new StreamReader(@"D:\Users\Hamish\source\repos\Dip_SWD_SubTask10_Insertion-ShellSorts\unsorted_numbers.csv"))
            {
                //Reads every element in file and adds it to a list.
                List<string> listA = new List<string>();
                while(!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(' ');
                    listA.Add(values[0]);
                }
                //Converts string list into int list
                List<int> listB = listA.Select(int.Parse).ToList();
                //Then converts int list into int array (If there's a better way to do this I'd like to know about it.)
                int[] arrayB = listB.ToArray();
                //Sorts array using methods below.
                //performInsertionSort(arrayB);
                performShellSort(arrayB);
                foreach (var element in arrayB)
                Console.WriteLine(element);
                Console.WriteLine("Done");
                Console.ReadKey(); 
            }

        }
        static int[] performInsertionSort(int[] inputarray)
        {
            for (int i = 0; i < inputarray.Length - 1; i++)
            {
                int j = i + 1;

                while (j > 0)
                {
                    if (inputarray[j - 1] > inputarray[j])
                    {
                        int temp = inputarray[j - 1];
                        inputarray[j - 1] = inputarray[j];
                        inputarray[j] = temp;

                    }
                    j--;
                }
            }
            return inputarray;
        }

        static int[] performShellSort(int[] array)
        {
            int n = array.Length;
            int gap = n / 2;
            int temp;

            while (gap > 0)
            {
                for (int i = 0; i + gap < n; i++)
                {
                    int j = i + gap;
                    temp = array[j];

                    while (j - gap >= 0 && temp < array[j - gap])
                    {
                        array[j] = array[j - gap];
                        j = j - gap;
                    }

                    array[j] = temp;
                }

                gap = gap / 2;
            }
            return array;
        }
    }
}
