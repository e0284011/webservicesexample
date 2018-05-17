namespace _2018_05_17.EFCode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Products by Category")]
    public partial class Products_by_Category
    {
        [StringLength(15)]
        public string CategoryName { get; set; }

        [StringLength(40)]
        public string ProductName { get; set; }

        [StringLength(20)]
        public string QuantityPerUnit { get; set; }

        public short? UnitsInStock { get; set; }

        [Key]
        public bool Discontinued { get; set; }
    }
}
