namespace Placovu.Erp.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SLSLC_Details
    {
        public int? BusinessUnitID { get; set; }

        public long? LCID { get; set; }

        [Key]
        public long LCDetailsID { get; set; }

        public long? SalesOrderID { get; set; }

        public long? SalesOrderDetailsID { get; set; }

        public int? SalesOrderRevision { get; set; }

        public int? ItemID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? LCQty { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? LCQtyDelivered { get; set; }

        public int? MeasurementUnitID { get; set; }

        public virtual SLSLC SLSLC { get; set; }
    }
}
