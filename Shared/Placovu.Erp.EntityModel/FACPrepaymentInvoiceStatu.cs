namespace Placovu.Erp.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FACPrepaymentInvoiceStatu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FACPrepaymentInvoiceStatu()
        {
            FACPrepaymentInvoices = new HashSet<FACPrepaymentInvoice>();
        }

        [Key]
        public int InvStatusID { get; set; }

        [StringLength(150)]
        public string InvStatusName { get; set; }

        public bool? IsActive { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FACPrepaymentInvoice> FACPrepaymentInvoices { get; set; }
    }
}
