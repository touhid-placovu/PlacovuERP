namespace Placovu.Erp.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FACInitialBalance")]
    public partial class FACInitialBalance
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BusinessUnitID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FiscalYear { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AccountingPeriod { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AccountCode { get; set; }

        [Column(TypeName = "money")]
        public decimal PostedDrAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal PostedCrAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? PostedTotalAmount { get; set; }

        public int? AccountingPeriodID { get; set; }

        public Guid? GLedgerID { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] TimeStamp { get; set; }

        public int? AddedBy { get; set; }

        public DateTime? DateAdded { get; set; }

        public int? UpdatedBy { get; set; }

        public DateTime? DateUpdated { get; set; }

        public bool? IsCommitted { get; set; }

        public int? CommittedBy { get; set; }

        public DateTime? DateCommitted { get; set; }

        public virtual FACChartOfAccount FACChartOfAccount { get; set; }
    }
}
