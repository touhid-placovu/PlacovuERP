namespace Placovu.Erp.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BSEBusinessParty")]
    public partial class BSEBusinessParty
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BSEBusinessParty()
        {
            BSEBusinessPartyBankInfoes = new HashSet<BSEBusinessPartyBankInfo>();
            FACBillings = new HashSet<FACBilling>();
            FACCreditMemoes = new HashSet<FACCreditMemo>();
            FACDebitMemoes = new HashSet<FACDebitMemo>();
            FACJournalDetails = new HashSet<FACJournalDetail>();
            FACPaymentDetails = new HashSet<FACPaymentDetail>();
            FACPrepayments = new HashSet<FACPrepayment>();
            FACPrepaymentInvoices = new HashSet<FACPrepaymentInvoice>();
            PRSPurchaseInvoices = new HashSet<PRSPurchaseInvoice>();
            PRSPurchaseOrders = new HashSet<PRSPurchaseOrder>();
            PRSPurchaseReceipts = new HashSet<PRSPurchaseReceipt>();
            SLSSalesOrders = new HashSet<SLSSalesOrder>();
        }

        public int? BusinessUnitID { get; set; }

        [Key]
        public int BusinessPartyID { get; set; }

        [StringLength(100)]
        public string BusinessPartyName { get; set; }

        [StringLength(100)]
        public string Company { get; set; }

        [StringLength(50)]
        public string Street { get; set; }

        [StringLength(50)]
        public string Zip { get; set; }

        public int? CountryID { get; set; }

        [StringLength(100)]
        public string CountryName { get; set; }

        [StringLength(50)]
        public string City { get; set; }

        [StringLength(50)]
        public string email { get; set; }

        [StringLength(50)]
        public string Phone { get; set; }

        [StringLength(50)]
        public string Mobile { get; set; }

        [StringLength(50)]
        public string Fax { get; set; }

        public int? AccountCode { get; set; }

        [StringLength(2)]
        public string Nature { get; set; }

        [StringLength(1000)]
        public string AddressLine1 { get; set; }

        [StringLength(1000)]
        public string AddressLine2 { get; set; }

        [StringLength(20)]
        public string State { get; set; }

        public bool? IsActive { get; set; }

        public int? ItemTypeID { get; set; }

        public bool IsEmployee { get; set; }

        public long? EmployeeID { get; set; }

        public virtual BSECountry BSECountry { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BSEBusinessPartyBankInfo> BSEBusinessPartyBankInfoes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FACBilling> FACBillings { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FACCreditMemo> FACCreditMemoes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FACDebitMemo> FACDebitMemoes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FACJournalDetail> FACJournalDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FACPaymentDetail> FACPaymentDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FACPrepayment> FACPrepayments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FACPrepaymentInvoice> FACPrepaymentInvoices { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRSPurchaseInvoice> PRSPurchaseInvoices { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRSPurchaseOrder> PRSPurchaseOrders { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRSPurchaseReceipt> PRSPurchaseReceipts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SLSSalesOrder> SLSSalesOrders { get; set; }
    }
}
