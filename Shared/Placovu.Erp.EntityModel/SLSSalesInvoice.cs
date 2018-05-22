namespace Placovu.Erp.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SLSSalesInvoice")]
    public partial class SLSSalesInvoice
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SLSSalesInvoice()
        {
            SLSSalesInvoiceDetails = new HashSet<SLSSalesInvoiceDetail>();
            SLSSalesPayments = new HashSet<SLSSalesPayment>();
        }

        [Key]
        public long SalesInvoiceID { get; set; }

        public int? BusinessUnitID { get; set; }

        [StringLength(50)]
        public string ReferenceNo { get; set; }

        public long? SalesOrderID { get; set; }

        public long? LCID { get; set; }

        public DateTime? InvoiceDate { get; set; }

        public int? BusinessPartyID { get; set; }

        [Column(TypeName = "money")]
        public decimal? InvoiceAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? MerchandiseAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? DiscountAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? CreditMemoAmt { get; set; }

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

        public DateTime? AccountingDate { get; set; }

        [StringLength(10)]
        public string CloseType { get; set; }

        [StringLength(250)]
        public string CloseReason { get; set; }

        public int? ClosedBy { get; set; }

        public DateTime? ClosingDate { get; set; }

        public DateTime? DateAdded { get; set; }

        public int? AddedBy { get; set; }

        public DateTime? DateUpdated { get; set; }

        public int? UpdatedBy { get; set; }

        public int? ApprovedBy { get; set; }

        public DateTime? ApprovedDate { get; set; }

        public int? RejectedBy { get; set; }

        public DateTime? RejectedDate { get; set; }

        public long? JournalID { get; set; }

        public bool? IsCancelled { get; set; }

        public DateTime? CancelledDate { get; set; }

        [StringLength(500)]
        public string CancellationReason { get; set; }

        public int? CancelledBy { get; set; }

        [StringLength(100)]
        public string DocumentNumber { get; set; }

        public int? ProjectID { get; set; }

        public long? DeliveryID { get; set; }

        [Column(TypeName = "money")]
        public decimal? VATPercentage { get; set; }

        [Column(TypeName = "money")]
        public decimal? VATAmount { get; set; }

        public virtual BSEBusinessUnit BSEBusinessUnit { get; set; }

        public virtual BSEPaymentStatu BSEPaymentStatu { get; set; }

        public virtual SLSAddlExpDetail SLSAddlExpDetail { get; set; }

        public virtual SLSInvoiceStatu SLSInvoiceStatu { get; set; }

        public virtual SLSLC SLSLC { get; set; }

        public virtual SLSSalesOrder SLSSalesOrder { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SLSSalesInvoiceDetail> SLSSalesInvoiceDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SLSSalesPayment> SLSSalesPayments { get; set; }
    }
}
