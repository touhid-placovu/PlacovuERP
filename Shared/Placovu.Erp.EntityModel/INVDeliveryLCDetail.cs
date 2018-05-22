namespace Placovu.Erp.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("INVDeliveryLCDetail")]
    public partial class INVDeliveryLCDetail
    {
        [Key]
        public long DeliveryLCDetailsID { get; set; }

        public long? DeliveryDetailID { get; set; }

        public long? DeliveryID { get; set; }

        public long? SalesOrderID { get; set; }

        public int? BusinessUnitID { get; set; }

        public int? ItemID { get; set; }

        public int? MeasurementUnitID { get; set; }

        public long? LCID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? DeliveredQty { get; set; }
    }
}
