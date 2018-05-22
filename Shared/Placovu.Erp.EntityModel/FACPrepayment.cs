namespace Placovu.Erp.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FACPrepayment")]
    public partial class FACPrepayment
    {
        [Key]
        public long PaymentID { get; set; }

        public int? SupplierID { get; set; }

        public int? BusinessUnitID { get; set; }

        public long? PrepaymentInvoiceID { get; set; }

        public DateTime? PayDate { get; set; }

        [Column(TypeName = "money")]
        public decimal? PayAmount { get; set; }

        public int? PayModeID { get; set; }

        public int? BankID { get; set; }

        public int? BranchID { get; set; }

        public int? BankAccountID { get; set; }

        public int? BankAccountCode { get; set; }

        [StringLength(50)]
        public string BankCheckNo { get; set; }

        public string Memo { get; set; }

        [StringLength(50)]
        public string RefNo { get; set; }

        public long? JournalID { get; set; }

        public virtual BSEBankAccount BSEBankAccount { get; set; }

        public virtual BSEBankInfo BSEBankInfo { get; set; }

        public virtual BSEBranchInfo BSEBranchInfo { get; set; }

        public virtual BSEBusinessParty BSEBusinessParty { get; set; }

        public virtual BSEBusinessUnit BSEBusinessUnit { get; set; }

        public virtual FACPrepaymentInvoice FACPrepaymentInvoice { get; set; }
    }
}
