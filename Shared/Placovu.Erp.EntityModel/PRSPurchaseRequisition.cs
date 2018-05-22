namespace Placovu.Erp.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRSPurchaseRequisition")]
    public partial class PRSPurchaseRequisition
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PRSPurchaseRequisition()
        {
            PRSPurchaseRequisitionDetails = new HashSet<PRSPurchaseRequisitionDetail>();
        }

        [Key]
        public long RequisitionID { get; set; }

        public int? BusinessUnitID { get; set; }

        public DateTime? RequisitionDate { get; set; }

        public DateTime? ExpectedRecieveDate { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TotalOrderQty { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalAmount { get; set; }

        public int? RequisitionStatusID { get; set; }

        [StringLength(500)]
        public string Note { get; set; }

        public int? ApprovedBy { get; set; }

        public DateTime? ApprovedDate { get; set; }

        public int? RejectedBy { get; set; }

        public DateTime? RejectedDate { get; set; }

        public int? CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        public int? ModifiedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public int? DeletedBy { get; set; }

        public DateTime? DeletedDate { get; set; }

        public int? ClosedBy { get; set; }

        public DateTime? ClosedDate { get; set; }

        public virtual BSEBusinessUnit BSEBusinessUnit { get; set; }

        public virtual PRSPurchaseRequisitionStatu PRSPurchaseRequisitionStatu { get; set; }

        public virtual SECUser SECUser { get; set; }

        public virtual SECUser SECUser1 { get; set; }

        public virtual SECUser SECUser2 { get; set; }

        public virtual SECUser SECUser3 { get; set; }

        public virtual SECUser SECUser4 { get; set; }

        public virtual SECUser SECUser5 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRSPurchaseRequisitionDetail> PRSPurchaseRequisitionDetails { get; set; }
    }
}
