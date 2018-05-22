namespace Placovu.Erp.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRSPurchasePayment")]
    public partial class PRSPurchasePayment
    {
        [Key]
        public long PaymentID { get; set; }

        public int? SupplierID { get; set; }

        public long? PurchaseInvoiceID { get; set; }

        public DateTime? PayDate { get; set; }

        public DateTime? AccountingDate { get; set; }

        [Column(TypeName = "money")]
        public decimal? PayAmount { get; set; }

        public int? PayModeID { get; set; }

        public int? ReceivingBank { get; set; }

        public int? GLAccountCode { get; set; }

        [StringLength(50)]
        public string RecBankCheckNo { get; set; }

        public string Memo { get; set; }

        [StringLength(50)]
        public string RefNo { get; set; }

        public int? CurrencyID { get; set; }

        [Column(TypeName = "money")]
        public decimal? FxConversionRate { get; set; }

        public long? JournalID { get; set; }

        public long? PurchaseOrderID { get; set; }

        public int? PaymentTypeID { get; set; }

        public int? BusinessUnitID { get; set; }

        public int? RecBranchID { get; set; }

        public int? RecBankAccountID { get; set; }

        public int? AddedBy { get; set; }

        public DateTime? DateAdded { get; set; }

        public bool? IsAdvance { get; set; }

        [Column(TypeName = "money")]
        public decimal? Balance { get; set; }

        public bool? IsCancelled { get; set; }

        public DateTime? CancelledDate { get; set; }

        [StringLength(500)]
        public string CancellationReason { get; set; }

        public int? CancelledBy { get; set; }

        public int? projectId { get; set; }

        public bool? IsQuick { get; set; }

        [Column(TypeName = "money")]
        public decimal? AdjPrepaymentAmount { get; set; }

        public virtual BSEBankAccount BSEBankAccount { get; set; }

        public virtual BSEBankInfo BSEBankInfo { get; set; }

        public virtual BSEBusinessUnit BSEBusinessUnit { get; set; }

        public virtual BSEPaymentMode BSEPaymentMode { get; set; }

        public virtual BSEPaymentType BSEPaymentType { get; set; }

        public virtual PRSPurchaseInvoice PRSPurchaseInvoice { get; set; }
    }
}
