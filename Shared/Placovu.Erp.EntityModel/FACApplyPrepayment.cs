namespace Placovu.Erp.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FACApplyPrepayment")]
    public partial class FACApplyPrepayment
    {
        [Key]
        public long ApplyPrepaymentID { get; set; }

        public long? SourcePaymentID { get; set; }

        public long? DestPaymentID { get; set; }

        public long? SourceID { get; set; }

        [StringLength(3)]
        public string Source { get; set; }

        public int? BusinessUnitID { get; set; }

        public int? BusinessPartyID { get; set; }

        public DateTime? ApplyDate { get; set; }

        [Column(TypeName = "money")]
        public decimal? AppliedPaymentAmount { get; set; }

        public DateTime? AccountingDate { get; set; }
    }
}
