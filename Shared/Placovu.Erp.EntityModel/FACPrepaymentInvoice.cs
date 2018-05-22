namespace Placovu.Erp.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FACPrepaymentInvoice")]
    public partial class FACPrepaymentInvoice
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FACPrepaymentInvoice()
        {
            FACPrepayments = new HashSet<FACPrepayment>();
        }

        [Key]
        public long PrepaymentInvoiceID { get; set; }

        public int? BusinessUnitID { get; set; }

        public DateTime? InvoiceDate { get; set; }

        public int? BusinessPartyID { get; set; }

        public long? EmployeeID { get; set; }

        [Column(TypeName = "money")]
        public decimal? InvoiceAmount { get; set; }

        public DateTime? DueDate { get; set; }

        [StringLength(2000)]
        public string InvoiceNote { get; set; }

        public int? InvoiceStatusID { get; set; }

        public int? PaymentStatusID { get; set; }

        public int? CurrencyID { get; set; }

        [StringLength(50)]
        public string CurrencyCode { get; set; }

        [Column(TypeName = "money")]
        public decimal? ConversionRate { get; set; }

        [Column(TypeName = "money")]
        public decimal? AvailableAmount { get; set; }

        public virtual BSEBusinessParty BSEBusinessParty { get; set; }

        public virtual BSEBusinessUnit BSEBusinessUnit { get; set; }

        public virtual BSECurrency BSECurrency { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FACPrepayment> FACPrepayments { get; set; }

        public virtual FACPrepaymentInvoiceStatu FACPrepaymentInvoiceStatu { get; set; }
    }
}
