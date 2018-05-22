namespace Placovu.Erp.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("INVItemMovementDetail")]
    public partial class INVItemMovementDetail
    {
        [Key]
        public long MovemenDetailtID { get; set; }

        public long? MovementID { get; set; }

        public int? ItemID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? IssuedQty { get; set; }

        [Column(TypeName = "money")]
        public decimal? AvgIssuePrice { get; set; }

        public virtual INVItemMovement INVItemMovement { get; set; }
    }
}
