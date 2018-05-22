namespace Placovu.Erp.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SECComponent")]
    public partial class SECComponent
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SECComponent()
        {
            SECPermissionListDetails = new HashSet<SECPermissionListDetail>();
        }

        public int? ModuleID { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ComponentID { get; set; }

        [StringLength(100)]
        public string ComponentName { get; set; }

        public bool? IsParent { get; set; }

        public int? ParentID { get; set; }

        [StringLength(200)]
        public string NavigationUrl { get; set; }

        public int? DisplayOrder { get; set; }

        public bool? IsActive { get; set; }

        public bool? IsTopMenuItem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SECPermissionListDetail> SECPermissionListDetails { get; set; }
    }
}
