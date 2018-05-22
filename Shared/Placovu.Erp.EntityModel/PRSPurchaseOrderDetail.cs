namespace Placovu.Erp.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRSPurchaseOrderDetail")]
    public partial class PRSPurchaseOrderDetail
    {
        [Key]
        public long PurchaseOrderDetailsID { get; set; }

        public long? PurchaseOrderID { get; set; }

        public int? ItemID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? PurchaseOrderQty { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? PrevInvoicedQty { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TotalReceivedQty { get; set; }

        public decimal? UnitPrice { get; set; }

        [Column(TypeName = "money")]
        public decimal? LineTotal { get; set; }

        public int? MeasurementUnitID { get; set; }

        [StringLength(50)]
        public string MeasurementUnitText { get; set; }

        [Column(TypeName = "text")]
        public string Specification { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TotalReturnedQuantity { get; set; }

        public virtual INVItemInfo INVItemInfo { get; set; }

        public virtual PRSPurchaseOrder PRSPurchaseOrder { get; set; }
    }
}
