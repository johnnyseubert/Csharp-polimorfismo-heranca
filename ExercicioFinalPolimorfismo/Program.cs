using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;
using ExercicioFinalPolimorfismo.Entities;

namespace ExercicioFinalPolimorfismo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.Write("Enter the number os products: ");
            var n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                
                Console.Write("Common, used, imported (c/u/i)? ");
                char type = Char.Parse(Console.ReadLine().ToLower());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Price: ");
                double price = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (type == 'u')
                {
                    Console.Write("manufacture date (DD/MM/YYYY): ");
                    DateTime manufactorydate = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(name, price, manufactorydate));
                } else if (type == 'i')
                {
                    Console.Write("Customs fee: ");
                    double customsfee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new ImportedProduct(name, price, customsfee));
                } else if (type == 'c')
                {
                    list.Add(new Product(name, price));
                }
            }

            Console.WriteLine("\nPRICE TAGS:");

            foreach (var item in list)
            {
                Console.WriteLine(item.PriceTag());
            }
            
        }
    }
}