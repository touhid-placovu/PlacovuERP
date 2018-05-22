namespace Placovu.Erp.EntityModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FACJournalDetail")]
    public partial class FACJournalDetail
    {
        [Key]
        public long JournalDetailID { get; set; }

        public long JournalID { get; set; }

        public int AccountCode { get; set; }

        [Column(TypeName = "money")]
        public decimal? DrAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? CrAmount { get; set; }

        [StringLength(5)]
        public string DrCrFactor { get; set; }

        [StringLength(50)]
        public string Description { get; set; }

        [Column(TypeName = "money")]
        public decimal? ForeignDrAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal? ForeignCrAmount { get; set; }

        public int? BusinessPartyID { get; set; }

        [Column(TypeName = "timestamp")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [MaxLength(8)]
        public byte[] RowVersion { get; set; }

        public virtual BSEBusinessParty BSEBusinessParty { get; set; }

        public virtual FACChartOfAccount FACChartOfAccount { get; set; }

        public virtual FACJournal FACJournal { get; set; }
    }
}
