namespace Placovu.Erp.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SECUser")]
    public partial class SECUser
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SECUser()
        {
            FACAccountingPeriods = new HashSet<FACAccountingPeriod>();
            FACAccountingPeriods1 = new HashSet<FACAccountingPeriod>();
            FACUserAndGLSecurityRules = new HashSet<FACUserAndGLSecurityRule>();
            PRSPurchaseReceipts = new HashSet<PRSPurchaseReceipt>();
            PRSPurchaseRequisitions = new HashSet<PRSPurchaseRequisition>();
            PRSPurchaseRequisitions1 = new HashSet<PRSPurchaseRequisition>();
            PRSPurchaseRequisitions2 = new HashSet<PRSPurchaseRequisition>();
            PRSPurchaseRequisitions3 = new HashSet<PRSPurchaseRequisition>();
            PRSPurchaseRequisitions4 = new HashSet<PRSPurchaseRequisition>();
            PRSPurchaseRequisitions5 = new HashSet<PRSPurchaseRequisition>();
            SECUserAndBusinessUnits = new HashSet<SECUserAndBusinessUnit>();
            SECUserAndRoles = new HashSet<SECUserAndRole>();
        }

        [Key]
        public int UserID { get; set; }

        [StringLength(50)]
        public string UserLoginID { get; set; }

        [StringLength(50)]
        public string UserName { get; set; }

        [StringLength(50)]
        public string Password { get; set; }

        [StringLength(10)]
        public string EmployeeID { get; set; }

        [StringLength(100)]
        public string EmployeeName { get; set; }

        [StringLength(150)]
        public string PrimaryEmail { get; set; }

        [StringLength(150)]
        public string SecondaryEmail { get; set; }

        [StringLength(150)]
        public string PrimaryPhone { get; set; }

        [StringLength(150)]
        public string SecondaryPhone { get; set; }

        public bool? IsLocked { get; set; }

        public bool? IsActive { get; set; }

        [StringLength(1)]
        public string RowState { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] timestamp { get; set; }

        public Guid? RowID { get; set; }

        public int? BusinessUnitId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FACAccountingPeriod> FACAccountingPeriods { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FACAccountingPeriod> FACAccountingPeriods1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FACUserAndGLSecurityRule> FACUserAndGLSecurityRules { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRSPurchaseReceipt> PRSPurchaseReceipts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRSPurchaseRequisition> PRSPurchaseRequisitions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRSPurchaseRequisition> PRSPurchaseRequisitions1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRSPurchaseRequisition> PRSPurchaseRequisitions2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRSPurchaseRequisition> PRSPurchaseRequisitions3 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRSPurchaseRequisition> PRSPurchaseRequisitions4 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRSPurchaseRequisition> PRSPurchaseRequisitions5 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SECUserAndBusinessUnit> SECUserAndBusinessUnits { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SECUserAndRole> SECUserAndRoles { get; set; }
    }
}
