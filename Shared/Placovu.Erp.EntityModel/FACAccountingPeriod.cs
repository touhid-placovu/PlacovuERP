namespace Placovu.Erp.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FACAccountingPeriod")]
    public partial class FACAccountingPeriod
    {
        [Key]
        public int AccountingPeriodID { get; set; }

        [StringLength(12)]
        public string AccountingPeriodCode { get; set; }

        [StringLength(100)]
        public string AccountingPeriodName { get; set; }

        public int? FiscalYearID { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        [StringLength(10)]
        public string APStatus { get; set; }

        public bool? IsOpening { get; set; }

        public int? ClosedBy { get; set; }

        public DateTime? ClosingDate { get; set; }

        public int? ReOpenBy { get; set; }

        public DateTime? ReOpenDate { get; set; }

        public int? FiscalYear { get; set; }

        public int? AccountingPeriod { get; set; }

        public int? BusinessUnitID { get; set; }

        [StringLength(50)]
        public string FiscalYearDisplay { get; set; }

        public virtual BSEBusinessUnit BSEBusinessUnit { get; set; }

        public virtual FACFiscalYear FACFiscalYear { get; set; }

        public virtual SECUser SECUser { get; set; }

        public virtual SECUser SECUser1 { get; set; }
    }
}
