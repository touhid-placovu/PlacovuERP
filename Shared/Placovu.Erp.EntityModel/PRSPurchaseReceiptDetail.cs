namespace Placovu.Erp.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRSPurchaseReceiptDetail")]
    public partial class PRSPurchaseReceiptDetail
    {
        [Key]
        public long PurchaseReceiptDetailsID { get; set; }

        public long? PurchaseOrderID { get; set; }

        public long? PurchasereceiptID { get; set; }

        public int? BusinessUnitID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ReceiptDate { get; set; }

        public int? ItemID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? PurchaseOrderQty { get; set; }

        public int? MeasurementUnitID { get; set; }

        [StringLength(50)]
        public string MeasurementUnitText { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ReceivedQty { get; set; }

        [StringLength(50)]
        public string Remark { get; set; }

        public bool? IsPutAway { get; set; }

        public long? PutawayID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ReturnQty { get; set; }

        [Column(TypeName = "money")]
        public decimal? LineTotal { get; set; }

        public decimal? UnitPrice { get; set; }

        public virtual INVItemInfo INVItemInfo { get; set; }

        public virtual PRSPurchaseReceipt PRSPurchaseReceipt { get; set; }
    }
}
