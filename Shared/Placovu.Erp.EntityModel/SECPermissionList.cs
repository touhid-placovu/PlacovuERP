namespace Placovu.Erp.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SECPermissionList")]
    public partial class SECPermissionList
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SECPermissionList()
        {
            SECPermissionListDetails = new HashSet<SECPermissionListDetail>();
            SECRoleAndPermissions = new HashSet<SECRoleAndPermission>();
        }

        [Key]
        public int PermissionListID { get; set; }

        [StringLength(100)]
        public string PermissionListName { get; set; }

        [StringLength(250)]
        public string ShortDescription { get; set; }

        [StringLength(500)]
        public string LongDescription { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SECPermissionListDetail> SECPermissionListDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SECRoleAndPermission> SECRoleAndPermissions { get; set; }
    }
}
