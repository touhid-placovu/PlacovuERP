namespace Placovu.Erp.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("INVDeliveryDetail")]
    public partial class INVDeliveryDetail
    {
        public int? BusinessUnitID { get; set; }

        public long? DeliveryID { get; set; }

        [Key]
        public long DeliveryDetailsID { get; set; }

        public long? SalesOrderID { get; set; }

        public long? SalesOrderDetailsID { get; set; }

        public long? LCID { get; set; }

        public long? LCDetailsID { get; set; }

        public int? ItemID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DeliveryDate { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? DeliveredQty { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? SalesOrderQty { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ReturnQty { get; set; }

        public int? MeasurementUnitID { get; set; }

        [StringLength(50)]
        public string MeasurementUnitText { get; set; }

        [StringLength(50)]
        public string Remark { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? PrevDeliveredQty { get; set; }

        public int? StorageLocationID { get; set; }

        public bool? IsDelevered { get; set; }

        public virtual BSEBusinessUnit BSEBusinessUnit { get; set; }

        public virtual INVDelivery INVDelivery { get; set; }

        public virtual INVItemInfo INVItemInfo { get; set; }
    }
}
