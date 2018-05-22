namespace Placovu.Erp.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("INVItemInitialBalance")]
    public partial class INVItemInitialBalance
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ItemID { get; set; }

        [StringLength(50)]
        public string ItemName { get; set; }

        public int? ItemGroupID { get; set; }

        public int? ItemTypeID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ItemBusinessUnitID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ItemStorageLocationID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ItemTotal { get; set; }

        public int? MeasurementUnitID { get; set; }

        public bool? IsCommitted { get; set; }

        public virtual BSEBusinessUnit BSEBusinessUnit { get; set; }

        public virtual BSEMeasurementUnit BSEMeasurementUnit { get; set; }
    }
}
