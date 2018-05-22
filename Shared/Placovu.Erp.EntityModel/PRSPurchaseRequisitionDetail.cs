namespace Placovu.Erp.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PRSPurchaseRequisitionDetail")]
    public partial class PRSPurchaseRequisitionDetail
    {
        [Key]
        public long RequisitionDetailsID { get; set; }

        public long? RequisitionID { get; set; }

        public int? ItemID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? RequistionQty { get; set; }

        [Column(TypeName = "money")]
        public decimal? UnitPrice { get; set; }

        [Column(TypeName = "money")]
        public decimal? LineTotal { get; set; }

        public int? MeasurementUnitID { get; set; }

        [StringLength(50)]
        public string MeasurementUnitText { get; set; }

        [Column(TypeName = "text")]
        public string Description { get; set; }

        public virtual INVItemInfo INVItemInfo { get; set; }

        public virtual PRSPurchaseRequisition PRSPurchaseRequisition { get; set; }
    }
}
