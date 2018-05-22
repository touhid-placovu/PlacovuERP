namespace Placovu.Erp.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("INVPutawayDetail")]
    public partial class INVPutawayDetail
    {
        [Key]
        public long PutawayDetailID { get; set; }

        public long PutawayID { get; set; }

        public int? BusinessUnitID { get; set; }

        public long? PurchaseReceiptID { get; set; }

        public long PurchaseReceiptDetailsID { get; set; }

        public DateTime? PurchaseReceiptDate { get; set; }

        public DateTime? PutawayDate { get; set; }

        public int ItemID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? PutawayQty { get; set; }

        public int? MeasurementUnitID { get; set; }

        [StringLength(50)]
        public string MeasurementUnitText { get; set; }

        public int StorageLocationID { get; set; }

        public long? PrimaryItemBalanceID { get; set; }

        [Column(TypeName = "money")]
        public decimal? LineTotal { get; set; }

        public decimal? UnitPrice { get; set; }

        public virtual BSEMeasurementUnit BSEMeasurementUnit { get; set; }

        public virtual INVItemInfo INVItemInfo { get; set; }

        public virtual INVPutaway INVPutaway { get; set; }
    }
}
