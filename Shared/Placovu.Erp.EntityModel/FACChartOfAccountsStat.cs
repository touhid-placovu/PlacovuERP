namespace Placovu.Erp.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FACChartOfAccountsStat")]
    public partial class FACChartOfAccountsStat
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AccountCode { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalDebitAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalCreditAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalBalance { get; set; }

        public virtual FACChartOfAccount FACChartOfAccount { get; set; }
    }
}
