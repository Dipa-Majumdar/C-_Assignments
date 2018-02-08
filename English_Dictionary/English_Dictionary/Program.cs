using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace English_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = { "Boat", "house", "cat", "river", "cupboard" };
            Console.WriteLine();
            int i;
            for(i=0;i<array.Length;i++)
            {
                array[i] = array[i] + "s";
            }
            Console.WriteLine("The Plural array is :");
            Console.WriteLine();
            foreach(string arr in array)
            {
                Console.Write(arr + " ");
            }
            Console.WriteLine();

            ArrayList arrayList = new ArrayList();
            arrayList.AddRange(array);
            arrayList.Add("newWord");
            Console.Write($"The Length of the array List is:{arrayList.Count}");
            Console.WriteLine();
            string[] array_new = arrayList.ToArray(typeof(string)) as string[];
            string[] var_array = Array.FindAll(array_new, x => x.Length == 7);
            Console.WriteLine("The List of words containing 7 characters are:");

            foreach (string item in var_array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            Console.WriteLine($"The word in Third Position is: {array_new[2]}");
            Array.Sort<string>(array_new);
            Console.WriteLine("The sorted array is: ");
            foreach (string arr in array_new)
            {
                Console.Write(arr + " ");
            }
            Console.WriteLine();
            Array.Reverse(array_new);
            Console.WriteLine("The reversed array is: ");
            foreach (string arr in array_new)
            {
                Console.Write(arr + " ");
            }
            Console.WriteLine();
        }
    }
}
