using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem
{
    public class Product 
    {
        public string name { get; set; }
        public double price { get; set; }
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
            List<Product> product_list = new List<Product>();
            product_list.Add(new Product() { name = "lettuce", price = 10.5, quantity = 50, type = "Leafy green" });
            product_list.Add(new Product() { name = "cabbage", price = 20, quantity = 100, type = "Cruciferous" });
            product_list.Add(new Product() { name = "pumpkin", price = 30, quantity = 30, type = "Marrow" });
            product_list.Add(new Product() { name = "cauliflower", price = 10, quantity = 25, type = "Cruciferous" });
            product_list.Add(new Product() { name = "zucchini", price = 20.5, quantity = 50, type = "Marrow" });
            product_list.Add(new Product() { name = "spinach", price = 10, quantity = 100, type = "Leafy green" });
            product_list.Add(new Product() { name = "yam", price = 30, quantity = 50, type = "Root" });
            product_list.Add(new Product() { name = "broccoli", price = 20.5, quantity = 75, type = "Cruciferous" });
            product_list.Add(new Product() { name = "Garlic", price = 30, quantity = 20, type = "Leafy green" });
            product_list.Add(new Product() { name = "silverbeet", price = 10, quantity = 50, type = "Marrow" });


            Console.WriteLine($"Total Number of Product in a list is {product_list.Count}");
            product_list.Add(new Product() { name = "Potato", price = 10, quantity = 50, type = "Root" });
            Console.WriteLine($"Total Number of Product in a list after adding another element is {product_list.Count}");
            Console.WriteLine("which are as follows:");
            foreach (Product prod in product_list)
            { Console.WriteLine(prod.Output()); }
            Console.WriteLine("The Products whose type is Leafy green are as follows:");
            foreach (Product prod in product_list)
            {
                if (prod.type == "Leafy green")
                {
                    Console.WriteLine(prod.name);
                }
            }
            //foreach (Product prod in product_list)
            //{
            //    if (prod.name == "Garlic")
            //    {
            //        product_list.Remove();
            //    }
            //}
            var item = product_list.Single(x => x.name == "Garlic");
            product_list.Remove(item);
            Console.WriteLine("Total number of products left:" + product_list.Count);
            foreach(Product prod in product_list)
                {
                if (prod.name == "cabbage")
                {
                    prod.quantity = prod.quantity + 50;
                    Console.WriteLine("The total number of cabbage is:" + prod.quantity );
                }
                }
            double usermoney=0.0;
            foreach (Product prod in product_list)
            {
                if(prod.name== "lettuce")
                { usermoney = usermoney + prod.price; }
                if(prod.name== "zucchini")
                { usermoney = usermoney + (2 * prod.price); }
                if(prod.name== "broccoli")
                { usermoney = usermoney + prod.price; }
            }
            Console.WriteLine("User have to spend approximately "+ "Rs "+Convert.ToInt32(usermoney));
            
        }
    }
            
}

    

        


