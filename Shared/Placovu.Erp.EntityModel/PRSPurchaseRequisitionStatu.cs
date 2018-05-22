namespace Placovu.Erp.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PRSPurchaseRequisitionStatu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PRSPurchaseRequisitionStatu()
        {
            PRSPurchaseRequisitions = new HashSet<PRSPurchaseRequisition>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RequisitionStatusID { get; set; }

        [StringLength(50)]
        public string RequisitionStatusName { get; set; }

        public bool? IsActive { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRSPurchaseRequisition> PRSPurchaseRequisitions { get; set; }
    }
}
