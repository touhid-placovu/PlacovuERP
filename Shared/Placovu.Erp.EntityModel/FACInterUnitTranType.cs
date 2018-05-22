namespace Placovu.Erp.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FACInterUnitTranType")]
    public partial class FACInterUnitTranType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FACInterUnitTranType()
        {
            FACJournals = new HashSet<FACJournal>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short InterUnitTranTypeID { get; set; }

        [StringLength(50)]
        public string InterUnitTranType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FACJournal> FACJournals { get; set; }
    }
}
