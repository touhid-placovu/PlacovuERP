namespace Placovu.Erp.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FACJournalType")]
    public partial class FACJournalType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FACJournalType()
        {
            FACJournals = new HashSet<FACJournal>();
        }

        [Key]
        public int JournalTypeID { get; set; }

        [StringLength(20)]
        public string TypeName { get; set; }

        [StringLength(50)]
        public string TypeDescription { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FACJournal> FACJournals { get; set; }
    }
}
