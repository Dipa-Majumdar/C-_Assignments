using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_from_Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,count=0;
            string a = "tomato";
            string p = "Potato";
            string b;
            Console.WriteLine("First Answers:");
            Console.WriteLine();
            string[] food = { "Tomato", "Potato", "ToMato", "Potato", "Red Tomato", "Tomato  Catchup", "Grapes", "grapes", "potato" };
            Console.Write("Index of the list where exact “Potato”(case sensitive) word is there:");
            for (i = 0;i< food.Length;i++)
            {
               b = food[i];
                bool com=string.Equals(a, b, StringComparison.CurrentCultureIgnoreCase);
                if (com)
                {
                    count++;
                }
                if(p.Equals(b))
                {
                    Console.Write(i+", ");
                }
            }
            Console.WriteLine();
            Console.WriteLine("Number of type of string ‘tomato’(case insensititve) in inventory :"+count);
            Console.WriteLine();
            Console.WriteLine("Second Answers:");
            Console.WriteLine();
            float num1 = 0.06f;
            float num2 = 5.94f;
            float ans;
            ans = num1 + num2;
            Console.WriteLine($"The Sum of 0.06f and 5.94f is:{ans}");
            if(ans.Equals(6))
            {
                Console.WriteLine("Summation of 0.06f and 5.94f is 6");
            }

            if(num1>num2)
            { Console.WriteLine("X is greater than Y"); }
            else { Console.WriteLine("Y is greater than X"); }

        }
    }
}
