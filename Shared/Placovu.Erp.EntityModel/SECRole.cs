namespace Placovu.Erp.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SECRole")]
    public partial class SECRole
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SECRole()
        {
            SECRoleAndPermissions = new HashSet<SECRoleAndPermission>();
            SECUserAndRoles = new HashSet<SECUserAndRole>();
        }

        [Key]
        public int RoleID { get; set; }

        [Required]
        [StringLength(150)]
        public string RoleName { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        public bool? IsActive { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SECRoleAndPermission> SECRoleAndPermissions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SECUserAndRole> SECUserAndRoles { get; set; }
    }
}
