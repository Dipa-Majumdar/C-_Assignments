using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Product
    {
        public string name { get; set; }
        public float price { get; set; }
        public int quantity { get; set; }
        public string type { get; set; }


        public string Output()
        {
            return name + " " + price + " " + quantity + " " + type;
        }

    }//end of class product
    class Program
    {
        public static void Main(string[] args)
        {
            float sum = 0.0f,average=0.0f;int check;
            List<string> type_leafy = new List<string>();
            List<string> type_cruciferous = new List<string>();
            List<string> type_marrow = new List<string>();
            List<string> cheap = new List<string>();
            List<string> costly = new List<string>();
            List<Product> product_list = new List<Product>();
            product_list.Add(new Product() { name = "lettuce", price = 10.5f, quantity = 50, type = "Leafy green" });
            product_list.Add(new Product() { name = "cabbage", price = 20, quantity = 100, type = "Cruciferous" });
            product_list.Add(new Product() { name = "pumpkin", price = 30, quantity = 30, type = "Marrow" });
            product_list.Add(new Product() { name = "cauliflower", price = 10, quantity = 25, type = "Cruciferous" });
            product_list.Add(new Product() { name = "zucchini", price = 20.5f, quantity = 50, type = "Marrow" });
            product_list.Add(new Product() { name = "spinach", price = 10, quantity = 100, type = "Leafy green" });
            product_list.Add(new Product() { name = "yam", price = 30, quantity = 50, type = "Root" });
            product_list.Add(new Product() { name = "broccoli", price = 20.5f, quantity = 75, type = "Cruciferous" });
            product_list.Add(new Product() { name = "Garlic", price = 30, quantity = 20, type = "Leafy green" });
            product_list.Add(new Product() { name = "silverbeet", price = 10, quantity = 50, type = "Marrow" });

            foreach (Product prod in product_list)
            {
                
                string a = prod.type;
                switch (a)
                {
                    case "Leafy green":
                        type_leafy.Add(prod.name);
                        break;
                    case "Cruciferous":
                        type_cruciferous.Add(prod.name);
                        break;
                    case "Marrow":
                        type_marrow.Add(prod.name);
                        break;
                   
                }
            }
            Console.WriteLine("The Product of type Leafy green is:");
            foreach (string prod in type_leafy) {
                Console.WriteLine(prod);
            }
            Console.WriteLine("The Product of type Cruciferous is:");
            foreach (string prod in type_cruciferous)
            {
                Console.WriteLine(prod);
            }
            Console.WriteLine("The Product of type Marrow is:");
            foreach (string prod in type_marrow)
            {
                Console.WriteLine(prod);
            }
            foreach (Product prod in product_list)
            {
                sum = sum + (prod.price*prod.quantity);
            }
            Console.WriteLine($"the total prize of whole Inventory including the quantities of products:{sum}");
            average = sum / product_list.Count;
            Console.WriteLine($"Average price product is:{average}");
            foreach(Product prod in product_list)
            {
                if (prod.price > 50)
                {
                    check = 1; }
                else { check = 0; }
               
                switch (check)
                {
                    case 0: cheap.Add(prod.name); break;
                    case 1: costly.Add(prod.name); break;
                }
            }
            Console.WriteLine("The Cheap products are(if any):");
            foreach(string a in cheap)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine("The products are(if any):");
            foreach (string a in costly)
            {
                Console.WriteLine(a);
            }
        }
    }
}
