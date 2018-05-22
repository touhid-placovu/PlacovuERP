namespace Placovu.Erp.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SLSSalesOrderAmendment")]
    public partial class SLSSalesOrderAmendment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SLSSalesOrderAmendment()
        {
            SLSSalesOrderAmendmentDetails = new HashSet<SLSSalesOrderAmendmentDetail>();
        }

        [Key]
        public long AmendmentID { get; set; }

        public long? SalesOrderID { get; set; }

        public int? AmendedBy { get; set; }

        public DateTime? AmendedDate { get; set; }

        [StringLength(200)]
        public string AmendNotes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SLSSalesOrderAmendmentDetail> SLSSalesOrderAmendmentDetails { get; set; }
    }
}
