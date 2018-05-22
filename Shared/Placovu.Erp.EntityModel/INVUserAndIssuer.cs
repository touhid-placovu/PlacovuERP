namespace Placovu.Erp.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("INVUserAndIssuer")]
    public partial class INVUserAndIssuer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public INVUserAndIssuer()
        {
            INVUserAndIssuerDetails = new HashSet<INVUserAndIssuerDetail>();
        }

        [Key]
        public long IssuerID { get; set; }

        public int BusinessUnitID { get; set; }

        public int UserID { get; set; }

        public bool? IsActive { get; set; }

        public virtual BSEBusinessUnit BSEBusinessUnit { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INVUserAndIssuerDetail> INVUserAndIssuerDetails { get; set; }
    }
}
