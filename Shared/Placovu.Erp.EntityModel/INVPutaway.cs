namespace Placovu.Erp.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("INVPutaway")]
    public partial class INVPutaway
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public INVPutaway()
        {
            INVPutawayDetails = new HashSet<INVPutawayDetail>();
        }

        [Key]
        public long PutawayID { get; set; }

        public int? BusinessUnitID { get; set; }

        public DateTime? PutawayDate { get; set; }

        public int? PutawayBy { get; set; }

        public virtual BSEBusinessUnit BSEBusinessUnit { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INVPutawayDetail> INVPutawayDetails { get; set; }
    }
}
