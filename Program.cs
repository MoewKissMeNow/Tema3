using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var products = new List<Product>
            {
                new Product(1,"Клавіатура", 850),
                new Product(2,"Миша", 450),
                new Product(3,"Монітор", 6200),
                new Product(4,"Навушка", 1200),

            };
            foreach (var p in products)
            {
                Console.OutputEncoding = Encoding.UTF8;
                Console.WriteLine($"- {p.GetInfo()}");
                
            }

            var expensive = products.Where(p => p.Price > 1000).ToList();
            var names = products.Select(p => p.Name).ToList();
            var sorted = products.OrderBy(p => p.Price).ToList();
            int count = products.Count(p => p.Price > 1000);
            decimal total = products.Sum(p => p.Price);
           

           
            Console.WriteLine("Дорожчі за 1000 грн:");
            foreach (var p in expensive)
            {
                Console.WriteLine($"- {p.GetInfo()}");
            }
            Console.WriteLine();
            Console.WriteLine("Назви товарів:");
            foreach (var p in names)
            {
                Console.WriteLine($"- {p}");
            }
            Console.WriteLine();

            Console.WriteLine("Відсортовані за ціною:");
            foreach (var p in sorted)
            {
                Console.WriteLine($"- {p.GetInfo()}");
            }
            Console.WriteLine();
            Console.WriteLine($"Дорогих товарів: {count}, загальна вартість {total} грн ");
        }
    }
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Product(int id, string name, decimal price)
        {
            Id = id;
            Name = name;
            Price = price;
        }
        public string GetInfo()
        {
            return $"{Id}: {Name} - {Price} грн";
        }
    }
}
