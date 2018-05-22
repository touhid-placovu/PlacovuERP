namespace Placovu.Erp.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FACCreditMemo")]
    public partial class FACCreditMemo
    {
        [Key]
        public long CreditMemoID { get; set; }

        public long? InvoiceID { get; set; }

        public int? BusinessPartyID { get; set; }

        public int? BusinessUnitID { get; set; }

        [Column(TypeName = "money")]
        public decimal? CreditAmount { get; set; }

        public int? CreditMemoStatusID { get; set; }

        public DateTime? CreditMemoDate { get; set; }

        public DateTime? AccountingDate { get; set; }

        [StringLength(100)]
        public string Reference { get; set; }

        [StringLength(250)]
        public string Comments { get; set; }

        public int? CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        public int? ApprovedBy { get; set; }

        public DateTime? ApprovedDate { get; set; }

        public int? RejectedBy { get; set; }

        public DateTime? RejectedDate { get; set; }

        public int? AccountCode { get; set; }

        public virtual BSEBusinessParty BSEBusinessParty { get; set; }

        public virtual BSEBusinessUnit BSEBusinessUnit { get; set; }

        public virtual FACCreditMemoStatu FACCreditMemoStatu { get; set; }
    }
}
