namespace Placovu.Erp.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FACAccountingPeriodTest")]
    public partial class FACAccountingPeriodTest
    {
        [Key]
        public int AccountingPeriodID { get; set; }

        [StringLength(10)]
        public string AccountingPeriodCode { get; set; }

        [StringLength(100)]
        public string AccountingPeriodName { get; set; }

        public int? FiscalYearID { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        [StringLength(10)]
        public string APStatus { get; set; }

        public bool? IsOpening { get; set; }

        public virtual FACFiscalYearTest FACFiscalYearTest { get; set; }
    }
}
