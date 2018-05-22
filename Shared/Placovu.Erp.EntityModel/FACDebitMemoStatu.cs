namespace Placovu.Erp.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FACDebitMemoStatu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FACDebitMemoStatu()
        {
            FACDebitMemoes = new HashSet<FACDebitMemo>();
        }

        [Key]
        public int DebitMemoStatusID { get; set; }

        [StringLength(50)]
        public string DebitMemoStatusName { get; set; }

        public bool? isActive { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FACDebitMemo> FACDebitMemoes { get; set; }
    }
}
