using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp2.ServiceReference1;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            WebServiceSoapClient c = new WebServiceSoapClient(); // This is a client-side proxy which reads the XML data and interprets into C# code
            ArrayOfInt ids = c.GetProductIds();
            foreach (int id in ids)
            {
                Console.WriteLine(id);
                Product p = c.GetProduct(id);
                Console.WriteLine(p.ProductName);
            }
        }
    }
}
