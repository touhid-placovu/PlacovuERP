namespace Placovu.Erp.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FACDebitMemo")]
    public partial class FACDebitMemo
    {
        [Key]
        public long DebitMemoID { get; set; }

        public long? InvoiceID { get; set; }

        public int? BusinessPartyID { get; set; }

        public int? BusinessUnitID { get; set; }

        [Column(TypeName = "money")]
        public decimal? DebitAmount { get; set; }

        public int? DebitMemoStatusID { get; set; }

        public DateTime? DebitMemoDate { get; set; }

        public DateTime? AccountingDate { get; set; }

        public int? AccountCode { get; set; }

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

        public long? PurchaseReturnID { get; set; }

        public virtual BSEBusinessParty BSEBusinessParty { get; set; }

        public virtual BSEBusinessUnit BSEBusinessUnit { get; set; }

        public virtual FACDebitMemoStatu FACDebitMemoStatu { get; set; }
    }
}
