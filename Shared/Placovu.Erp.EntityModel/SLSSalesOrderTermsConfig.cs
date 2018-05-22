namespace Placovu.Erp.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SLSSalesOrderTermsConfig")]
    public partial class SLSSalesOrderTermsConfig
    {
        [Key]
        public int SOTermsConfigID { get; set; }

        [StringLength(250)]
        public string SOTermsConfigName { get; set; }

        [StringLength(1000)]
        public string TermsDefaultValue { get; set; }
    }
}
