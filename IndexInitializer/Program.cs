using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndexInitializer.Product;

namespace UsingIndexInititalizer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Initializing a dictionary*//*
            Dictionary<string, Product> products = new Dictionary<string, Product> {
                 { "Kayak", new Product { Name = "Kayak", Price = 275M } },
                 { "Lifejacket", new Product{ Name = "Lifejacket", Price = 48.95M } }
             };*/


            /*Initializing using Collection Initializer syntax*/
            Dictionary<string, Product> products = new Dictionary<string, Product>
            {
                ["Kayak"] = new Product { Name = "Kayak", Price = 275M },
                ["Lifejacket"] = new Product { Name = "Lifejacket", Price = 48.95M }
            };

        }
    }
}
