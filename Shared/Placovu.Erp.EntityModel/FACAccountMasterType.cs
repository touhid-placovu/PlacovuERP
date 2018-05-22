namespace Placovu.Erp.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FACAccountMasterType")]
    public partial class FACAccountMasterType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FACAccountMasterType()
        {
            FACAccountTypes = new HashSet<FACAccountType>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AccountMasterTypeID { get; set; }

        [StringLength(50)]
        public string MasterTypeName { get; set; }

        [StringLength(200)]
        public string MasterTypeDescription { get; set; }

        [StringLength(1)]
        public string DrCr { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FACAccountType> FACAccountTypes { get; set; }
    }
}
