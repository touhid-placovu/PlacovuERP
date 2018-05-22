namespace Placovu.Erp.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("INVItemPriceHistory")]
    public partial class INVItemPriceHistory
    {
        [Key]
        public long ItemPriceHistoryID { get; set; }

        public int? ItemID { get; set; }

        [Column(TypeName = "money")]
        public decimal? OldPurchasePrice { get; set; }

        [Column(TypeName = "money")]
        public decimal? NewPurchasePrice { get; set; }

        [Column(TypeName = "money")]
        public decimal? OldSellingPrice { get; set; }

        [Column(TypeName = "money")]
        public decimal? NewSellingPrice { get; set; }

        public DateTime? Date { get; set; }
    }
}
