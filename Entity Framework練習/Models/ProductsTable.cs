namespace Entity_Framework練習.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProductsTable")]
    public partial class ProductsTable
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string ProductNumber { get; set; }

        [StringLength(50)]
        public string ProductName { get; set; }

        public int? AmountOfProducts { get; set; }

        public decimal? ProductPrice { get; set; }

        [StringLength(50)]
        public string ProductCategory { get; set; }
    }
}
