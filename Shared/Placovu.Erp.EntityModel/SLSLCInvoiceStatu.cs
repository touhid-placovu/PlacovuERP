namespace Placovu.Erp.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SLSLCInvoiceStatu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SLSLCInvoiceStatu()
        {
            SLSLCs = new HashSet<SLSLC>();
        }

        [Key]
        public int LCInvoiceStatusID { get; set; }

        [StringLength(50)]
        public string LCInvoiceStatusName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SLSLC> SLSLCs { get; set; }
    }
}
