namespace Placovu.Erp.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FACSourceProcess")]
    public partial class FACSourceProcess
    {
        [Key]
        [StringLength(10)]
        public string ProcessID { get; set; }

        [StringLength(500)]
        public string ProcessDescription { get; set; }
    }
}
