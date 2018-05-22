namespace Placovu.Erp.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BSEOperatingUnit")]
    public partial class BSEOperatingUnit
    {
        [Key]
        public int OperatingUnitID { get; set; }

        [StringLength(100)]
        public string OperatingUnitName { get; set; }

        public bool? IsActive { get; set; }

        public int? BusinessUnitID { get; set; }
    }
}
