﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DniFruitsKart.Data.AdventureWorks
{
    [Table("ProductVendor", Schema = "Purchasing")]
    public partial class ProductVendor
    {
        [Column("ProductID")]
        public int ProductId { get; set; }
        [Column("BusinessEntityID")]
        public int BusinessEntityId { get; set; }
        public int AverageLeadTime { get; set; }
        [Column(TypeName = "money")]
        public decimal StandardPrice { get; set; }
        [Column(TypeName = "money")]
        public decimal? LastReceiptCost { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LastReceiptDate { get; set; }
        public int MinOrderQty { get; set; }
        public int MaxOrderQty { get; set; }
        public int? OnOrderQty { get; set; }
        [Required]
        [Column(TypeName = "nchar(3)")]
        public string UnitMeasureCode { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }

        [ForeignKey("BusinessEntityId")]
        [InverseProperty("ProductVendor")]
        public virtual Vendor BusinessEntity { get; set; }
        [ForeignKey("ProductId")]
        [InverseProperty("ProductVendor")]
        public virtual Product Product { get; set; }
        [ForeignKey("UnitMeasureCode")]
        [InverseProperty("ProductVendor")]
        public virtual UnitMeasure UnitMeasureCodeNavigation { get; set; }
    }
}
