namespace Placovu.Erp.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRSPurchaseReturnDetail")]
    public partial class PRSPurchaseReturnDetail
    {
        [Key]
        public long PurchaseReturnDetailID { get; set; }

        public long? PurchaseReturnID { get; set; }

        public long? PurchaseReceiptID { get; set; }

        public long? PurchaseRecipetDetailID { get; set; }

        public int? ItemID { get; set; }

        public int? MeasurmentUnitID { get; set; }

        [StringLength(50)]
        public string MeasurmentUnitText { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? RecieptQty { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ReturnQty { get; set; }

        [StringLength(50)]
        public string ReturnReason { get; set; }

        public virtual INVItemInfo INVItemInfo { get; set; }

        public virtual PRSPurchaseReturn PRSPurchaseReturn { get; set; }
    }
}
