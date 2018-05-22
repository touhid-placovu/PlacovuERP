namespace Placovu.Erp.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BSEMeasurementUnit")]
    public partial class BSEMeasurementUnit
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BSEMeasurementUnit()
        {
            FACBillingDetails = new HashSet<FACBillingDetail>();
            INVItemInfoes = new HashSet<INVItemInfo>();
            INVItemInitialBalances = new HashSet<INVItemInitialBalance>();
            INVPutawayDetails = new HashSet<INVPutawayDetail>();
        }

        [Key]
        public int UnitID { get; set; }

        [StringLength(10)]
        public string UnitName { get; set; }

        [StringLength(250)]
        public string Description { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FACBillingDetail> FACBillingDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INVItemInfo> INVItemInfoes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INVItemInitialBalance> INVItemInitialBalances { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<INVPutawayDetail> INVPutawayDetails { get; set; }
    }
}
