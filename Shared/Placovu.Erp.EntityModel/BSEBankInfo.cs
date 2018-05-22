namespace Placovu.Erp.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BSEBankInfo")]
    public partial class BSEBankInfo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BSEBankInfo()
        {
            BSEBankAccounts = new HashSet<BSEBankAccount>();
            BSEBranchInfoes = new HashSet<BSEBranchInfo>();
            FACPayments = new HashSet<FACPayment>();
            FACPrepayments = new HashSet<FACPrepayment>();
            PRSPurchasePayments = new HashSet<PRSPurchasePayment>();
            SLSSalesPayments = new HashSet<SLSSalesPayment>();
        }

        [Key]
        public int BankID { get; set; }

        [Required]
        [StringLength(100)]
        public string BankName { get; set; }

        [StringLength(250)]
        public string Description { get; set; }

        [StringLength(1000)]
        public string AddressLine1 { get; set; }

        [StringLength(1000)]
        public string AddressLine2 { get; set; }

        [StringLength(20)]
        public string City { get; set; }

        public int? Country { get; set; }

        [StringLength(50)]
        public string ZipCode { get; set; }

        [StringLength(20)]
        public string State { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BSEBankAccount> BSEBankAccounts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BSEBranchInfo> BSEBranchInfoes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FACPayment> FACPayments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FACPrepayment> FACPrepayments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRSPurchasePayment> PRSPurchasePayments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SLSSalesPayment> SLSSalesPayments { get; set; }
    }
}
