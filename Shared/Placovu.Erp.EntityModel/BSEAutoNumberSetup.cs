namespace Placovu.Erp.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BSEAutoNumberSetup")]
    public partial class BSEAutoNumberSetup
    {
        [Key]
        public int AutoNumberSetupID { get; set; }

        [StringLength(50)]
        public string DocumentName { get; set; }

        [Required]
        [StringLength(5)]
        public string DocumentCode { get; set; }

        [StringLength(4)]
        public string Prefix { get; set; }

        [StringLength(1)]
        public string Separator { get; set; }

        public int? NextNumber { get; set; }

        [StringLength(50)]
        public string Year { get; set; }

        public int? UpdatedBy { get; set; }

        public DateTime? UpdatedDate { get; set; }
    }
}
