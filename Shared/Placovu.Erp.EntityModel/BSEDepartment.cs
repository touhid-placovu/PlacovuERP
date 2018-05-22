namespace Placovu.Erp.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BSEDepartment")]
    public partial class BSEDepartment
    {
        [Key]
        public int DepartmentID { get; set; }

        public int? BusinessUnitID { get; set; }

        [StringLength(150)]
        public string DepartmentName { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        public bool? IsActive { get; set; }

        public virtual BSEBusinessUnit BSEBusinessUnit { get; set; }
    }
}
