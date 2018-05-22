namespace Placovu.Erp.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("INVItemBalance")]
    public partial class INVItemBalance
    {
        [Key]
        public long ItemBalanceID { get; set; }

        public int? ItemID { get; set; }

        [StringLength(100)]
        public string ItemName { get; set; }

        public int? ItemGroupID { get; set; }

        public int? ItemTypeID { get; set; }

        public int? ItemBusinessUnitID { get; set; }

        public int? ItemStorageLocationID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ItemTotal { get; set; }

        public int? MeasurementUnitID { get; set; }

        [Column(TypeName = "money")]
        public decimal AvgPrice { get; set; }

        [Column(TypeName = "money")]
        public decimal? AvgPricePurchase { get; set; }

        [Column(TypeName = "money")]
        public decimal? AvgPriceProduction { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? OpeningQty { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? OpeningQtyAP { get; set; }

        [Column(TypeName = "money")]
        public decimal? OpeningCogmAP { get; set; }
    }
}
