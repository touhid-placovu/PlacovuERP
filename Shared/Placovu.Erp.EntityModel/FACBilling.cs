namespace Placovu.Erp.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FACBilling")]
    public partial class FACBilling
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FACBilling()
        {
            FACBillingDetails = new HashSet<FACBillingDetail>();
            FACPaymentDetails = new HashSet<FACPaymentDetail>();
        }

        [Key]
        public int BillID { get; set; }

        public DateTime? BillDate { get; set; }

        public int? BusinessUnitID { get; set; }

        public int? BusinessPartyID { get; set; }

        public DateTime? DueDate { get; set; }

        [Column(TypeName = "money")]
        public decimal? DueAmount { get; set; }

        [StringLength(50)]
        public string Reference { get; set; }

        [StringLength(250)]
        public string Memo { get; set; }

        public byte? PaymentTermID { get; set; }

        public int? PaymentStatusID { get; set; }

        [Column(TypeName = "money")]
        public decimal? Balance { get; set; }

        public bool? IsPayable { get; set; }

        public bool? IsAdditionExpense { get; set; }

        [StringLength(50)]
        public string SourceOfBill { get; set; }

        public long? SourceRecordID { get; set; }

        public int? EntryBy { get; set; }

        public DateTime? EntryDate { get; set; }

        public int? UpdatedBy { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public int? ApprovedBy { get; set; }

        public DateTime? ApprovedDate { get; set; }

        public int? RejectedBy { get; set; }

        public DateTime? RejectedDate { get; set; }

        public virtual BSEBusinessParty BSEBusinessParty { get; set; }

        public virtual BSEBusinessUnit BSEBusinessUnit { get; set; }

        public virtual BSEPaymentStatu BSEPaymentStatu { get; set; }

        public virtual BSEPaymentTerm BSEPaymentTerm { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FACBillingDetail> FACBillingDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FACPaymentDetail> FACPaymentDetails { get; set; }
    }
}
