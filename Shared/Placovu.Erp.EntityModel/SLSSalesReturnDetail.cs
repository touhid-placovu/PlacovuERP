namespace Placovu.Erp.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SLSSalesReturnDetail
    {
        [Key]
        public long SalesReturnDetailID { get; set; }

        public long? SalesReturnID { get; set; }

        public long? DeliveryDetailID { get; set; }

        public int? ItemID { get; set; }

        public int? MeasurmentUnitID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? DeliveryQty { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ReturnQty { get; set; }

        [StringLength(50)]
        public string ReturnReason { get; set; }

        public long? DeliveryID { get; set; }

        public virtual SLSSalesReturn SLSSalesReturn { get; set; }
    }
}
