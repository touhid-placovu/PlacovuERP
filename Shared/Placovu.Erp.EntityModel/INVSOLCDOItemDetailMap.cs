namespace Placovu.Erp.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("INVSOLCDOItemDetailMap")]
    public partial class INVSOLCDOItemDetailMap
    {
        [Key]
        public Guid SOLCDOItemDetailMapID { get; set; }

        public long? SalesOrderID { get; set; }

        public long? LCID { get; set; }

        public long? DeliveryID { get; set; }

        public int? ItemID { get; set; }

        [Column(TypeName = "money")]
        public decimal? SalesOrderQty { get; set; }

        [Column(TypeName = "money")]
        public decimal? LCQty { get; set; }

        [Column(TypeName = "money")]
        public decimal? DeliveryQty { get; set; }
    }
}
