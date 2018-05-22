namespace Placovu.Erp.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FACBillingDetail")]
    public partial class FACBillingDetail
    {
        [Key]
        public int BillDetailID { get; set; }

        public int? BillID { get; set; }

        public int? ItemID { get; set; }

        [Column(TypeName = "money")]
        public decimal? ItemAmount { get; set; }

        [StringLength(500)]
        public string ItemMemo { get; set; }

        public int? MeasurementUnitID { get; set; }

        public int? ItemQuantity { get; set; }

        [Column(TypeName = "money")]
        public decimal? ItemUnitPrice { get; set; }

        public virtual BSEMeasurementUnit BSEMeasurementUnit { get; set; }

        public virtual FACBilling FACBilling { get; set; }

        public virtual INVItemInfo INVItemInfo { get; set; }
    }
}
