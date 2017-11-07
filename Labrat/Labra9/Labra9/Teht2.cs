using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra9
{
    class Product
    {
        public double Price{ get; set; }
        public string Name { get; set; }

        public Product(string name, double price)
            {
            Name = name;
            Price = price;
            }

    }

    class Teht2
    {
        public static void ProductMain()
        {
            try
            {
                List<Product> productList = new List<Product>();

                Console.WriteLine("Ostoskori");
                Product milk = new Product("Milk", 1.1);
                productList.Add(milk);

                Product beer = new Product("Beer", 0.95);
                productList.Add(beer);

                Product cheese = new Product("Cheese", 3);
                productList.Add(cheese);


                for (int i = 0; i < productList.Count; i++)
                {
                    Console.WriteLine(productList[i].Name + " " + productList[i].Price + "e");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
           
        }

    }
}
