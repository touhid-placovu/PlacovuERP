namespace Placovu.Erp.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("INVItemGroup")]
    public partial class INVItemGroup
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public INVItemGroup()
        {
            INVItemInfoes = new HashSet<INVItemInfo>();
        }

        [Key]
        public int ItemGroupID { get; set; }

        public int ItemTypeID { get; set; }

        [StringLength(50)]
        public string GroupName { get; set; }

        [StringLength(250)]
        public string Description { get; set; }

        public bool? IsActive { get; set; }

        public int? BusinessUnitID { get; set; }

        public int? AddedBy { get; set; }

        public DateTime? AddedDate { get; set; }

        public int? UpdatedBy { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] RowVersion { get; set; }

        public virtual BSEBusinessUnit BSEBusinessUnit { get; set; }

        public virtual INVItemType INVItemType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INVItemInfo> INVItemInfoes { get; set; }
    }
}
