using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace Prime_Minister_Dictionary
{
    public class Indian_Prime_Minister 
    {
        public string Name { get; set; }
        
        public Indian_Prime_Minister(string name)
        {
            this.Name = name;
           
        }
        public override string ToString()
        {
            return string.Format("{0}",Name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var primeMininsters = new Dictionary<string, Indian_Prime_Minister> {
                {"1998",new Indian_Prime_Minister("Atal Bihari Vajpayee")  },
                {"2014",new Indian_Prime_Minister("Narendra Modi") },
                {"2004",new Indian_Prime_Minister("Manmohan Singh") }
            };
            
            Indian_Prime_Minister pm = primeMininsters["2004"];
            Console.WriteLine($"The prime minister who got elected in 2004 is {pm}");
            primeMininsters.Add("2018",new Indian_Prime_Minister("Current Prime Minister") );
            Console.WriteLine("This year's prime minister is: "+primeMininsters["2018"]);


            ReadOnlyDictionary<string, Indian_Prime_Minister> readOnlyDict = new ReadOnlyDictionary<string, Indian_Prime_Minister>(primeMininsters);
            Console.WriteLine("the sorted dictionary is :");
            var list = readOnlyDict.Keys.ToList();
            list.Sort();
            foreach (var Key in list)
            {
                Console.WriteLine("{0}: {1}", Key, readOnlyDict[Key]);
            }
            
        }
    }
}
