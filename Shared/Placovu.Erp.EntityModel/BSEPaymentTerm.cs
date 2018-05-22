namespace Placovu.Erp.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BSEPaymentTerm")]
    public partial class BSEPaymentTerm
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BSEPaymentTerm()
        {
            FACBillings = new HashSet<FACBilling>();
        }

        [Key]
        public byte PaymentTermID { get; set; }

        [StringLength(200)]
        public string TermName { get; set; }

        [StringLength(2000)]
        public string TermDescription { get; set; }

        public bool? IsActive { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FACBilling> FACBillings { get; set; }
    }
}
