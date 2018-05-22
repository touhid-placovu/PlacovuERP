namespace Placovu.Erp.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FACAccountType")]
    public partial class FACAccountType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FACAccountType()
        {
            FACAccountSubTypes = new HashSet<FACAccountSubType>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AccountTypeID { get; set; }

        public int AccountMasterTypeID { get; set; }

        [StringLength(200)]
        public string AccountTypeName { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        public int? AppearInReportTypeID { get; set; }

        [StringLength(1)]
        public string NatureDrCr { get; set; }

        public virtual FACAccountingReportType FACAccountingReportType { get; set; }

        public virtual FACAccountMasterType FACAccountMasterType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FACAccountSubType> FACAccountSubTypes { get; set; }
    }
}
