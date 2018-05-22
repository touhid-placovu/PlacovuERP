namespace Placovu.Erp.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRSPurchaseHistory")]
    public partial class PRSPurchaseHistory
    {
        [Key]
        public Guid PurchaseHistoryID { get; set; }

        public int? BusinessUnitID { get; set; }

        public DateTime? TransactionDate { get; set; }

        public long? PurchaseOrderID { get; set; }

        public DateTime? PurchaseOrderDate { get; set; }

        public long? PurchaseReceiptID { get; set; }

        public DateTime? PurchaseReceiptDate { get; set; }

        public long? InvoiceID { get; set; }

        public DateTime? InvoiceDate { get; set; }

        public long ItemID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ItemQty { get; set; }

        [Column(TypeName = "money")]
        public decimal ItemUnitPrice { get; set; }

        public int? CurrencyID { get; set; }

        [Column(TypeName = "money")]
        public decimal? ConversionRate { get; set; }

        [Column(TypeName = "money")]
        public decimal OrderUnitPrice { get; set; }

        [Column(TypeName = "numeric")]
        public decimal ItemBalanceQty { get; set; }
    }
}
