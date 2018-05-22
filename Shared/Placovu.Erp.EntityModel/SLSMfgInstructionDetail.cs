namespace Placovu.Erp.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SLSMfgInstructionDetail")]
    public partial class SLSMfgInstructionDetail
    {
        [Key]
        public long MfgInstructionDetailID { get; set; }

        public long? MIID { get; set; }

        public int? ItemID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? SalesOrderQty { get; set; }

        public int? MeasurementUnitID { get; set; }

        [StringLength(50)]
        public string MeasurementUnitText { get; set; }

        [StringLength(500)]
        public string Specification { get; set; }

        public int? BatchID { get; set; }

        public int? PackingID { get; set; }

        public long? SalesOrderDetailsID { get; set; }

        public virtual INVItemInfo INVItemInfo { get; set; }

        public virtual SLSMfgInstruction SLSMfgInstruction { get; set; }
    }
}
