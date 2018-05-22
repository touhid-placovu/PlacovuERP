namespace Placovu.Erp.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BSEBankAccount")]
    public partial class BSEBankAccount
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BSEBankAccount()
        {
            FACPayments = new HashSet<FACPayment>();
            FACPrepayments = new HashSet<FACPrepayment>();
            PRSPurchasePayments = new HashSet<PRSPurchasePayment>();
            SLSSalesPayments = new HashSet<SLSSalesPayment>();
        }

        [Key]
        public int BankAccountID { get; set; }

        public int? BankID { get; set; }

        public int? BranchID { get; set; }

        [StringLength(30)]
        public string BankAccName { get; set; }

        [StringLength(250)]
        public string Description { get; set; }

        [StringLength(50)]
        public string AccountNo { get; set; }

        [StringLength(50)]
        public string AccountType { get; set; }

        public bool? isActive { get; set; }

        [StringLength(50)]
        public string IBANNo { get; set; }

        public int? CurrencyCode { get; set; }

        [StringLength(50)]
        public string SwiftCode { get; set; }

        public int? GLAccount { get; set; }

        public int? BusinessUnitID { get; set; }

        public virtual BSEBankInfo BSEBankInfo { get; set; }

        public virtual BSEBranchInfo BSEBranchInfo { get; set; }

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
