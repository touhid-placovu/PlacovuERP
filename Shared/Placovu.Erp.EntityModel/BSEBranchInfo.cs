namespace Placovu.Erp.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BSEBranchInfo")]
    public partial class BSEBranchInfo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BSEBranchInfo()
        {
            BSEBankAccounts = new HashSet<BSEBankAccount>();
            FACPayments = new HashSet<FACPayment>();
            FACPrepayments = new HashSet<FACPrepayment>();
        }

        [Key]
        public int BranchID { get; set; }

        public int? BankID { get; set; }

        [StringLength(10)]
        public string BranchCode { get; set; }

        [StringLength(50)]
        public string BranchName { get; set; }

        [StringLength(250)]
        public string Description { get; set; }

        [StringLength(1000)]
        public string AddressLine1 { get; set; }

        [StringLength(1000)]
        public string AddressLine2 { get; set; }

        [StringLength(20)]
        public string City { get; set; }

        [StringLength(20)]
        public string State { get; set; }

        [StringLength(20)]
        public string ZipCode { get; set; }

        public int? Country { get; set; }

        [StringLength(50)]
        public string SWIFTCode { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BSEBankAccount> BSEBankAccounts { get; set; }

        public virtual BSEBankInfo BSEBankInfo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FACPayment> FACPayments { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FACPrepayment> FACPrepayments { get; set; }
    }
}
