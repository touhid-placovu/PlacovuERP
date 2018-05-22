namespace Placovu.Erp.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SLSSalesOrderAmendmentDetail")]
    public partial class SLSSalesOrderAmendmentDetail
    {
        [Key]
        public long AmendmentDetailID { get; set; }

        public long? AmendmentID { get; set; }

        public long? SalesOrderDetailID { get; set; }

        public int? ItemID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? PrevQuantity { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? NewQuantity { get; set; }

        [Column(TypeName = "money")]
        public decimal? PrevRate { get; set; }

        [Column(TypeName = "money")]
        public decimal? NewRate { get; set; }

        public virtual SLSSalesOrderAmendment SLSSalesOrderAmendment { get; set; }
    }
}
