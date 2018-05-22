namespace Placovu.Erp.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FACFiscalYearTest")]
    public partial class FACFiscalYearTest
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FACFiscalYearTest()
        {
            FACAccountingPeriodTests = new HashSet<FACAccountingPeriodTest>();
        }

        [Key]
        public int FiscalYearID { get; set; }

        public int? FiscalYear { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        [StringLength(50)]
        public string FiscalYearStatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FACAccountingPeriodTest> FACAccountingPeriodTests { get; set; }
    }
}
