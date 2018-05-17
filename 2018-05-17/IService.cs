using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.ServiceModel.Web;


namespace _2018_05_17.EFCode
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    
    [ServiceContract]
    public interface IService
    {
        //[OperationContract]
        //List<int> GetProductIds();

        //[OperationContract]
        //WCF_Product GetProduct(string id);

        [OperationContract]
        [WebGet(UriTemplate = "/Products", ResponseFormat = WebMessageFormat.Json)]
        List<int> GetProductIds();

        [OperationContract]
        [WebGet(UriTemplate = "/Product/{id}", ResponseFormat = WebMessageFormat.Json)]
        WCF_Product GetProduct(string id);
    }

    [DataContract]
    public class WCF_Product
    {
        [DataMember]
        public int ProductID;

        [DataMember]
        public string ProductName;

        [DataMember]
        public decimal UnitPrice;

        [DataMember]
        public short UnitsInStock;

        public WCF_Product(int ProductID, string ProductName, decimal UnitPrice, short UnitsInStock)
        {
            this.ProductID = ProductID;
            this.ProductName = ProductName;
            this.UnitPrice = UnitPrice;
            this.UnitsInStock = UnitsInStock;
        }
    }
}
