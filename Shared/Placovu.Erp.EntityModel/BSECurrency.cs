namespace Placovu.Erp.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BSECurrency")]
    public partial class BSECurrency
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BSECurrency()
        {
            FACPrepaymentInvoices = new HashSet<FACPrepaymentInvoice>();
            PRSPurchaseInvoices = new HashSet<PRSPurchaseInvoice>();
            PRSPurchaseOrders = new HashSet<PRSPurchaseOrder>();
            SLSSalesOrders = new HashSet<SLSSalesOrder>();
        }

        [Key]
        public int CurrencyID { get; set; }

        [Required]
        [StringLength(5)]
        public string CurrencyCode { get; set; }

        [StringLength(250)]
        public string Name { get; set; }

        [StringLength(250)]
        public string LongName { get; set; }

        [StringLength(250)]
        public string AfterDecimalName { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Rate { get; set; }

        public DateTime? RateAsOf { get; set; }

        public bool? IsBase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FACPrepaymentInvoice> FACPrepaymentInvoices { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRSPurchaseInvoice> PRSPurchaseInvoices { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRSPurchaseOrder> PRSPurchaseOrders { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SLSSalesOrder> SLSSalesOrders { get; set; }
    }
}
