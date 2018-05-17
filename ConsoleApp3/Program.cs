using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp3.ServiceReference1;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Service1Client c = new Service1Client();
            int[] ids = c.GetProductIds();
            foreach (int id in ids)
            {
                Console.WriteLine(id);
                WCF_Product p = c.GetProduct(id.ToString());
                Console.WriteLine(p.ProductName);
            }
        }
    }
}
