namespace Placovu.Erp.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("INVStorageLocation")]
    public partial class INVStorageLocation
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StorageLocationID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BusinessUnitID { get; set; }

        public int? LocationID { get; set; }

        [StringLength(50)]
        public string StorageLocationName { get; set; }

        [StringLength(250)]
        public string Description { get; set; }

        public int? InventoryTypeID { get; set; }

        public virtual BSEBusinessUnit BSEBusinessUnit { get; set; }

        public virtual BSELocation BSELocation { get; set; }
    }
}
