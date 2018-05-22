namespace Placovu.Erp.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FACAccountingReportType")]
    public partial class FACAccountingReportType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ReportTypeID { get; set; }

        [StringLength(200)]
        public string AccountTypeName { get; set; }

        [StringLength(500)]
        public string TypeDescription { get; set; }

        public virtual FACAccountType FACAccountType { get; set; }
    }
}
