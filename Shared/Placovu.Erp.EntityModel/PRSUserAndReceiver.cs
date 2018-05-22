namespace Placovu.Erp.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRSUserAndReceiver")]
    public partial class PRSUserAndReceiver
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PRSUserAndReceiver()
        {
            PRSUserAndReceiverDetails = new HashSet<PRSUserAndReceiverDetail>();
        }

        [Key]
        public long ReceiverID { get; set; }

        public int BusinessUnitID { get; set; }

        public int UserID { get; set; }

        public bool? IsActive { get; set; }

        public virtual BSEBusinessUnit BSEBusinessUnit { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PRSUserAndReceiverDetail> PRSUserAndReceiverDetails { get; set; }
    }
}
