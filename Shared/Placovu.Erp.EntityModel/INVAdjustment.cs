namespace Placovu.Erp.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("INVAdjustment")]
    public partial class INVAdjustment
    {
        [Key]
        public int AdjustmentID { get; set; }

        public DateTime? AdjustmentDate { get; set; }

        public int? BusinessUnitID { get; set; }

        public int? StorageLocationID { get; set; }

        public int? AdjustmentByUserID { get; set; }

        [StringLength(250)]
        public string SummaryNote { get; set; }

        public int? AccountCode { get; set; }

        public virtual BSEBusinessUnit BSEBusinessUnit { get; set; }

        public virtual FACChartOfAccount FACChartOfAccount { get; set; }
    }
}
