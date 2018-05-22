namespace Placovu.Erp.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FACTemporaryFund")]
    public partial class FACTemporaryFund
    {
        [Key]
        public long TemporaryFundID { get; set; }

        public int? BusinessUnitID { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalIssuedAmount { get; set; }

        public DateTime? DateIssued { get; set; }

        public int? FundIssuedTo { get; set; }

        public int? FundIssuedBy { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalReveivedAmount { get; set; }

        public DateTime? DateReceived { get; set; }

        public int? FundReceivedBy { get; set; }

        [Column(TypeName = "text")]
        public string IssueNote { get; set; }

        [Column(TypeName = "text")]
        public string CloseNote { get; set; }

        public bool? IsClosed { get; set; }
    }
}
