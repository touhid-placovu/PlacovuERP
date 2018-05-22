namespace Placovu.Erp.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("INVInventoryType")]
    public partial class INVInventoryType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int InventoryTypeID { get; set; }

        [StringLength(50)]
        public string InventoryTypeName { get; set; }

        [StringLength(250)]
        public string Description { get; set; }

        public int? AccountCodeDr { get; set; }

        public int? AccountCodeCr { get; set; }

        public virtual FACChartOfAccount FACChartOfAccount { get; set; }
    }
}
