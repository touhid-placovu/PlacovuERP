namespace Placovu.Erp.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FACCreditMemoStatu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FACCreditMemoStatu()
        {
            FACCreditMemoes = new HashSet<FACCreditMemo>();
        }

        [Key]
        public int CreditMemoStatusID { get; set; }

        [StringLength(50)]
        public string CreditMemoStatusName { get; set; }

        public bool? isActive { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FACCreditMemo> FACCreditMemoes { get; set; }
    }
}
