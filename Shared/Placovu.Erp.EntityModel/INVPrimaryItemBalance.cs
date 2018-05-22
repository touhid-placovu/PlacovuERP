namespace Placovu.Erp.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("INVPrimaryItemBalance")]
    public partial class INVPrimaryItemBalance
    {
        [Key]
        public long PrimaryItemBalanceID { get; set; }

        public int? ItemID { get; set; }

        [StringLength(50)]
        public string ItemName { get; set; }

        public int? ItemGroupID { get; set; }

        public int? ItemTypeID { get; set; }

        public int? BusinessUnitID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TotalQuantity { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? PutawayQuantity { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ValuatedQuantity { get; set; }

        public virtual INVItemInfo INVItemInfo { get; set; }
    }
}
