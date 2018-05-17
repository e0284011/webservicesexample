using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace _2018_05_17.EFCode
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service : IService
    {
        public List<int> GetProductIds()
        {
            return new Work().GetProductIds();
        }

        public WCF_Product GetProduct(string id)
        {
            int n = Int32.Parse(id);
            Product p = new Work().GetProduct(n);
            decimal price = (p.UnitPrice.HasValue ? p.UnitPrice.Value : 0);
            short units = (p.UnitsInStock.HasValue ? p.UnitsInStock.Value : (short)0); // Handling possible null value
            return new WCF_Product(p.ProductID, p.ProductName, price, units);
        }
    }
}
