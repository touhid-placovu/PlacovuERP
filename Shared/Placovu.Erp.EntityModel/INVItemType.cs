namespace Placovu.Erp.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("INVItemType")]
    public partial class INVItemType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public INVItemType()
        {
            INVItemGroups = new HashSet<INVItemGroup>();
            INVUserAndIssuerDetails = new HashSet<INVUserAndIssuerDetail>();
            PRSUserAndReceiverDetails = new HashSet<PRSUserAndReceiverDetail>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ItemTypeID { get; set; }

        [StringLength(100)]
        public string ItemTypeName { get; set; }

        [StringLength(500)]
        public string ItemTypeDesc { get; set; }

        public bool? IsSellingItem { get; set; }

        public bool? IsPurchasingItem { get; set; }

        public bool? IsActive { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INVItemGroup> INVItemGroups { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INVUserAndIssuerDetail> INVUserAndIssuerDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRSUserAndReceiverDetail> PRSUserAndReceiverDetails { get; set; }
    }
}
