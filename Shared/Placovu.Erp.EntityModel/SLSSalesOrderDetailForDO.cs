namespace Placovu.Erp.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SLSSalesOrderDetailForDO")]
    public partial class SLSSalesOrderDetailForDO
    {
        [Key]
        public long SODetailsForDOID { get; set; }

        public long? SalesOrderDetailsID { get; set; }

        public long? SalesOrderID { get; set; }

        public long? ItemID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? LCQty { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? NonLCQty { get; set; }

        public long? LCID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? DeliveredQty { get; set; }
    }
}
