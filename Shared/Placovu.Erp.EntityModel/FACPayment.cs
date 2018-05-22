namespace Placovu.Erp.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FACPayment")]
    public partial class FACPayment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FACPayment()
        {
            FACPaymentDetails = new HashSet<FACPaymentDetail>();
        }

        [Key]
        public int PaymentID { get; set; }

        public DateTime? PaymentDate { get; set; }

        public int? BusinessUnitID { get; set; }

        [Column(TypeName = "money")]
        public decimal? PaymentAmount { get; set; }

        public int? PaymentModeID { get; set; }

        public int? BankID { get; set; }

        public int? GLAccountCode { get; set; }

        public int? BankAccountID { get; set; }

        public int? BranchID { get; set; }

        [StringLength(50)]
        public string CheckNumber { get; set; }

        [StringLength(250)]
        public string Memo { get; set; }

        public bool? IsPayable { get; set; }

        public virtual BSEBankAccount BSEBankAccount { get; set; }

        public virtual BSEBankInfo BSEBankInfo { get; set; }

        public virtual BSEBranchInfo BSEBranchInfo { get; set; }

        public virtual BSEBusinessUnit BSEBusinessUnit { get; set; }

        public virtual BSEPaymentMode BSEPaymentMode { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FACPaymentDetail> FACPaymentDetails { get; set; }
    }
}
