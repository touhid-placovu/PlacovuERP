namespace Placovu.Erp.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FACAccountConfiguration")]
    public partial class FACAccountConfiguration
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ConfigurationID { get; set; }

        [StringLength(200)]
        public string ConfigurationName { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        public int? AccountCode { get; set; }

        public int? AddedBy { get; set; }

        public DateTime? AddedDate { get; set; }

        public int? UpdatedBy { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public virtual FACChartOfAccount FACChartOfAccount { get; set; }
    }
}
