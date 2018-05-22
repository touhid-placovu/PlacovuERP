namespace Placovu.Erp.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BSECountry")]
    public partial class BSECountry
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BSECountry()
        {
            BSEBusinessParties = new HashSet<BSEBusinessParty>();
            BSEBusinessPartyBankInfoes = new HashSet<BSEBusinessPartyBankInfo>();
            BSELocations = new HashSet<BSELocation>();
        }

        [Key]
        public int CountryID { get; set; }

        [StringLength(5)]
        public string ISO { get; set; }

        [StringLength(100)]
        public string CountryName { get; set; }

        [StringLength(5)]
        public string ISO3 { get; set; }

        [StringLength(5)]
        public string NumCode { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BSEBusinessParty> BSEBusinessParties { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BSEBusinessPartyBankInfo> BSEBusinessPartyBankInfoes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BSELocation> BSELocations { get; set; }
    }
}
