namespace Placovu.Erp.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SLSSalesInvoiceDetail")]
    public partial class SLSSalesInvoiceDetail
    {
        [Key]
        public long SalesInvoiceDetailID { get; set; }

        public long? SalesOrderID { get; set; }

        public long? LCID { get; set; }

        public long SalesInvoiceID { get; set; }

        public int? ItemID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? SalesOrderQty { get; set; }

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

        [Column(TypeName = "money")]
        public decimal? AdvancePayment { get; set; }

        [Column(TypeName = "money")]
        public decimal? AdjustedTotal { get; set; }

        [StringLength(500)]
        public string Specification { get; set; }

        [StringLength(100)]
        public string ItemDisplayName { get; set; }

        public int? GLAccountCode { get; set; }

        [Column(TypeName = "money")]
        public decimal? LineDiscount { get; set; }

        [Column(TypeName = "money")]
        public decimal? LineDiscountAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? LineVAT { get; set; }

        [Column(TypeName = "money")]
        public decimal? LineVATAmount { get; set; }

        public virtual SLSSalesInvoice SLSSalesInvoice { get; set; }
    }
}
