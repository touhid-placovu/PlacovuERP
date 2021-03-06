namespace Placovu.Erp.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRSPurchaseInvoice")]
    public partial class PRSPurchaseInvoice
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PRSPurchaseInvoice()
        {
            PRSPurchaseInvoiceDetails = new HashSet<PRSPurchaseInvoiceDetail>();
            PRSPurchasePayments = new HashSet<PRSPurchasePayment>();
        }

        [Key]
        public long PurchaseInvoiceID { get; set; }

        public int? BusinessUnitID { get; set; }

        [StringLength(50)]
        public string ReferenceNo { get; set; }

        public long? PurchaseOrderID { get; set; }

        public DateTime? InvoiceDate { get; set; }

        public int? BusinessPartyID { get; set; }

        [Column(TypeName = "money")]
        public decimal? InvoiceAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? MerchandiseAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? DiscountAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? DebitMemoAmt { get; set; }

        public DateTime? DueDate { get; set; }

        [StringLength(2000)]
        public string InvoiceNote { get; set; }

        public int? InvoiceStatusID { get; set; }

        public int? PaymentStatusID { get; set; }

        [StringLength(500)]
        public string PaymentTerms { get; set; }

        public int? PaymentTermID { get; set; }

        [Column(TypeName = "money")]
        public decimal? PaymentedAmount { get; set; }

        public int? CurrencyID { get; set; }

        [StringLength(50)]
        public string CurrencyCode { get; set; }

        [Column(TypeName = "money")]
        public decimal? ConversionRate { get; set; }

        public int? ApprovedBy { get; set; }

        public DateTime? ApprovedDate { get; set; }

        public int? RejectedBy { get; set; }

        public DateTime? RejectedDate { get; set; }

        public DateTime? AccountingDate { get; set; }

        public DateTime? DateAdded { get; set; }

        public int? AddedBy { get; set; }

        public DateTime? DateUpdated { get; set; }

        public int? UpdatedBy { get; set; }

        public long? SalesOrderID { get; set; }

        public long? SalesInvoiceID { get; set; }

        public int? AdditionalExpConfigID { get; set; }

        [StringLength(10)]
        public string CloseType { get; set; }

        [StringLength(250)]
        public string CloseReason { get; set; }

        public int? ClosedBy { get; set; }

        public DateTime? ClosingDate { get; set; }

        public int? DiscountType { get; set; }

        public long? JournalID { get; set; }

        public bool? IsCancelled { get; set; }

        public DateTime? CancelledDate { get; set; }

        [StringLength(500)]
        public string CancellationReason { get; set; }

        public int? CancelledBy { get; set; }

        [StringLength(100)]
        public string SalesBankRefNo { get; set; }

        public DateTime? SalesNegotiationDate { get; set; }

        public DateTime? SalesRealizationDate { get; set; }

        [StringLength(100)]
        public string SalesBLNo { get; set; }

        public DateTime? SalesBLDate { get; set; }

        [StringLength(250)]
        public string SalesVassel { get; set; }

        public long? PurchasereceiptID { get; set; }

        public int? ProjectID { get; set; }

        public int? InvoiceTypeID { get; set; }

        public virtual BSEBusinessParty BSEBusinessParty { get; set; }

        public virtual BSEBusinessUnit BSEBusinessUnit { get; set; }

        public virtual BSECurrency BSECurrency { get; set; }

        public virtual PRSPurchaseInvoiceType PRSPurchaseInvoiceType { get; set; }

        public virtual PRSPurchaseOrder PRSPurchaseOrder { get; set; }

        public virtual SLSInvoiceStatu SLSInvoiceStatu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRSPurchaseInvoiceDetail> PRSPurchaseInvoiceDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRSPurchasePayment> PRSPurchasePayments { get; set; }
    }
}
