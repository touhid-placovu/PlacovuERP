namespace Placovu.Erp.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRSPurchaseInvoiceDetail")]
    public partial class PRSPurchaseInvoiceDetail
    {
        [Key]
        public long PurchaseInvoiceDetailID { get; set; }

        public long? PurchaseOrderID { get; set; }

        public long PurchaseInvoiceID { get; set; }

        public int? ItemID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? PurchaseOrderQty { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? PrevInvoicedQty { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? InvoicedQty { get; set; }

        public decimal? UnitPrice { get; set; }

        [Column(TypeName = "money")]
        public decimal? LineTotal { get; set; }

        public int? MeasurementUnitID { get; set; }

        [StringLength(50)]
        public string MeasurementUnitText { get; set; }

        [StringLength(500)]
        public string Specification { get; set; }

        public int? GLAccountCode { get; set; }

        public virtual PRSPurchaseInvoice PRSPurchaseInvoice { get; set; }
    }
}
