namespace Placovu.Erp.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FACAccountSubType")]
    public partial class FACAccountSubType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FACAccountSubType()
        {
            FACChartOfAccounts = new HashSet<FACChartOfAccount>();
        }

        [Key]
        public int AccountSubTypeID { get; set; }

        public int AccountTypeID { get; set; }

        [Required]
        [StringLength(200)]
        public string AccountSubTypeName { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        [Required]
        [StringLength(1)]
        public string NatureDrCr { get; set; }

        public virtual FACAccountType FACAccountType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FACChartOfAccount> FACChartOfAccounts { get; set; }
    }
}
