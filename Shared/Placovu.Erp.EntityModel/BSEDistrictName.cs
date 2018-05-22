namespace Placovu.Erp.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BSEDistrictName")]
    public partial class BSEDistrictName
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DistrictID { get; set; }

        [StringLength(50)]
        public string DictrictName { get; set; }

        [StringLength(50)]
        public string DivisionID { get; set; }
    }
}
